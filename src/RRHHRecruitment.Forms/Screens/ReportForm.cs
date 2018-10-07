using System.Collections.Generic;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class ReportForm : MetroForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public List<Employee> Employees { get; internal set; }

        private void ReportForm_Load(object sender, System.EventArgs e)
        {
            JobBindingSource.DataSource = Employees;

            this.reportViewer1.RefreshReport();
        }
    }
}
