using MetroFramework.Forms;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using RRHHRecruitment.Core.Contracts;
using System;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateWorkExperience : MetroForm
    {
        private readonly WorkExperiencesService _experiencesService;
        private double _salary = 0;

        public CreateWorkExperience(WorkExperiencesService experiencesService)
        {
            InitializeComponent();
            _experiencesService = experiencesService;
        }

        public WorkExperience CurrentWorkExperience { get; set; }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidForm())
            {
                WorkExperience workExperience = BuildWorkExperienceRequest();
                IOperationResult<WorkExperience> basicOperationResult;

                if (CurrentWorkExperience == null)
                {
                    basicOperationResult = _experiencesService.CreateWorkExperience(workExperience);
                }
                else
                {
                    workExperience.Id = CurrentWorkExperience.Id;
                    basicOperationResult = _experiencesService.UpdateWorkExperience(workExperience);
                }

                if (!basicOperationResult.Success)
                {
                    MetroMessageBox.Show(this, basicOperationResult.Message, "Creacion de experiencia de trabajo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                this.CurrentWorkExperience = null;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private WorkExperience BuildWorkExperienceRequest() 
            => new WorkExperience()
        {
            Job = txtJob.Text,
            Company = txtCompany.Text,
            FromDate = fromDate.Value,
            IsActive = true,
            Salary = _salary,
            ToDate = toDate.Value,
            UserId = Program.CurrentUser.Id
        };

        private bool IsValidForm()
        {
            workExperienceError.Clear();
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtCompany.Text))
            {
                isValidForm = false;
                workExperienceError.SetError(txtCompany, "Por favor increse el nombre de la empresa");
                txtCompany.WithError = true;
            }

            if (string.IsNullOrWhiteSpace(txtJob.Text))
            {
                isValidForm = false;
                txtJob.WithError = true;
                workExperienceError.SetError(txtJob, "Por favor ingrese el puesto ocupado");
            }

            if (_salary <= 0)
            {
                isValidForm = false;
                txtSalary.WithError = true;
                workExperienceError.SetError(txtSalary, "Por favor el salrio tiene que ser mayor a 0");
            }

            if (fromDate.Value > toDate.Value)
            {
                isValidForm = false;
                workExperienceError.SetError(fromDate, "La fecha desde no puede ser mayor de la hasta");
                workExperienceError.SetError(toDate, "La fecha desde no puede ser mayor de la hasta");
            }

            return isValidForm;
        }

        private void txtSalary_Leave(object sender, System.EventArgs e)
        {
            double value;
            MetroTextBox textBox = sender as MetroTextBox;
            if (double.TryParse(textBox.Text.Replace("$", ""), out value))
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
                _salary = value;
            }
            else
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", _salary);
            }
        }

        private void CreateWorkExperience_Load(object sender, EventArgs e)
        {
            if (CurrentWorkExperience != null)
            {
                Text = "Edición de experiencia de trabajo";
                _salary = CurrentWorkExperience.Salary;
                txtJob.Text = CurrentWorkExperience.Job;
                toDate.Value = CurrentWorkExperience.ToDate;
                fromDate.Value = CurrentWorkExperience.FromDate;
                txtCompany.Text = CurrentWorkExperience.Company;
                txtSalary.Text = $"{CurrentWorkExperience.Salary:C2}";
            }
        }
    }
}
