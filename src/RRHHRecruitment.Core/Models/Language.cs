using RRHHRecruitment.Core.Contracts;

namespace RRHHRecruitment.Core.Models
{
    /// <summary>
    /// Represents a language entity
    /// </summary>
    public sealed class Language : IEntityBase
    {
        /// <summary>
        /// An identification
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A name for a language
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates if this language is active
        /// </summary>
        public bool IsActive { get; set; }
    }
}