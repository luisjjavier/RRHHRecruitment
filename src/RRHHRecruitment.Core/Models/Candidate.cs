using RRHHRecruitment.Core.Contracts;
using System.Collections.Generic;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Candidate: IEntityBase
    {
        public int Id { get; set; }

        public string Identification { get; set; }

        public Job Job { get; set; }

        public string Department { get; set; }

        public double SalaryToWhichHeAspires { get; set; }

        public ISet<Competition> Competitions { get; set; }

        public ISet<Training> Trainings { get; set; }

        public ISet<WorkExperience> WorkExperiences { get; set; }

        public ISet<string> RecommendedBy { get; set; }
    }
}
 