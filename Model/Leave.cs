using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Model
{
    internal class Leave
    {
        public int LeaveID { get; set; }            // Unique ID for each leave application
        public int EmployeeID { get; set; }         // Foreign key to Employee table
        public int LeaveTypeID { get; set; }        // Foreign key to LeaveType table
        public DateTime LeaveStartDate { get; set; } // Start date of leave
        public DateTime LeaveEndDate { get; set; }   // End date of leave
        public string LeaveStatus { get; set; } = "Pending";  // Status: Pending, Approved, Rejected
        public string Notes { get; set; }           // Additional information about the leave
        public DateTime AppliedAt { get; set; } = DateTime.Now;  // Timestamp when leave was applied
        public Leave()
        {
        }
        public Leave(int employeeID, int leaveTypeID, DateTime leaveStartDate, DateTime leaveEndDate, string notes = "")
        {
            EmployeeID = employeeID;
            LeaveTypeID = leaveTypeID;
            LeaveStartDate = leaveStartDate;
            LeaveEndDate = leaveEndDate;
            Notes = notes;
            AppliedAt = DateTime.Now;  // Automatically set to the current date/time when the leave is created
            LeaveStatus = "Pending";   // Default status
        }
    }
}
