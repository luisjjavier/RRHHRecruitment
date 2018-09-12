using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using System.Windows.Forms;
using MetroFramework;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class LoginForm : MetroForm
    {
        private readonly UsersService _usersService;
        private User _activeUser;

        public LoginForm(UsersService usersService)
        {
            _usersService = usersService;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (IsValidForm())
            {
                IOperationResult<User> operationResult   = _usersService.Authenticate(txtUsername.Text, txtPassword.Text);

                if (operationResult.Success)
                {
                    _activeUser = operationResult.Entity;

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroMessageBox.Show(this, operationResult.Message, "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool IsValidForm()
        {
            loginErrorProvider.Clear();
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                isValidForm = false;
                loginErrorProvider.SetError(txtUsername,"Por favor increse un usuario");
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                isValidForm = false;
                loginErrorProvider.SetError(txtPassword, "Por favor increse un usuario");
            }

            return isValidForm;
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public User GetActiveUser() => _activeUser;
    }
}
