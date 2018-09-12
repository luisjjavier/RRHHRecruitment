using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class LanguageForm : MetroForm
    {
        private readonly IUnityContainer _container;
        private readonly LanguagesService _languagesService;

        public LanguageForm(IUnityContainer container, LanguagesService languagesService)
        {
            InitializeComponent();

            _container = container;
            _languagesService =  languagesService;

            languageBindingSource.DataSource =  languagesService.GetLanguages();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Language language = new Language()
            {
                IsActive = chkIsActive.Checked,
                Name = languageName.Text
            };
            IOperationResult<Language> operationResult =  _languagesService.CreateLanguage(language);

            if (operationResult.Success)
            {
                languageBindingSource.DataSource = _languagesService.GetLanguages();
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
    }
}
