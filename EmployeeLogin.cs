using Leave_Management_System.Controller.EmployeeController;
using Leave_Management_System.Service;

namespace Leave_Management_System
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnLoginOnAction_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(txtId.Text.Trim());
            string userPassword = txtPassword.Text.Trim();

            Model.Employee employee = EmployeeService.getInstance().GetEmployeeById(empId);

            if (employee != null) {
                if (employee.Password == userPassword) {
                    EmployeeDash employeeDash = new EmployeeDash(employee);
                    employeeDash.Show();
                }
            }
        }
    }
}
