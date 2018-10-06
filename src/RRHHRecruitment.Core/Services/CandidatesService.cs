using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Core.Services
{
    public sealed class CandidatesService
   {
       private readonly ICandidatesRepository _candidatesRepository;

        public CandidatesService(ICandidatesRepository candidatesRepository)
        {
            _candidatesRepository = candidatesRepository;
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            return _candidatesRepository.FindAll(candidate => candidate.IsActive).ToList();
        }

        public IOperationResult<Candidate> CreateCandidate(Candidate candidate)
        {
            return _candidatesRepository.Create(candidate);
        }

        public IOperationResult<Candidate> UpdateCandidate(Candidate candidate)
        {
            return _candidatesRepository.Update(candidate);
        }
    }
}
