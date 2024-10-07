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


namespace Leave_Management_System.Admin
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        // Connection string to the MS SQL Server database (adjust the data source, initial catalog, and authentication as needed)
        private string connectionString = "Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False";


        private void btnAddEmployeeOnAction_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(txtEmpId.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtEmpId.Text, out int employeeID))
                {
                    MessageBox.Show("Employee ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Roster start and end time validation
                if (rosterEnd <= rosterStart)
                {
                    MessageBox.Show("Roster end time must be after the start time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new Employee object
                Employee newEmployee = new Employee(employeeID, name, password)
                {
                    AnnualLeaveBalance = annualLeaves,
                    CasualLeaveBalance = casualLeaves,
                    ShortLeaveBalance = shortLeaves,
                    RoasterStartTime = rosterStart,
                    RoasterEndTime = rosterEnd
                };

                // Insert employee into the database
                if (InsertEmployeeToDatabase(newEmployee))
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form inputs after adding the employee
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertEmployeeToDatabase(Employee employee)
        {
            try
            {
                // SQL query to insert employee data
                string query = "INSERT INTO Employee (EmployeeID, Name, Password, AnnualLeaveBalance, CasualLeaveBalance, ShortLeaveBalance, RoasterStartTime, RoasterEndTime) " +
                               "VALUES (@EmployeeID, @Name, @Password, @AnnualLeaveBalance, @CasualLeaveBalance, @ShortLeaveBalance, @RoasterStartTime, @RoasterEndTime)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Define parameters
                        command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                        command.Parameters.AddWithValue("@Name", employee.Name);
                        command.Parameters.AddWithValue("@Password", employee.Password); // You should ideally hash the password
                        command.Parameters.AddWithValue("@AnnualLeaveBalance", employee.AnnualLeaveBalance);
                        command.Parameters.AddWithValue("@CasualLeaveBalance", employee.CasualLeaveBalance);
                        command.Parameters.AddWithValue("@ShortLeaveBalance", employee.ShortLeaveBalance);
                        command.Parameters.AddWithValue("@RoasterStartTime", employee.RoasterStartTime);
                        command.Parameters.AddWithValue("@RoasterEndTime", employee.RoasterEndTime);

                        // Open connection, execute command, and close connection
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        connection.Close();

                        // Check if insert was successful
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ClearFormFields()
        {
            txtEmpId.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtAnnualLeaves.Clear();
            txtCasualLeaves.Clear();
            txtShortLeaves.Clear();
            dateRoasterStartTime.Value = DateTime.Now;
            dateRoasterEndTime.Value = DateTime.Now;
        }

    }
}
