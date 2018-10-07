using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using Unity;
using System.Linq;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class LanguageForm : MetroForm
    {
        private readonly IUnityContainer _container;
        private readonly LanguagesService _languagesService;
        private  Language selectedLanguage;
        public ICollection<Language> Languages { get; set; } = new List<Language>();

        public bool IsSelectionMode { get; internal set; } = false;

        public LanguageForm(IUnityContainer container, LanguagesService languagesService)
        {
            InitializeComponent();

            _container = container;
            _languagesService =  languagesService;

            languageBindingSource.DataSource =  _languagesService.GetLanguages(Program.CurrentUser.Id);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Language language = new Language()
            {
                IsActive = chkIsActive.Checked,
                Name = languageName.Text,
                UserId =  Program.CurrentUser.Id
            };
            IOperationResult<Language> operationResult =  _languagesService.CreateLanguage(language);

            if (operationResult.Success)
            {
                languageBindingSource.DataSource = _languagesService.GetLanguages(Program.CurrentUser.Id);
            }
            else
            {
                MetroMessageBox.Show(this, "Gestión de idiomas", operationResult.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void languageGrid_SelectionChanged(object sender, System.EventArgs e)
        {

        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            languageName.Text = "";
            chkIsActive.Checked = false;
        }

        private void languageGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var languange = languageBindingSource.Current as Language;
            languageName.Text = languange.Name;
            chkIsActive.Checked = languange.IsActive;
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            selectedLanguage = null;
            languageName.Text = "";
            chkIsActive.Checked = false;

        }

        private void LanguageForm_Load(object sender, System.EventArgs e)
        {
            if (IsSelectionMode)
            {
                languageGrid.MultiSelect = true;
                languageGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                metroButton1.Hide();
                btnClear.Hide();
                btnSave.Hide();
                metroButton2.Show();
            }
        }

        private void metroButton2_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < languageGrid.SelectedRows.Count; i++)
            {
                Languages.Add((Language)languageGrid.SelectedRows[i].DataBoundItem);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
