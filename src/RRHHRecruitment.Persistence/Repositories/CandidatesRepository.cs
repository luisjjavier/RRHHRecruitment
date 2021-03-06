﻿using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RRHHRecruitment.Persistence.Repositories
{
    public class CandidatesRepository : BaseRepository<Candidate> , ICandidatesRepository
    {
        private readonly RecruitmentContext _recruitmentContext;

        public CandidatesRepository(RecruitmentContext recruitmentContext)
            : base(recruitmentContext)
        {
            _recruitmentContext = recruitmentContext;
        }

        IOperationResult<Candidate> ICandidatesRepository.CreateCandidate(Candidate candidate)
        {
            try
            {
                candidate.Competitions =  new HashSet<Competition>(candidate.Competitions.Select(competition => _recruitmentContext.Competitions.Attach(competition)));
                candidate.Languages = new HashSet<Language>(candidate.Languages.Select(competition => _recruitmentContext.Languages.Attach(competition)));
                candidate.Trainings = new HashSet<Training>(candidate.Trainings.Select(competition => _recruitmentContext.Trainings.Attach(competition)));
                candidate.WorkExperiences = new HashSet<WorkExperience>(candidate.WorkExperiences.Select(competition => _recruitmentContext.WorkExperiences.Attach(competition)));

                _recruitmentContext.Candidates.Add(candidate);
                _recruitmentContext.SaveChanges();
                _recruitmentContext.Entry(candidate).State = EntityState.Detached;

                return BasicOperationResult<Candidate>.Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BasicOperationResult<Candidate>.Fail(e.ToString());
            }
        }

        IEnumerable<Training> ICandidatesRepository.GetCandidateTrainings(int id)
        {
            return _recruitmentContext.Trainings.Where(training =>
                training.Candidates.Any(candidate => candidate.Id == id));
        }

        IEnumerable<Competition> ICandidatesRepository.GetCompetitions(int id)
        {
            return _recruitmentContext.Competitions.Where(training =>
                training.Candidates.Any(candidate => candidate.Id == id));
        }

        IEnumerable<Language> ICandidatesRepository.GetLanguages(int id)
        {
            return _recruitmentContext.Languages.Where(training =>
                training.Candidates.Any(candidate => candidate.Id == id));
        }

        IEnumerable<WorkExperience> ICandidatesRepository.GetWorkExperiences(int id)
        {
            return _recruitmentContext.WorkExperiences.Where(training =>
                training.Candidate.Any(candidate => candidate.Id == id));
        }
    }
}
