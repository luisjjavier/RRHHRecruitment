using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Core.Services;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CandidatesForm : MetroForm
    {
        private readonly CandidatesService _candidatesService;
        private readonly IUnityContainer _container;

        public CandidatesForm(CandidatesService candidatesService, IUnityContainer container)
        {
            InitializeComponent();
            _candidatesService = candidatesService;
            _container = container;

            candidateBindingSource.DataSource = _candidatesService.GetCandidates();
        }

        private void metroGrid1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        
        }

        private void metroGrid1_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Candidate candidate = candidateBindingSource.Current as Candidate;
            CreateCandidateForm form = _container.Resolve<CreateCandidateForm>();

            form.CurrentCandidate = candidate;

            form.ShowDialog();
        }

        private void btnConvert_Click(object sender, System.EventArgs e)
        {
            CreateEmployeeForm form = _container.Resolve<CreateEmployeeForm>();
            Candidate candidate = candidateBindingSource.Current as Candidate;

            form.CurrentEmployee = new Employee()
            {
                Department = candidate.Department,
                JobId = candidate.JobId,
                Identification = candidate.Identification,
                Name = candidate.Name,
                IsActive = true,
                UserId = Program.CurrentUser.Id
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "El empleado se ha creado correctamente!", "Creacion de empleados",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                IOperationResult<Candidate> basicOperationResult = _candidatesService.DeleteCandidate(candidate);
                if (basicOperationResult.Success)
                {
                    candidateBindingSource.DataSource = _candidatesService.GetCandidates();
                }
            }
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            var candidate = candidateBindingSource.Current as Candidate;
            if (MetroMessageBox.Show(this, $"Desea borrar al candidato {candidate.Name}?", "Borrar candidatos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IOperationResult<Candidate> basicOperationResult = _candidatesService.DeleteCandidate(candidate);
                if (basicOperationResult.Success)
                {
                    candidateBindingSource.DataSource = _candidatesService.GetCandidates();
                }
            }
        }
    }
}
