using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;
using RRHHRecruitment.Core.Services;
using System;
using System.Windows.Forms;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateJobsForm : MetroForm
    {
        private double minSalary = 0;
        private double maxSalary = 0;

        private readonly JobsService _jobsService;

        public CreateJobsForm(JobsService jobsService)
        {
            InitializeComponent();
            cbRiskLevel.DataSource = new BindingSource( Program.TranslateRiskLevel,null);
            cbRiskLevel.DisplayMember = "Value";
            cbRiskLevel.ValueMember = "Key";

            _jobsService = jobsService;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Job job = BuildJobRequest();
                
                IOperationResult<Job> basicOperationResult = _jobsService.CreateJob(job);

                if (!basicOperationResult.Success)
                {
                    MetroMessageBox.Show(this, basicOperationResult.Message, "Creacion de puesto de trabajo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                MetroMessageBox.Show(this, "puesto de trabajo creado correctamente!", "Creacion de puesto de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
     
        }

        private Job BuildJobRequest()
        {
            return new Job()
            {
                Name = nameTxt.Text,
                MinSalary = minSalary,
                RiskLevel = (RiskLevel) cbRiskLevel.SelectedValue,
                MaxSalary = maxSalary,
                IsActive =  true
            };
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (((TextBox) sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox2_Leave(object sender, EventArgs e)
        {
            double value;
            MetroTextBox textBox = sender as MetroTextBox;
            if (double.TryParse(textBox.Text.Replace("$",""), out value))
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
                minSalary = value;
            }
            else
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", minSalary);
            }
        }

        private void metroTextBox3_Leave(object sender, EventArgs e)
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

        private bool IsValidForm()
        {
           jobsErrorProvider.Clear();
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                isValidForm = false;
                jobsErrorProvider.SetError(nameTxt, "Por favor increse un nombre para el trabajo");
            }

            if (string.IsNullOrWhiteSpace(txtMaxSalary.Text))
            {
                isValidForm = false;
                jobsErrorProvider.SetError(txtMaxSalary, "Por favor ingrese un salario maximo, el cual tiene que ser mayor al salario minimo");
            }

            if (string.IsNullOrWhiteSpace(txtMinSalary.Text))
            {
                isValidForm = false;
                jobsErrorProvider.SetError(txtMinSalary, "Por favor increse salario minimo, el cual tiene que ser menor al salario maximo");
            }

            if (minSalary > maxSalary)
            {
                isValidForm = false;
                jobsErrorProvider.SetError(txtMaxSalary, "Por favor ingrese un salario maximo, el cual tiene que ser mayor al salario minimo");
            }

            return isValidForm;
        }
    }
}
