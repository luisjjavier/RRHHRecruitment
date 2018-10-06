using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using System;
using System.Windows.Forms;
using RRHHRecruitment.Core.Models.Enums;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateUsersForm : MetroForm
    {
        private readonly UsersService _usersService;
        public User CurrentUser { get; set; }
        public CreateUsersForm(UsersService usersService)
        {
            InitializeComponent();
            _usersService = usersService;
            cbAcademicLevel.DataSource = new BindingSource(Program.TranslateRoleType, null);
            cbAcademicLevel.DisplayMember = "Value";
            cbAcademicLevel.ValueMember = "Key";
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidForm())
            {
                User newUser = BuildUserRequest();
                IOperationResult<User> basicOperationResult;

                if (CurrentUser == null)
                {
                    basicOperationResult = _usersService.CreateUser(newUser);
                }
                else
                {
                    newUser.Id = CurrentUser.Id;
                    basicOperationResult = _usersService.UpdateUser(newUser);
                }

                if (!basicOperationResult.Success)
                {
                    MetroMessageBox.Show(this, basicOperationResult.Message, "Creacion de usuarios",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                this.CurrentUser = null;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User BuildUserRequest()
        {
            return new User()
            {
                Name = txtNombre.Text,
                IsActive = true,
                Password = txtPassword.Text,
                RoleType = (RoleType) cbAcademicLevel.SelectedValue,
                Username = txtUsername.Text
            };
        }

        private bool IsValidForm()
        {
            usersError.Clear();
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                isValidForm = false;
                usersError.SetError(txtNombre, "Por favor increse el nombre y apellido del usuario");
                txtNombre.WithError = true;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                isValidForm = false;
                usersError.SetError(txtUsername, "Por favor increse el nombre de usuario");
                txtUsername.WithError = true;
            }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                isValidForm = false;
                usersError.SetError(txtPassword, "Por favor increse la contreña");
                txtUsername.WithError = true;
            }


            return isValidForm;
        }
    }
}
