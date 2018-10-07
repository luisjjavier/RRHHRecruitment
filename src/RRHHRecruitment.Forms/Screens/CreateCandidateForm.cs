using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateCandidateForm : MetroForm
    {
        private readonly CandidatesService _candidatesService;
        private readonly IUnityContainer _container;
        private readonly JobsService _jobsService;
        private readonly List<Language> _languages;
        private readonly List<Training> _trainings;
        private readonly List<WorkExperience> _workExperiences = new   List<WorkExperience>();
        private readonly  List<Competition> _competitions = new List<Competition>();
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
            _languages = new List<Language>();
            _trainings = new List<Training>();
        }

        private void CreateCandidateForm_Load(object sender, System.EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                txtIdentification.ReadOnly = true;
                txtIdentification.Text = CurrentCandidate.Identification;
                txtDeparment.Text = CurrentCandidate.Department;
                txtDeparment.ReadOnly = true;
                txtName.Text = CurrentCandidate.Name;
                txtName.ReadOnly = true;
                txtRecommendBy.ReadOnly = true;
                cbJob.Enabled = true;
                txtRecommendBy.Text = CurrentCandidate.RecommendedBy;
                cbJob.SelectedValue = CurrentCandidate.JobId;
                txtSalary.Text = CurrentCandidate.SalaryToWhichHeAspires.ToString("C2");
                txtSalary.ReadOnly = true;
                metroButton8.Hide();
                metroButton9.Text = "Aceptar";
                _trainings.AddRange(_candidatesService.GetCandidateTrainings(CurrentCandidate.Id));
                trainingBindingSource.DataSource = _trainings;

                _languages.AddRange(_candidatesService.GetLanguages(CurrentCandidate.Id));
                languageBindingSource.DataSource = _languages;
                
                _workExperiences.AddRange(_candidatesService.GetWorkExperiences(CurrentCandidate.Id));
                workExperienceBindingSource.DataSource = _workExperiences;

                _competitions.AddRange(_candidatesService.GetCompetitions(CurrentCandidate.Id));
                competitionBindingSource.DataSource = _competitions;

            }
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
                Competitions =  new HashSet<Competition>(_competitions),
                Trainings = new HashSet<Training>(_trainings),
                WorkExperiences = new HashSet<WorkExperience>(_workExperiences),
                Languages = new HashSet<Language>(_languages),
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

            if (string.IsNullOrWhiteSpace(txtIdentification.Text)  || !ValidateIdentification(txtIdentification.Text))
            {
                isValidForm = false;
                candidateErrorProvider.SetError(txtIdentification, "El valor ingresado en la cedula es incorrecto");
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
            if (CurrentCandidate != null)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }

            var form = _container.Resolve<LanguageForm>();

            form.IsSelectionMode = true;

            if (form.ShowDialog() == DialogResult.OK)
            {
                _languages.AddRange( form.Languages.Where(language => _languages.All(lang => lang.Id != language.Id)).ToList());
                languageBindingSource.DataSource = _languages;
                languageBindingSource.ResetBindings(true);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            _languages.Remove(languageBindingSource.Current as Language);
            languageBindingSource.DataSource = _languages;
            languageBindingSource.ResetBindings(true);
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            var form = _container.Resolve<TrainingsForm>();

            form.IsSelectionMode = true;

            if (form.ShowDialog() == DialogResult.OK)
            {
                _trainings.AddRange(form.Trainings.Where(training => _trainings.All(t => t.Id != training.Id)).ToList());
                trainingBindingSource.DataSource = _trainings;
                trainingBindingSource.ResetBindings(true);
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            _trainings.Remove(trainingBindingSource.Current as Training);
            trainingBindingSource.DataSource = _trainings;
            trainingBindingSource.ResetBindings(true);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            var form = _container.Resolve<WorkExperienceForm>();

            form.IsSelectionMode = true;

            if (form.ShowDialog() == DialogResult.OK)
            {
                _workExperiences.AddRange(form.WorkExperiences.Where(expe => _workExperiences.All(t => t.Id != expe.Id)).ToList());
                workExperienceBindingSource.DataSource = _workExperiences;
                workExperienceBindingSource.ResetBindings(true);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            _workExperiences.Remove(workExperienceBindingSource.Current as WorkExperience);
            workExperienceBindingSource.DataSource = _workExperiences;
            workExperienceBindingSource.ResetBindings(true);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            var form = _container.Resolve<CompetitionsForm>();

            form.IsSelectionMode = true;

            if (form.ShowDialog() == DialogResult.OK)
            {
                _competitions.AddRange(form.Competitions.Where(expe => _competitions.All(t => t.Id != expe.Id)).ToList());
                competitionBindingSource.DataSource = _competitions;
                competitionBindingSource.ResetBindings(true);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (CurrentCandidate != null)
            {
                return;
            }
            _competitions.Remove(competitionBindingSource.Current as Competition);
            competitionBindingSource.DataSource = _competitions;
            competitionBindingSource.ResetBindings(true);
        }

        public bool ValidateIdentification(string identification)
        {
            int total = 0;
            string rawIdentification = identification.Replace("-", "");
            int identificationLength = rawIdentification.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (identificationLength < 11 || identificationLength > 11)
            {
                return false;
            }

            for (int checkDigit = 1; checkDigit <= identificationLength; checkDigit++)
            {
                int sumOfDigits = Int32.Parse(rawIdentification.Substring(checkDigit - 1, 1)) * digitoMult[checkDigit - 1];
                if (sumOfDigits < 10)
                    total += sumOfDigits;
                else
                    total += Int32.Parse(sumOfDigits.ToString().Substring(0, 1)) + Int32.Parse(sumOfDigits.ToString().Substring(1, 1));
            }

            if (total % 10 != 0)
            {
                return false;
            }

            return true;
        }

    }
}
