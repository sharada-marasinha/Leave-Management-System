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
            employeeService = EmployeeService.getInstance(); // Initialize the service
        // Load employees when form is initialized
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
    }
}
