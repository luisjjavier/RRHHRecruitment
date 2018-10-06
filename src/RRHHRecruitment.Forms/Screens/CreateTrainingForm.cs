using MetroFramework.Forms;
using RRHHRecruitment.Core.Services;
using System.Windows.Forms;
using MetroFramework;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateTrainingForm : MetroForm
    {
        private readonly TrainingsService _trainingsService;

        public Training CurrentTraining { get; set; }

        public CreateTrainingForm(TrainingsService trainingsService)
        {
            InitializeComponent();
            _trainingsService = trainingsService;
            cbAcademicLevel.DataSource = new BindingSource(Program.TranslateAcademicLevel, null);
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
                Training training = BuildTrainingRequest();
                IOperationResult<Training> basicOperationResult;

                if (CurrentTraining == null)
                {
                    basicOperationResult = _trainingsService.CreateTraining(training);
                }
                else
                {
                    training.Id = CurrentTraining.Id;
                    basicOperationResult = _trainingsService.UpdateTraining(training);
                }

                if (!basicOperationResult.Success)
                {
                    MetroMessageBox.Show(this, basicOperationResult.Message, "Creacion de puesto de trabajo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                this.CurrentTraining = null;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Training BuildTrainingRequest()
            => new Training
            {
                IsActive = true,
                Description = txtDescription.Text,
                Institution = txtInstitution.Text,
                UserId = Program.CurrentUser.Id,
                AcademicLevel = (AcademicLevel)cbAcademicLevel.SelectedValue,
                FromDate = fromDate.Value,
                ToDate = toDate.Value
            };

        private bool IsValidForm()
        {
            traningErrorProvaider.Clear();
            txtDescription.WithError = true;
            txtInstitution.WithError = true;
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                isValidForm = false;
                traningErrorProvaider.SetError(txtInstitution, "Por favor increse la institución");
                txtInstitution.WithError = true;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                isValidForm = false;
                traningErrorProvaider.SetError(txtDescription, "Por favor increse la decripción de la capacitacion realizada");
                txtDescription.WithError = true;
            }

            if (fromDate.Value > toDate.Value)
            {
                isValidForm = false;
                traningErrorProvaider.SetError(fromDate, "La fecha desde no puede ser mayor de la hasta");
                traningErrorProvaider.SetError(toDate, "La fecha desde no puede ser mayor de la hasta");
            }


            return isValidForm;
        }

        private void CreateTrainingForm_Load(object sender, System.EventArgs e)
        {
            if (CurrentTraining != null )
            {
                txtDescription.Text = CurrentTraining.Description;
                txtInstitution.Text = CurrentTraining.Institution;
                cbAcademicLevel.SelectedValue = CurrentTraining.AcademicLevel;
                fromDate.Value = CurrentTraining.FromDate;
                toDate.Value = CurrentTraining.ToDate;
            }
        }
    }
}
