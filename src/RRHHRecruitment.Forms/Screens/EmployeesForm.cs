using MetroFramework.Forms;
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
    }
}
