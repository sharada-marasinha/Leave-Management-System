using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Model
{
    public class Employee
    {
        // Properties
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int AnnualLeaveBalance { get; set; } = 14; // Default to 14 annual leaves
        public int CasualLeaveBalance { get; set; } = 7;  // Default to 7 casual leaves
        public int ShortLeaveBalance { get; set; } = 2;   // 2 short leaves per month
        public DateTime RoasterStartTime { get; set; }
        public DateTime RoasterEndTime { get; set; }

        // Constructor
        public Employee(int employeeID, string name, string password)
        {
            EmployeeID = employeeID;
            Name = name;
            Password = password;
        }

        // Methods to modify leave balances
        public void DeductAnnualLeave(int days)
        {
            if (AnnualLeaveBalance >= days)
            {
                AnnualLeaveBalance -= days;
            }
            else
            {
                throw new InvalidOperationException("Not enough annual leave balance.");
            }
        }

        public void DeductCasualLeave(int days)
        {
            if (CasualLeaveBalance >= days)
            {
                CasualLeaveBalance -= days;
            }
            else
            {
                throw new InvalidOperationException("Not enough casual leave balance.");
            }
        }

        public void DeductShortLeave()
        {
            if (ShortLeaveBalance > 0)
            {
                ShortLeaveBalance -= 1;
            }
            else
            {
                throw new InvalidOperationException("No short leave balance available.");
            }
        }

        // Method to display remaining leaves
        public string GetRemainingLeaves()
        {
            return $"Annual Leaves: {AnnualLeaveBalance}, Casual Leaves: {CasualLeaveBalance}, Short Leaves: {ShortLeaveBalance}";
        }

        // Overriding ToString for easy debugging and display
        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, Name: {Name}, Remaining Leaves: {GetRemainingLeaves()}";
        }
    }
}
