using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;
using RRHHRecruitment.Core.Services;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class UsersForm : MetroForm
    {
        private readonly UsersService _usersService;
        private readonly IUnityContainer _container;

        public UsersForm(UsersService usersService, IUnityContainer container)
        {
            InitializeComponent();

            _usersService = usersService;
            _container = container;

            userBindingSource.DataSource = _usersService.GetUsers();
        }

        private void metroGrid1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "roleTypeDataGridViewTextBoxColumn")
            {
                RoleType enumValue = (RoleType)e.Value;
                string enumstring = Program.TranslateRoleType[enumValue];
                e.Value = enumstring;
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var user = userBindingSource.Current as User;
            if (MetroMessageBox.Show(this, $"Desea desactivar este usuario {user.Name}?", "Desactivar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IOperationResult<User> basicOperationResult = _usersService.Deactivate(user);
                if (basicOperationResult.Success)
                {
                    userBindingSource.DataSource = _usersService.GetUsers();
                }
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            CreateUsersForm form = _container.Resolve<CreateUsersForm>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "puesto de trabajo creado correctamente!", "Creacion de puesto de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                userBindingSource.DataSource = _usersService.GetUsers();
            }
        }
    }
}
