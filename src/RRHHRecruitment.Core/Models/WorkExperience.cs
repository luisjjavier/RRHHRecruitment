using RRHHRecruitment.Core.Contracts;
using System;
using System.Collections.Generic;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a work experience
    /// </summary>
    public sealed class WorkExperience: IEntityBase
    {
        /// <summary>
        /// A identification for work experience
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Company name where it was
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// What job
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// From date when it was date
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// To date when it was date
        /// </summary>
        public DateTime ToDate { get; set; }

        /// <summary>
        ///  Represents salary
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Represents a candidate
        /// </summary>
        public ISet<Candidate> Candidate { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public bool IsActive { get; set; }
    }
}
