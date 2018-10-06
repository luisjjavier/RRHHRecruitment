using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using System;
using System.Windows.Forms;
using MetroFramework;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateCompetition : MetroForm
    {
        private readonly CompetitionsService _competitionsService;
        public Competition CurrentCompetition { get; set; }

        public CreateCompetition(CompetitionsService competitionsService)
        {
            InitializeComponent();
            _competitionsService = competitionsService;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                var newCompetititon = new Competition
                {
                    IsActive = true,
                    Description = txtDescription.Text,
                    UserId = Program.CurrentUser.Id
                };

                IOperationResult<Competition> operationResult;
                if (CurrentCompetition == null)
                {
                   operationResult = _competitionsService.CreateCompetition(newCompetititon);
                }
                else
                {
                    CurrentCompetition.Description = txtDescription.Text;
                    operationResult = _competitionsService.UpdateCompetition(CurrentCompetition);
                }

                if (!operationResult.Success)
                {
                    MetroMessageBox.Show(this, operationResult.Message, "Creacion de competencia",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsValidForm()
        {
            CompetionError.Clear();
            bool isValidForm = true;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                isValidForm = false;
                CompetionError.SetError(txtDescription, "Por favor ingrese una descrición para el trabajo");
                txtDescription.WithError = true;
            }

            return isValidForm;
        }

        private void CreateCompetition_Load(object sender, EventArgs e)
        {
            if (CurrentCompetition != null)
            {
                txtDescription.Text = CurrentCompetition.Description;
            }
        }
    }
}
