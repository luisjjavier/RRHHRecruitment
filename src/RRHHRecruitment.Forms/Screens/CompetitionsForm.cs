using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CompetitionsForm : MetroForm
    {
        private readonly CompetitionsService _competitionsService;
        private readonly IUnityContainer _container;

        public CompetitionsForm(CompetitionsService competitionsService, IUnityContainer container)
        {
            InitializeComponent();

            _competitionsService = competitionsService;

            competitionBindingSource.DataSource = competitionsService.GetCompetition(Program.CurrentUser.Id);
            _container = container;
        }

        public List<Competition> Competitions { get; internal set; } = new List<Competition>();
        public bool IsSelectionMode { get; internal set; }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            var form = _container.Resolve<CreateCompetition>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "La competencia se ha creado correctamente!", "Creación de competencia",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                competitionBindingSource.DataSource = _competitionsService.GetCompetition(Program.CurrentUser.Id);
            }
        }

        private void metroButton2_Click(object sender, System.EventArgs e)
        {
            var competition = competitionBindingSource.Current as Competition;
            if (MetroMessageBox.Show(this, $"Desea borrar esta competencia {competition.Description}?", "Borrar competencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IOperationResult<Competition> basicOperationResult = _competitionsService.DeleteCompetition(competition);
                if (basicOperationResult.Success)
                {
                    competitionBindingSource.DataSource = _competitionsService.GetCompetition(Program.CurrentUser.Id);

                }
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var competition = competitionBindingSource.Current as Competition;
            CreateCompetition form = _container.Resolve<CreateCompetition>();

            form.CurrentCompetition = competition;

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "La competencia de trabajo fue editada correctamente!", "Edición de competencia",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                competitionBindingSource.DataSource = _competitionsService.GetCompetition(Program.CurrentUser.Id);
            }
        }

        private void metroButton3_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < metroGrid1.SelectedRows.Count; i++)
            {
                Competitions.Add((Competition)metroGrid1.SelectedRows[i].DataBoundItem);
            }

            DialogResult = DialogResult.OK;
            Close();

        }

        private void CompetitionsForm_Load(object sender, System.EventArgs e)
        {
            if (IsSelectionMode)
            {
                metroGrid1.MultiSelect = true;
                metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                metroButton1.Hide();
                metroButton2.Hide();
                metroButton3.Show();
            }
        }
    }
}
