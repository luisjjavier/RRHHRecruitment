using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using Unity;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;

namespace RRHHRecruitment.Forms.Screens
{
    public sealed partial class MainForm : MetroForm
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            _container = container;
            InitializeComponent();

            LoadUserData();
        }

        private void LoadUserData()
        {
            User user = Program.CurrentUser;

            UsernameToolStrip.Text = $@"Nombre de usuario: {user.Username}";
            RoleToolStrip.Text = $@"Role: {translateRoleType[user.RoleType]}";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult dialogResult =    MetroMessageBox.Show(this, "Está seguro que desea salir de la aplicación?", "Cerrar sesión",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Dictionary<RoleType, string> translateRoleType  = new Dictionary<RoleType, string>()
        {
            [RoleType.Admin] = "Administrador",
            [RoleType.Candidates]  = "Candidatos",
            [RoleType.HumanResources] = "Recursos Humanos"
        };

        private void gestionDeIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form languageForm  =  Application.OpenForms["LanguageForm"] ?? _container.Resolve<LanguageForm>();

            languageForm.MdiParent = this;
            languageForm.Show();
            languageForm.Focus();
        }
    }
}
