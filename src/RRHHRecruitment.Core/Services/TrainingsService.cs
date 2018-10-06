using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Core.Services
{
    public sealed class TrainingsService
   {
       private readonly ITrainingRepository _trainingRepository;

        public TrainingsService(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
        }

        public  IEnumerable<Training> GetTrainings(int userId)
        {
            return _trainingRepository.FindAll(training => training.IsActive && training.UserId == userId).ToList();
        }

        public IOperationResult<Training> DeleteTraining(Training training)
        {
            training.IsActive = false;
            return _trainingRepository.Update(training);
        }

       public IOperationResult<Training> CreateTraining(Training training)
       {
           return _trainingRepository.Create(training);
       }

       public IOperationResult<Training> UpdateTraining(Training training)
       {
           return _trainingRepository.Update(training);
        }
   }
}
