using RRHHRecruitment.Core.Services;
using System.Windows.Forms;
using MetroFramework.Forms;
using Unity;

namespace RRHHRecruitment.Forms.Screens
{
    public partial class CreateCandidateForm : MetroForm
    {
        private readonly CandidatesService _candidatesService;
        private readonly IUnityContainer _container;

        public CreateCandidateForm(CandidatesService candidatesService, IUnityContainer container)
        {
            InitializeComponent();
            _container = container;
            _candidatesService = candidatesService;
        }

        private void CreateCandidateForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
