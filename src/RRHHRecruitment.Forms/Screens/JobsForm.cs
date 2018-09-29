using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Models.Enums;
using RRHHRecruitment.Core.Services;
using System.Windows.Forms;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class JobsForm : MetroForm
    {
        private readonly IUnityContainer _container;
        private JobsService _jobsService;

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
            Form form = _container.Resolve(typeof(CreateJobsForm)) as Form;

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "puesto de trabajo creado correctamente!", "Creacion de puesto de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                jobBindingSource.DataSource = _jobsService.GetJobs();
            }
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var job = jobBindingSource.Current as Job;
            CreateJobsForm form = _container.Resolve<CreateJobsForm>();

            form.Job = job;
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "puesto de trabajo editado correctamente!", "Creacion de puesto de trabajo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                jobBindingSource.DataSource = _jobsService.GetJobs();
            }
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            var job = jobBindingSource.Current as Job;
            if (MetroMessageBox.Show(this, $"Desea borrar este puesto {job.Name}?", "Borrar puesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IOperationResult<Job> basicOperationResult = _jobsService.DeleteJob(job);
                if (basicOperationResult.Success)
                {
                    jobBindingSource.DataSource = _jobsService.GetJobs();
                }
            }
        }
    }
}
