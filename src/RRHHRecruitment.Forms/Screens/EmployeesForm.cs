using System.Collections.Generic;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class EmployeesForm : MetroForm
    {
        private readonly EmployeeServices _employeeServices;
        private readonly IUnityContainer _container;

        public EmployeesForm(EmployeeServices employeeServices, IUnityContainer container)
        {
            InitializeComponent();

            _employeeServices = employeeServices;
            _container =  container;

            employeeBindingSource.DataSource = _employeeServices.GetEmployees();
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            List<Employee> list = _employeeServices.GetEmployees(fromDate.Value, ToDate.Value);
            ReportForm form = _container.Resolve<ReportForm>();

            form.Employees = list;
            form.Show();
        }
    }
}
