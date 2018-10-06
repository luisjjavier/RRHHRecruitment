using MetroFramework.Forms;
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
    }
}
