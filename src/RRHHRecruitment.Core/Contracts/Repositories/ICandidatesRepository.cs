﻿using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Core.Contracts.Repositories
{
    public interface ICandidatesRepository : IGenericRepository<Candidate>
    {
        IOperationResult<Candidate> CreateCandidate(Candidate candidate);
    }
}