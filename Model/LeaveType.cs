using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Model
{
    internal class LeaveType
    {
        public int LeaveTypeID { get; set; }   // Unique ID for each leave type
        public string TypeName { get; set; }    // Name of the leave type (e.g., Annual, Casual, Short)
        public string Description { get; set; }
    }
}
