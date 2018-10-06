using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    public sealed class TrainingRepository : BaseRepository<Training>, ITrainingRepository
    {
        public TrainingRepository(RecruitmentContext recruitmentContext)
            :base(recruitmentContext)
        {
            
        }
    }
}
