using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models.Enums;
using System;
using System.Collections.Generic;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a training  entity
    /// </summary>
    public sealed class Training : IEntityBase
    {
        /// <summary>
        /// An identification for trainings
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents academic level for trainings 
        /// </summary>
        public AcademicLevel AcademicLevel { get; set; }

        /// <summary>
        /// From what time the training was made
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// To what time the training was end
        /// </summary>
        public DateTime ToDate { get; set; }

        /// <summary>
        /// An institution that where it was made
        /// </summary>
        public string Institution { get; set; }

        public int CandidateId { get; set; }

        public ISet<Candidate> Candidates { get; set; }
    }
}
