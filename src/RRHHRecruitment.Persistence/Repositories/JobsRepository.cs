using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    public sealed class JobsRepository: BaseRepository<Job>, IJobsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recruitmentContext"></param>
        public JobsRepository(RecruitmentContext recruitmentContext) :
            base(recruitmentContext)
        {
        }
    }
}
