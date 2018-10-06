using System.Collections;
using System.Collections.Generic;
using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Models.Enums;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a user entity
    /// </summary>
    public sealed class User : IEntityBase
    {
        /// <summary>
        /// A unique identification
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A person name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A hashed password the user
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// A user name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Represents a user role
        /// </summary>
        public RoleType RoleType { get; set; }

        /// <summary>
        /// Indicates the status of the current user
        /// </summary>
        public bool IsActive { get; set; }

        public ICollection <Job> Jobs { get; set; }
    }
}
