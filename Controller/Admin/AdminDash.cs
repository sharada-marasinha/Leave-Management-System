using Leave_Management_System.Service;
using Leave_Management_System.Model; // Assuming Employee class is here
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Leave_Management_System.Admin;

namespace Leave_Management_System.Controller.Admin
{
    public partial class AdminDash : Form
    {
        private EmployeeService employeeService;

        public AdminDash()
        {
            InitializeComponent();
            employeeService = EmployeeService.getInstance();
            loadAllLeaves();
            listViewLeaves.ItemActivate += new EventHandler(listViewLeaves_ItemActivate);
            loadLeaveCountLbl();

            listViewLeaves.Columns.Add("Leave ID", 100);
            listViewLeaves.Columns.Add("Employee ID", 100);
            listViewLeaves.Columns.Add("Leave Type", 120);
            listViewLeaves.Columns.Add("Start Date", 150);
            listViewLeaves.Columns.Add("End Date", 150);
            listViewLeaves.Columns.Add("Status", 100);
            listViewLeaves.View = View.Details;
        }

        // Method to load employees into TableLayoutPanel inside a scrollable Panel

        private void btnReloadOnAction_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployeeOnAction_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();


        }

        private void loadAllLeaves()
        {

            try
            {
                LeaveService leaveService = LeaveService.getInstance();
                List<Leave> allLeaves = leaveService.GetAllLeaves();  // Add a GetAllLeaves method in the service

                // Clear existing items in ListView
                listViewLeaves.Items.Clear();

                foreach (var leave in allLeaves)
                {
                   
                    string leaveTypeName = LeaveService.getInstance().GetLeaveTypeById(leave.LeaveTypeID).TypeName;

                   
                    ListViewItem item = new ListViewItem(leave.LeaveID.ToString());
                    item.SubItems.Add(leave.EmployeeID.ToString());
                    item.SubItems.Add(leaveTypeName);
                    item.SubItems.Add(leave.LeaveStartDate.ToShortDateString());
                    item.SubItems.Add(leave.LeaveEndDate.ToShortDateString());
                    item.SubItems.Add(leave.LeaveStatus);
                    item.SubItems.Add(leave.Notes);

                    listViewLeaves.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leaves: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void listViewLeaves_ItemActivate(object sender, EventArgs e)
        {
            if (listViewLeaves.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewLeaves.SelectedItems[0];

                string leaveID = selectedItem.SubItems[0].Text; 
                string employeeID = selectedItem.SubItems[1].Text;
                string leaveType = selectedItem.SubItems[2].Text; 
                string leaveStatus = selectedItem.SubItems[5].Text; 
                string leaveNote= selectedItem.SubItems[6].Text;
                Employee employee=null;
                if (employeeID!=null) {
                    employee = EmployeeService.getInstance().GetEmployeeById(int.Parse(employeeID));
                }

                txtLeaveID.Text = leaveID;
                txtEmployeeID.Text = employeeID;
                txtLeaveType.Text = leaveType;
                txtLeaveStatus.Text = leaveStatus;
                richTextNote.Text = leaveNote;
                txtEmployeName.Text = employee!=null?employee.Name:"EMPTY";

                DialogResult result = MessageBox.Show("Do you want to Approve this leave?", "Approve Leave", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    string newStatus = "Approved";
                    LeaveService.getInstance().UpdateLeaveStatus(int.Parse(leaveID), newStatus);
                    selectedItem.SubItems[5].Text = newStatus;
                    loadLeaveCountLbl();
                }
                else if (result == DialogResult.No)
                {
                    string newStatus = "Reject";
                    LeaveService.getInstance().UpdateLeaveStatus(int.Parse(leaveID), newStatus);
                    selectedItem.SubItems[5].Text = newStatus;
                    loadLeaveCountLbl();
                }
                else
                {
                    string newStatus = "Pending";
                    LeaveService.getInstance().UpdateLeaveStatus(int.Parse(leaveID), newStatus);
                    selectedItem.SubItems[5].Text = newStatus;
                    loadLeaveCountLbl();
                }
            }
        }

        private void loadLeaveCountLbl()
        {
            List<Leave> leaves = LeaveService.getInstance().GetAllLeaves();

            int pendingLeaveCount = 0;
            int approvedLeaveCount = 0;
            int rejectLeaveCount = 0;

            foreach (var leave in leaves)
            {
                switch (leave.LeaveStatus)
                {
                    case "Pending": pendingLeaveCount++; break;
                    case "Approved": approvedLeaveCount++; break;
                    case "Reject": rejectLeaveCount++; break;
                }
            }
            lblApprovedLeaveCount.Text = approvedLeaveCount.ToString();
            lblPendingLeaveCount.Text = pendingLeaveCount.ToString();
            lblRejectLeaveCount.Text = rejectLeaveCount.ToString();

        }
    }
}
