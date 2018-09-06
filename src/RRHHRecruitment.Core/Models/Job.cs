using System.Collections.Generic;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models.Enums;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a job entity
    /// </summary>
    public sealed class Job : IEntityBase
    {
        /// <summary>
        /// Represents an identification 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents a name for a job
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A <see cref="RiskLevel"/>
        /// </summary>
        public RiskLevel RiskLevel { get; set; }

        /// <summary>
        /// A minimum salary for the job
        /// </summary>
        public double MinSalary { get; set; }

        /// <summary>
        /// A max salary for the job
        /// </summary>
        public double MaxSalary { get; set; }

        /// <summary>
        /// Indicates if is active
        /// </summary>
        public bool IsActive { get; set; }

        public ISet<Candidate> Candidates { get; set; }

        public ISet<Employee> Employees { get; set; }
    }
}
