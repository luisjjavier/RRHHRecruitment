using RRHHRecruitment.Core.Contracts;
using System;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents an employee
    /// </summary>
    public sealed class Employee : IEntityBase
    {
        /// <summary>
        /// An unique identification
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A country identification
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        /// A employee name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A entry date for the employee
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// A department
        /// </summary>
        public string Department { get; set; }

        public int JobId { get; set; }

        /// <summary>
        /// A job 
        /// </summary>
        public Job Job { get; set; }

        /// <summary>
        /// A salary
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Indicates the status of the current employee
        /// </summary>
        public bool IsActive { get; set; }
    }
}
