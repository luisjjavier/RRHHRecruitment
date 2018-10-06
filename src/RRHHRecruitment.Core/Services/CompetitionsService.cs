using System;
using System.Collections.Generic;
using System.Linq;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Core.Services
{
    public sealed class CompetitionsService
    {
        private readonly ICompetitionRepository _competitionRepository;

        public CompetitionsService(ICompetitionRepository competitionRepository)
        {
            _competitionRepository = competitionRepository;
        }


        public IEnumerable<Competition> GetCompetition(int userId)
            => _competitionRepository.FindAll(competition => competition.IsActive && competition.UserId == userId).ToList();

        public IOperationResult<Competition> CreateCompetition(Competition competition) 
            => _competitionRepository.Create(competition);

        public IOperationResult<Competition> DeleteCompetition(Competition competition)
        {
            competition.IsActive = false;
            return _competitionRepository.Update(competition);
        }

        public IOperationResult<Competition> UpdateCompetition(Competition newCompetititon) 
            => _competitionRepository.Update(newCompetititon);
    }
}
