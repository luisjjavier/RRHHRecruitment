using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using RRHHRecruitment.Core.Contracts;

namespace RRHHRecruitment.Core.Services
{
    public sealed class JobsService
    {
        private readonly IJobsRepository _jobsRepository;

        public JobsService(IJobsRepository jobsRepository)
        {
            _jobsRepository = jobsRepository;
        }

        public IEnumerable<Job> GetJobs()
            => _jobsRepository.Get().ToList();

        public IOperationResult<Job> CreateJob(Job job)
        {
            return _jobsRepository.Create(job);
        }
    }
}
