using Leave_Management_System.Model;
using Leave_Management_System.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System.Controller.EmployeeController
{
    public partial class EmployeeDash : Form
    {
        Employee employee;
        public EmployeeDash(Employee employee)
        {
            InitializeComponent();
            loadComboBox();
            this.employee = employee;
            loadLabels(employee);
            loadLeaveCountLbl();



        }

        private void loadLabels(Employee employee)
        {
            lblEmpId.Text = "EMP0" + employee.EmployeeId.ToString();
            lblEmpName.Text = employee.Name;
            lblHelloText.Text = employee.Name;
            lblAnnualLeave.Text = employee.AnnualLeaveBalance.ToString();
            lblCasualLeave.Text = employee.CasualLeaveBalance.ToString();
            lblShortLeave.Text = employee.ShortLeaveBalance.ToString();
            txtEmpId.Text = employee.EmployeeId.ToString();

        }


        private void btnApplyOnAction_Click(object sender, EventArgs e)
        {
            try
            {
                int empId = int.Parse(txtEmpId.Text.Trim());
                int leaveTypeId = (int)((dynamic)cmbLeaveType.SelectedItem).Value;
                DateTime leaveStartDate = dateStartDate.Value;
                DateTime leaveEndDate = dateEndDate.Value;
                string note = richTextNote.Text.Trim();

                int leaveDays = (leaveEndDate - leaveStartDate).Days + 1;

                
                EmployeeService employeeService = EmployeeService.getInstance();
                Employee employee = employeeService.GetEmployeeById(empId);

                if (leaveTypeId == 1)
                {
                    if (employee.AnnualLeaveBalance < leaveDays)
                    {
                        MessageBox.Show("Not enough annual leave balance.", "Insufficient Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    employee.AnnualLeaveBalance -= leaveDays;
                }
                else if (leaveTypeId == 2)
                {
                    if (employee.CasualLeaveBalance < leaveDays)
                    {
                        MessageBox.Show("Not enough casual leave balance.", "Insufficient Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    employee.CasualLeaveBalance -= leaveDays;
                }
                else if (leaveTypeId == 3)
                {
                    if (employee.ShortLeaveBalance < leaveDays)
                    {
                        MessageBox.Show("Not enough short leave balance.", "Insufficient Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    employee.ShortLeaveBalance -= leaveDays; 
                }

                // Create a new leave application
                Leave newLeave = new Leave
                {
                    EmployeeID = empId,
                    LeaveTypeID = leaveTypeId,
                    LeaveStartDate = leaveStartDate,
                    LeaveEndDate = leaveEndDate,
                    LeaveStatus = "Pending",
                    Notes = note
                };

                // Insert the leave application into the database
                bool isSuccess = LeaveService.getInstance().InsertLeave(newLeave);

                if (isSuccess)
                {
                    employeeService.UpdateEmployeeLeaveBalance(employee);
                    loadLeaveCountLbl();
                    loadLabels(employee);


                    MessageBox.Show("Leave application submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to submit leave application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loadComboBox()
        {
            try
            {
                LeaveService leaveTypeService = LeaveService.getInstance();
                List<LeaveType> leaveTypes = leaveTypeService.GetAllLeaveTypes();

                // Clear existing items
                cmbLeaveType.Items.Clear();

                // Populate ComboBox with LeaveType names
                foreach (var leaveType in leaveTypes)
                {
                    cmbLeaveType.Items.Add(new { Text = leaveType.TypeName, Value = leaveType.LeaveTypeID });
                }

                // Set the DisplayMember and ValueMember for ComboBox
                cmbLeaveType.DisplayMember = "Text";
                cmbLeaveType.ValueMember = "Value";
                cmbLeaveType.SelectedIndex = -1; // Optional: Set no selection by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadLeaveCountLbl() {
            List<Leave> leaves = LeaveService.getInstance().GetLeavesByEmployeeId(int.Parse(txtEmpId.Text.Trim()));

            int pendingLeaveCount = 0;
            int approvedLeaveCount = 0;
            int rejectLeaveCount = 0;

            foreach (var leave in leaves) {
                switch (leave.LeaveStatus) {
                    case "Pending":pendingLeaveCount++; break;
                    case "Approved":approvedLeaveCount++; break;
                    case "Reject":rejectLeaveCount++; break;
                }
            }
            lblApprovedLeaveCount.Text=approvedLeaveCount.ToString();
            lblPendingLeaveCount.Text = pendingLeaveCount.ToString();
            lblRejectLeaveCount.Text = rejectLeaveCount.ToString();

        }


    }
}
