using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Core.Services
{
    public  sealed class WorkExperiencesService
    {
        private readonly IWorkExperienceRepository _experienceRepository;

        public WorkExperiencesService(IWorkExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public IEnumerable<WorkExperience> GetWorkExperience(int id)
        {
            return _experienceRepository.FindAll(experience => experience.UserId == id && experience.IsActive).ToList();
        }

        public IOperationResult<WorkExperience> DeleteExperience(WorkExperience workExperience)
        {
            workExperience.IsActive = false;
            return _experienceRepository.Update(workExperience);
        }

        public IOperationResult<WorkExperience> UpdateWorkExperience(WorkExperience workExperience)
            => _experienceRepository.Update(workExperience);

        public IOperationResult<WorkExperience> CreateWorkExperience(WorkExperience workExperience)
        {
            return _experienceRepository.Create(workExperience);
        }
    }
}
