using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    public sealed  class CompetitionRepository : BaseRepository<Competition>, ICompetitionRepository
    {
        public CompetitionRepository(RecruitmentContext recruitmentContext) :
            base(recruitmentContext)
        {
        }
    }
}
