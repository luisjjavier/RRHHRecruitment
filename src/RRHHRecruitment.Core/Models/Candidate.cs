using RRHHRecruitment.Core.Contracts;
using System.Collections.Generic;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a candidate entity
    /// </summary>
    public sealed class Candidate: IEntityBase
    {
        /// <summary>
        /// An unique identification for users
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        // An identification from local country
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        /// Represents a candidate name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents a job identification
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// A job which the users wants
        /// </summary>
        public Job Job { get; set; }

        /// <summary>
        /// A department 
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// A salary which it's aspires
        /// </summary>
        public double SalaryToWhichHeAspires { get; set; }

        /// <summary>
        /// Competitions that its has 
        /// </summary>
        public ISet<Competition> Competitions { get; set; }

        /// <summary>
        /// Trainings that it has
        /// </summary>
        public ISet<Training> Trainings { get; set; }

        /// <summary>
        /// Work Experience
        /// </summary>
        public ISet<WorkExperience> WorkExperiences { get; set; }

        /// <summary>
        /// Recommended  by
        /// </summary>
        public string RecommendedBy { get; set; }


        public int UserId { get; set; }

        public User User { get; set; }

        public bool IsActive { get; set; }

    }
}
 