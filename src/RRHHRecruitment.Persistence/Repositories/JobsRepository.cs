using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Persistence.Repositories
{
    public sealed class JobsRepository : BaseRepository<Job>, IJobsRepository
    {
        private readonly RecruitmentContext _recruitmentContext;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recruitmentContext"></param>
        public JobsRepository(RecruitmentContext recruitmentContext) :
            base(recruitmentContext)
        {
            _recruitmentContext = recruitmentContext;
        }

        IEnumerable<Job> IJobsRepository.GetWithoutActive()
        {
            return _recruitmentContext.Jobs.AsNoTracking().Where(job => job.IsActive);
        }
    }
}
