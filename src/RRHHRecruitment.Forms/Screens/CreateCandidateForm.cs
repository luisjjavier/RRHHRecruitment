using RRHHRecruitment.Core.Services;
using System.Windows.Forms;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Models;
using Unity;
using System;
using MetroFramework;
using MetroFramework.Controls;
using RRHHRecruitment.Core.Contracts;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateCandidateForm : MetroForm
    {
        private readonly CandidatesService _candidatesService;
        private readonly IUnityContainer _container;
        private readonly JobsService _jobsService;
        private double maxSalary = 0;

        public Candidate CurrentCandidate { get; set; }

        public CreateCandidateForm(CandidatesService candidatesService, IUnityContainer container, JobsService jobsService)
        {
            InitializeComponent();
            _container = container;
            _candidatesService = candidatesService;
            cbJob.DataSource = new BindingSource(jobsService.GetJobs(), null);
            cbJob.DisplayMember = "Name";
            cbJob.ValueMember = "Id";
        }

        private void CreateCandidateForm_Load(object sender, System.EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, System.EventArgs e)
        {
            if (IsValidForm())
            {
                Candidate candidate = BuildCandidateRequest();
                IOperationResult<Candidate> basicOperationResult;

                if (CurrentCandidate == null)
                {
                    basicOperationResult = _candidatesService.CreateCandidate(candidate);
                }
                else
                {
                    candidate.Id = CurrentCandidate.Id;
                    basicOperationResult = _candidatesService.UpdateCandidate(candidate);
                }

                if (!basicOperationResult.Success)
                {
                    MetroMessageBox.Show(this, basicOperationResult.Message, "Creacion de puesto de trabajo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                this.CurrentCandidate = null;
                DialogResult = DialogResult.OK;
                Close();
            }


        }

        private Candidate BuildCandidateRequest()
        {
            return new Candidate
            {
                Name =  txtName.Text,
                Department =  txtDeparment.Text,
                Identification = txtIdentification.Text,
                SalaryToWhichHeAspires =  maxSalary,
                UserId =  Program.CurrentUser.Id,
                RecommendedBy =  txtRecommendBy.Text,
                JobId = (int)cbJob.SelectedValue,
                IsActive = true
            };
        }

        private bool IsValidForm()
        {
            candidateErrorProvider.Clear();

            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                isValidForm = false;
                candidateErrorProvider.SetError(txtName, "Por favor increse el nombre del candidato");
                txtName.WithError = true;
            }

            if (string.IsNullOrWhiteSpace(txtIdentification.Text))
            {
                isValidForm = false;
                candidateErrorProvider.SetError(txtName, "El valor ingresado en la cedula es incorrecto");
                txtIdentification.WithError = true;
            }

            if (maxSalary < 0)
            {
                isValidForm = false;
                candidateErrorProvider.SetError(txtSalary, "El monto del salario al que aspira es incorrecto");
                txtIdentification.WithError = true;
            }

            return isValidForm;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            double value;
            MetroTextBox textBox = sender as MetroTextBox;
            if (double.TryParse(textBox.Text.Replace("$", ""), out value))
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
                maxSalary = value;
            }
            else
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", maxSalary);
            }
        }
    }
}
