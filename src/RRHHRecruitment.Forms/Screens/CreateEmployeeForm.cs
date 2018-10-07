using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateEmployeeForm : MetroForm
    {
        private readonly EmployeeServices _employeeServices;
        public Employee CurrentEmployee { get; set; }
        private double minSalary = 0;

        public CreateEmployeeForm(EmployeeServices employeeServices, JobsService jobsService)
        {
            InitializeComponent();
            _employeeServices = employeeServices;
            cbJob.DataSource = new BindingSource(jobsService.GetJobs(), null);
            cbJob.DisplayMember = "Name";
            cbJob.ValueMember = "Id";
        }

        private void txtSalary_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

        private void txtSalary_Leave(object sender, System.EventArgs e)
        {
            double value;
            MetroTextBox textBox = sender as MetroTextBox;
            if (double.TryParse(textBox.Text.Replace("$", ""), out value))
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
                minSalary = value;
            }
            else
            {
                textBox.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", minSalary);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            if (IsValidForm())
            {
                CurrentEmployee.Salary = minSalary;
                CurrentEmployee.EntryDate = entryDate.Value;
                IOperationResult<Employee> basicOperationResult = _employeeServices.CreateEmployee(CurrentEmployee);

                if (!basicOperationResult.Success)
                {
                    MetroMessageBox.Show(this, basicOperationResult.Message, "Creacion de puesto de trabajo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsValidForm()
        {
            jobsErrorProvider.Clear();
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtIdentification.Text))
            {
                isValidForm = false;
                jobsErrorProvider.SetError(txtIdentification, "Por favor increse la identición");
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                isValidForm = false;
                jobsErrorProvider.SetError(txtName, "Por favor ingrese un salario maximo, el cual tiene que ser mayor al salario minimo");
            }

            if (minSalary  < 0)
            {
                isValidForm = false;
                jobsErrorProvider.SetError(txtSalary, "Por favor ingrese un salario maximo, el cual tiene que ser mayor al salario minimo");
            }

            if (entryDate.Value > DateTime.Now)
            {
                isValidForm = false;
                jobsErrorProvider.SetError(entryDate, "La fecha de ingreso es mayor a la permitida.");
            }


            return isValidForm;
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            txtIdentification.Text = CurrentEmployee.Identification;
            txtName.Text = CurrentEmployee.Name;
            txtDeparment.Text = CurrentEmployee.Department;
            cbJob.SelectedValue = CurrentEmployee.JobId;
           
        }
    }
}
