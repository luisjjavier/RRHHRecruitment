using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Models;
using System;
using System.Windows.Forms;
using Unity;

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
            RoleToolStrip.Text = $@"Role: {Program.TranslateRoleType[user.RoleType]}";
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


        private void gestionDeIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(LanguageForm));
        }

        private void gestionDePuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(JobsForm));
        }

        private void ShowForm(Type type)
        {
            Form form = Application.OpenForms[type.Name]  ?? _container.Resolve(type) as Form;

            form.MdiParent = this;
            form.Show();
            form.Focus();
        }

        private void gestionDeCompetenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(CompetitionsForm));
        }

        private void gestionDeCapacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(TrainingsForm));
        }

        private void gestionExperienciaDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(WorkExperienceForm));
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(UsersForm));
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(EmployeesForm));
        }
    }
}
