using RRHHRecruitment.Core.Contracts;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a competition entity
    /// </summary>
    public sealed class Competition : IEntityBase
    {
        /// <summary>
        /// An identification
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A brief description of what this competition means
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates if this competition is active
        /// </summary>
        public bool IsActive { get; set; }
    }
}
