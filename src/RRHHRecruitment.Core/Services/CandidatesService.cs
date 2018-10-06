using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System.Collections.Generic;

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
            return _candidatesRepository.FindAll(candidate => candidate.IsActive);
        }
    }
}
