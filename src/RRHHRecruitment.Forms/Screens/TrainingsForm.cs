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
    public partial class TrainingsForm : MetroForm
    {
        private readonly TrainingsService _trainingsService;
        private readonly IUnityContainer _container;

        public TrainingsForm(TrainingsService trainingsService, IUnityContainer container )
        {
            InitializeComponent();

            _container = container;
            _trainingsService = trainingsService;

            trainingBindingSource.DataSource = _trainingsService.GetTrainings(Program.CurrentUser.Id);
        }

        private void metroGrid1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "academicLevelDataGridViewTextBoxColumn")
            {
                AcademicLevel enumValue = (AcademicLevel)e.Value;
                string enumstring = Program.TranslateAcademicLevel[enumValue];
                e.Value = enumstring;
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var training = trainingBindingSource.Current as Training;
            if (MetroMessageBox.Show(this, $"Desea borrar esta capacitación {training.Institution}?", "Borrar capacitación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IOperationResult<Training> basicOperationResult = _trainingsService.DeleteTraining(training);
                if (basicOperationResult.Success)
                {
                    trainingBindingSource.DataSource = _trainingsService.GetTrainings(Program.CurrentUser.Id);
                }
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            CreateTrainingForm form = _container.Resolve<CreateTrainingForm>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "La capicitacion se ha creado correctamente!", "Creacion de Capacitacion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                trainingBindingSource.DataSource = _trainingsService.GetTrainings(Program.CurrentUser.Id);
            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var training = trainingBindingSource.Current as Training;
            CreateTrainingForm form = _container.Resolve<CreateTrainingForm>();

            form.CurrentTraining = training;

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "La capacitación se ha editado correctamente!", "Edición de puesto de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                trainingBindingSource.DataSource = _trainingsService.GetTrainings(Program.CurrentUser.Id);
            }
        }
    }
}
