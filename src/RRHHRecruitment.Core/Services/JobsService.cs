using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            => _jobsRepository.GetWithoutActive().ToList();

        public IOperationResult<Job> CreateJob(Job job)
        {
            return _jobsRepository.Create(job);
        }

        public IOperationResult<Job> UpdateJob(Job job)
        {
            return _jobsRepository.Update(job);
        }

        public IOperationResult<Job> DeleteJob(Job job)
        {
            job.IsActive = false;
            return _jobsRepository.Update(job);
        }
    }
}
