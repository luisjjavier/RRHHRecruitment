using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    public class CandidatesRepository : BaseRepository<Candidate> , ICandidatesRepository
    {
        public CandidatesRepository(RecruitmentContext recruitmentContext)
            : base(recruitmentContext)
        {
            
        }
    }
}
