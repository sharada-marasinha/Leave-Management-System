using Leave_Management_System.DB;
using Leave_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Service
{
    internal class EmployeeService{

        private static EmployeeService instance;
        private EmployeeService() { }
        public static EmployeeService getInstance()
        {
            return instance == null ? instance = new EmployeeService() : instance;
        }

        public bool InsertEmployeeToDatabase(Employee employee)
        {
            try
            {
                string query = "INSERT INTO Employee ( Name, Password, AnnualLeaveBalance, CasualLeaveBalance, ShortLeaveBalance, RoasterStartTime, RoasterEndTime) " +
                               "VALUES (@Name, @Password, @AnnualLeaveBalance, @CasualLeaveBalance, @ShortLeaveBalance, @RoasterStartTime, @RoasterEndTime)";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Name", employee.Name);
                        command.Parameters.AddWithValue("@Password", employee.Password); // You should ideally hash the password
                        command.Parameters.AddWithValue("@AnnualLeaveBalance", employee.AnnualLeaveBalance);
                        command.Parameters.AddWithValue("@CasualLeaveBalance", employee.CasualLeaveBalance);
                        command.Parameters.AddWithValue("@ShortLeaveBalance", employee.ShortLeaveBalance);
                        command.Parameters.AddWithValue("@RoasterStartTime", employee.RoasterStartTime);
                        command.Parameters.AddWithValue("@RoasterEndTime", employee.RoasterEndTime);

                        int result = command.ExecuteNonQuery();
                        

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

        public Employee GetEmployeeById(int employeeId)
        {
            Employee employee = null;
            try
            {
                string query = "SELECT * FROM Employee WHERE EmployeeId = @EmployeeId";
                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                employee = new Employee
                                {
                                    EmployeeId = (int)reader["EmployeeId"],
                                    Name = reader["Name"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    AnnualLeaveBalance = (int)reader["AnnualLeaveBalance"],
                                    CasualLeaveBalance = (int)reader["CasualLeaveBalance"],
                                    ShortLeaveBalance = (int)reader["ShortLeaveBalance"],
                                    RoasterStartTime = (DateTime)reader["RoasterStartTime"],
                                    RoasterEndTime = (DateTime)reader["RoasterEndTime"]
                                };
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                string query = "SELECT * FROM Employee";
                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                       
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee
                                {
                                    EmployeeId = (int)reader["EmployeeId"],
                                    Name = reader["Name"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    AnnualLeaveBalance = (int)reader["AnnualLeaveBalance"],
                                    CasualLeaveBalance = (int)reader["CasualLeaveBalance"],
                                    ShortLeaveBalance = (int)reader["ShortLeaveBalance"],
                                    RoasterStartTime = (DateTime)reader["RoasterStartTime"],
                                    RoasterEndTime = (DateTime)reader["RoasterEndTime"]
                                };
                                employees.Add(employee);
                            }
                        }
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employees;
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                string query = "UPDATE Employee SET Name = @Name, Password = @Password, AnnualLeaveBalance = @AnnualLeaveBalance, " +
                               "CasualLeaveBalance = @CasualLeaveBalance, ShortLeaveBalance = @ShortLeaveBalance, " +
                               "RoasterStartTime = @RoasterStartTime, RoasterEndTime = @RoasterEndTime WHERE EmployeeId = @EmployeeId";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                        command.Parameters.AddWithValue("@Name", employee.Name);
                        command.Parameters.AddWithValue("@Password", employee.Password); // Ideally, hash the password
                        command.Parameters.AddWithValue("@AnnualLeaveBalance", employee.AnnualLeaveBalance);
                        command.Parameters.AddWithValue("@CasualLeaveBalance", employee.CasualLeaveBalance);
                        command.Parameters.AddWithValue("@ShortLeaveBalance", employee.ShortLeaveBalance);
                        command.Parameters.AddWithValue("@RoasterStartTime", employee.RoasterStartTime);
                        command.Parameters.AddWithValue("@RoasterEndTime", employee.RoasterEndTime);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        connection.Close();

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

        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                string query = "DELETE FROM Employee WHERE EmployeeId = @EmployeeId";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        connection.Close();
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


        public bool UpdateEmployeeLeaveBalance(Employee employee)
        {
            try
            {
                string query = "UPDATE Employee SET AnnualLeaveBalance = @AnnualLeaveBalance, CasualLeaveBalance = @CasualLeaveBalance, ShortLeaveBalance = @ShortLeaveBalance WHERE EmployeeID = @EmployeeID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AnnualLeaveBalance", employee.AnnualLeaveBalance);
                        command.Parameters.AddWithValue("@CasualLeaveBalance", employee.CasualLeaveBalance);
                        command.Parameters.AddWithValue("@ShortLeaveBalance", employee.ShortLeaveBalance);
                        command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeId);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        connection.Close();

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

    }
}
