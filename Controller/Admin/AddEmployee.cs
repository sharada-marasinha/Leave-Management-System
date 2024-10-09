using Leave_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Leave_Management_System.DB;
using Leave_Management_System.Service;
using System.Xml.Linq;


namespace Leave_Management_System.Admin
{
    public partial class AddEmployee : Form
    {
        EmployeeService employeeService = EmployeeService.getInstance();
        public AddEmployee()
        {

            InitializeComponent();
            LoadEmployees();

        }
        private void btnAddEmployeeOnAction_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtAnnualLeaves.Text, out int annualLeaves))
                {
                    MessageBox.Show("Annual Leaves must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCasualLeaves.Text, out int casualLeaves))
                {
                    MessageBox.Show("Casual Leaves must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtShortLeaves.Text, out int shortLeaves))
                {
                    MessageBox.Show("Short Leaves must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                DateTime rosterStart = dateRoasterStartTime.Value;
                DateTime rosterEnd = dateRoasterEndTime.Value;

                if (rosterEnd <= rosterStart)
                {
                    MessageBox.Show("Roster end time must be after the start time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPassword.Text.Trim() != txtConformPassword.Text.Trim())
                {
                    MessageBox.Show("Your Password Not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Employee newEmployee = new Employee(name, password)
                {
                    AnnualLeaveBalance = annualLeaves,
                    CasualLeaveBalance = casualLeaves,
                    ShortLeaveBalance = shortLeaves,
                    RoasterStartTime = rosterStart,
                    RoasterEndTime = rosterEnd
                };

                if (employeeService.InsertEmployeeToDatabase(newEmployee))
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearFormFields()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtAnnualLeaves.Clear();
            txtCasualLeaves.Clear();
            txtShortLeaves.Clear();
            txtConformPassword.Clear();
            dateRoasterStartTime.Value = DateTime.Now;
            dateRoasterEndTime.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employees = this.employeeService.GetAllEmployees();

            employees.ForEach(emp =>
            {
                Console.WriteLine(emp.Name);
            });
        }
        private void LoadEmployees()
        {
            try
            {
                List<Employee> employees = employeeService.GetAllEmployees();
                if (employees != null && employees.Count > 0)
                {
                    // Clear existing rows in the TableLayoutPanel (except for header row if any)
                    tableEmployee.Controls.Clear();
                    tableEmployee.RowStyles.Clear();
                    tableEmployee.RowCount = 1; // Start from row 1 (assuming row 0 is the header)

                    // Add column headers (if not already added)
                    AddRowToTableLayoutPanel("ID", "Employee Name", "Annual Leave", "Casual Leave", "Short Leave", "Roaster Start", "Roaster End", true);

                    // Add rows for each employee
                    foreach (var employee in employees)
                    {
                        AddRowToTableLayoutPanel(
                            employee.EmployeeId.ToString(),
                            employee.Name,
                            employee.AnnualLeaveBalance.ToString(),
                            employee.CasualLeaveBalance.ToString(),
                            employee.ShortLeaveBalance.ToString(),
                            employee.RoasterStartTime.ToString(),
                            employee.RoasterEndTime.ToString()
                        );
                    }

                    tableEmployee.AutoSize = true;
                }
                else
                {
                    MessageBox.Show("No employees found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRowToTableLayoutPanel(string id, string name, string annualLeave, string casualLeave, string shortLeave, string roasterStart, string roasterEnd, bool isHeader = false)
        {
            tableEmployee.RowCount += 1;
            tableEmployee.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label lblId = new Label { Text = id, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            Label lblName = new Label { Text = name, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            Label lblAnnualLeave = new Label { Text = annualLeave, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            Label lblCasualLeave = new Label { Text = casualLeave, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            Label lblShortLeave = new Label { Text = shortLeave, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            Label lblRoasterStart = new Label { Text = roasterStart, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            Label lblRoasterEnd = new Label { Text = roasterEnd, TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            if (isHeader)
            {
                lblId.Font = new Font(lblId.Font, FontStyle.Bold);
                lblName.Font = new Font(lblName.Font, FontStyle.Bold);
                lblAnnualLeave.Font = new Font(lblAnnualLeave.Font, FontStyle.Bold);
                lblCasualLeave.Font = new Font(lblCasualLeave.Font, FontStyle.Bold);
                lblShortLeave.Font = new Font(lblShortLeave.Font, FontStyle.Bold);
                lblRoasterStart.Font = new Font(lblRoasterStart.Font, FontStyle.Bold);
                lblRoasterEnd.Font = new Font(lblRoasterEnd.Font, FontStyle.Bold);
            }
            tableEmployee.Controls.Add(lblId, 0, tableEmployee.RowCount - 1);
            tableEmployee.Controls.Add(lblName, 1, tableEmployee.RowCount - 1);
            tableEmployee.Controls.Add(lblAnnualLeave, 2, tableEmployee.RowCount - 1);
            tableEmployee.Controls.Add(lblCasualLeave, 3, tableEmployee.RowCount - 1);
            tableEmployee.Controls.Add(lblShortLeave, 4, tableEmployee.RowCount - 1);
            tableEmployee.Controls.Add(lblRoasterStart, 5, tableEmployee.RowCount - 1);
            tableEmployee.Controls.Add(lblRoasterEnd, 6, tableEmployee.RowCount - 1);
        }

        private void btnReloadOnAction_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnSearchOnAction_Click(object sender, EventArgs e)
        {

            Employee employee = employeeService.GetEmployeeById(int.Parse(txtSearchValue.Text.Trim()));

            if (employee != null)
            {
                setEmployeeToTxt(employee);
            }
        }

        private void setEmployeeToTxt(Employee employee)
        {
            txtName.Text = employee.Name;
            txtAnnualLeaves.Text = employee.AnnualLeaveBalance.ToString();
            txtCasualLeaves.Text = employee.CasualLeaveBalance.ToString();
            txtShortLeaves.Text = employee.ShortLeaveBalance.ToString();
            dateRoasterEndTime.Value = employee.RoasterEndTime;
            dateRoasterStartTime.Value = employee.RoasterStartTime;
            txtPassword.Text = employee.Password;
        }

        private void btnUpdateOnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtAnnualLeaves.Text, out int annualLeaves))
                {
                    MessageBox.Show("Annual Leaves must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCasualLeaves.Text, out int casualLeaves))
                {
                    MessageBox.Show("Casual Leaves must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtShortLeaves.Text, out int shortLeaves))
                {
                    MessageBox.Show("Short Leaves must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                DateTime rosterStart = dateRoasterStartTime.Value;
                DateTime rosterEnd = dateRoasterEndTime.Value;
                int employeeId = int.Parse(txtSearchValue.Text);


                if (rosterEnd <= rosterStart)
                {
                    MessageBox.Show("Roster end time must be after the start time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPassword.Text.Trim() != txtConformPassword.Text.Trim())
                {
                    MessageBox.Show("Your Password Not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Employee newEmployee = new Employee(name, password)
                {
                    EmployeeId = employeeId,
                    AnnualLeaveBalance = annualLeaves,
                    CasualLeaveBalance = casualLeaves,
                    ShortLeaveBalance = shortLeaves,
                    RoasterStartTime = rosterStart,
                    RoasterEndTime = rosterEnd
                };

                if (employeeService.UpdateEmployee(newEmployee))
                {
                    MessageBox.Show("Employee Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    LoadEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteOnAction_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(txtSearchValue.Text);
            if (employeeService.DeleteEmployee(employeeId))
            {
                MessageBox.Show("Employee Delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
            }
            else {
                MessageBox.Show("Employee Not Deleted", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
