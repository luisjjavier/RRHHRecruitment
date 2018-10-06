using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    public sealed class WorkExperienceRepository: BaseRepository<WorkExperience>, IWorkExperienceRepository
    {
        public WorkExperienceRepository(RecruitmentContext recruitmentContext)
            :base(recruitmentContext)
        {
            
        }
    }
}
