﻿using System.Collections.Generic;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Core.Contracts.Repositories
{
    public interface IJobsRepository : IGenericRepository<Job>
    {
        IEnumerable<Job> GetWithoutActive();
    }
}
