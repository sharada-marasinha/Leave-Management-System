using Leave_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Service
{
    internal class LeaveService
    {
        private static LeaveService instance;
        private LeaveService() { }

        public static LeaveService getInstance()
        {
            return instance == null ? instance = new LeaveService() : instance;
        }
        public bool InsertLeave(Leave leave)
        {
            try
            {
                string query = "INSERT INTO Leave (EmployeeID, LeaveTypeID, LeaveStartDate, LeaveEndDate, LeaveStatus, Notes, AppliedAt) " +
                               "VALUES (@EmployeeID, @LeaveTypeID, @LeaveStartDate, @LeaveEndDate, @LeaveStatus, @Notes, @AppliedAt)";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", leave.EmployeeID);
                        command.Parameters.AddWithValue("@LeaveTypeID", leave.LeaveTypeID);
                        command.Parameters.AddWithValue("@LeaveStartDate", leave.LeaveStartDate);
                        command.Parameters.AddWithValue("@LeaveEndDate", leave.LeaveEndDate);
                        command.Parameters.AddWithValue("@LeaveStatus", leave.LeaveStatus);
                        command.Parameters.AddWithValue("@Notes", leave.Notes ?? (object)DBNull.Value);  // Handle null values for Notes
                        command.Parameters.AddWithValue("@AppliedAt", leave.AppliedAt);

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
        public bool UpdateLeave(Leave leave)
        {
            try
            {
                string query = "UPDATE Leave SET EmployeeID = @EmployeeID, LeaveTypeID = @LeaveTypeID, " +
                               "LeaveStartDate = @LeaveStartDate, LeaveEndDate = @LeaveEndDate, LeaveStatus = @LeaveStatus, " +
                               "Notes = @Notes WHERE LeaveID = @LeaveID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveID", leave.LeaveID);
                        command.Parameters.AddWithValue("@EmployeeID", leave.EmployeeID);
                        command.Parameters.AddWithValue("@LeaveTypeID", leave.LeaveTypeID);
                        command.Parameters.AddWithValue("@LeaveStartDate", leave.LeaveStartDate);
                        command.Parameters.AddWithValue("@LeaveEndDate", leave.LeaveEndDate);
                        command.Parameters.AddWithValue("@LeaveStatus", leave.LeaveStatus);
                        command.Parameters.AddWithValue("@Notes", leave.Notes ?? (object)DBNull.Value);

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

        // Method to delete a leave record from the database
        public bool DeleteLeave(int leaveID)
        {
            try
            {
                string query = "DELETE FROM Leave WHERE LeaveID = @LeaveID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveID", leaveID);

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

        // Method to get a list of all leave records
        public List<Leave> GetAllLeaves()
        {
            List<Leave> leaves = new List<Leave>();

            try
            {
                string query = "SELECT * FROM Leave";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Leave leave = new Leave
                            {
                                LeaveID = (int)reader["LeaveID"],
                                EmployeeID = (int)reader["EmployeeID"],
                                LeaveTypeID = (int)reader["LeaveTypeID"],
                                LeaveStartDate = (DateTime)reader["LeaveStartDate"],
                                LeaveEndDate = (DateTime)reader["LeaveEndDate"],
                                LeaveStatus = reader["LeaveStatus"].ToString(),
                                Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : null,
                                AppliedAt = (DateTime)reader["AppliedAt"]
                            };
                            leaves.Add(leave);
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return leaves;
        }

        // Method to retrieve a specific leave by ID
        public Leave GetLeaveById(int leaveID)
        {
            Leave leave = null;

            try
            {
                string query = "SELECT * FROM Leave WHERE LeaveID = @LeaveID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveID", leaveID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            leave = new Leave
                            {
                                LeaveID = (int)reader["LeaveID"],
                                EmployeeID = (int)reader["EmployeeID"],
                                LeaveTypeID = (int)reader["LeaveTypeID"],
                                LeaveStartDate = (DateTime)reader["LeaveStartDate"],
                                LeaveEndDate = (DateTime)reader["LeaveEndDate"],
                                LeaveStatus = reader["LeaveStatus"].ToString(),
                                Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : null,
                                AppliedAt = (DateTime)reader["AppliedAt"]
                            };
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return leave;
        }

        public List<LeaveType> GetAllLeaveTypes()
        {
            List<LeaveType> leaveTypes = new List<LeaveType>();

            try
            {
                string query = "SELECT LeaveTypeID, TypeName, Description FROM LeaveType";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LeaveType leaveType = new LeaveType
                                {
                                    LeaveTypeID = reader.GetInt32(0),
                                    TypeName = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? null : reader.GetString(2)
                                };

                                leaveTypes.Add(leaveType);
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

            return leaveTypes;
        }

        public List<Leave> GetLeavesByEmployeeId(int employeeId)
        {
            List<Leave> leaves = new List<Leave>();

            try
            {
                string query = "SELECT LeaveID, EmployeeID, LeaveTypeID, LeaveStartDate, LeaveEndDate, LeaveStatus, Notes, AppliedAt " +
                               "FROM Leave WHERE EmployeeID = @EmployeeID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Leave leave = new Leave
                                {
                                    LeaveID = reader.GetInt32(0),
                                    EmployeeID = reader.GetInt32(1),
                                    LeaveTypeID = reader.GetInt32(2),
                                    LeaveStartDate = reader.GetDateTime(3),
                                    LeaveEndDate = reader.GetDateTime(4),
                                    LeaveStatus = reader.GetString(5),
                                    Notes = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    AppliedAt = reader.GetDateTime(7)
                                };

                                leaves.Add(leave);
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

            return leaves;
        }

        public LeaveType GetLeaveTypeById(int leaveTypeId)
        {
            LeaveType leaveType = null;

            try
            {
                string query = "SELECT LeaveTypeID, TypeName, Description FROM LeaveType WHERE LeaveTypeID = @LeaveTypeID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveTypeID", leaveTypeId);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                leaveType = new LeaveType
                                {
                                    LeaveTypeID = reader.GetInt32(0),
                                    TypeName = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? null : reader.GetString(2)
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

            return leaveType;
        }
        public bool UpdateLeaveStatus(int leaveId, string newStatus)
        {
            try
            {
                string query = "UPDATE Leave SET LeaveStatus = @NewStatus WHERE LeaveID = @LeaveID";

                using (SqlConnection connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", newStatus);
                        command.Parameters.AddWithValue("@LeaveID", leaveId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating leave status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}



