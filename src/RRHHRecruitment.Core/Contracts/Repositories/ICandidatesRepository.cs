using System.Collections.Generic;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Core.Contracts.Repositories
{
    public interface ICandidatesRepository : IGenericRepository<Candidate>
    {
        IOperationResult<Candidate> CreateCandidate(Candidate candidate);
        IEnumerable<Training> GetCandidateTrainings(int id);
        IEnumerable<Language> GetLanguages(int id);
        IEnumerable<WorkExperience> GetWorkExperiences(int id);
        IEnumerable<Competition> GetCompetitions(int id);
    }
}