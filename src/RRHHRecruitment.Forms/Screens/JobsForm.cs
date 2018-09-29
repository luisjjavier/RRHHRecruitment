using System.Windows.Forms;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Models.Enums;
using RRHHRecruitment.Core.Services;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class JobsForm : MetroForm
    {
        private readonly IUnityContainer _container;
        private readonly JobsService _jobsService;

        public JobsForm(IUnityContainer container, JobsService jobsService)
        {
            InitializeComponent();
            _container = container;
            _jobsService = jobsService;

            jobBindingSource.DataSource = _jobsService.GetJobs();
        }

        private void metroButton2_Click(object sender, System.EventArgs e)
        {

        }

        private void metroGrid1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex].Name == "riskLevelDataGridViewTextBoxColumn")
            {
                RiskLevel enumValue = (RiskLevel)e.Value;
                string enumstring = Program.TranslateRiskLevel[enumValue];
                e.Value = enumstring;
            }
        }

        private void metroButton2_Click_1(object sender, System.EventArgs e)
        {
            Form form =  _container.Resolve(typeof(CreateJobsForm)) as Form;

            if (form.ShowDialog()  == DialogResult.OK)
            {
                jobBindingSource.DataSource = _jobsService.GetJobs();
            }
        }
    }
}
