namespace RRHHRecruitment.Core.Models.Enums
{
    /// <summary>
    /// Represents a role type for the system
    /// </summary>
    public enum RoleType
    {
        /// <summary>
        /// Has control of everything
        /// </summary>
        Admin = 1,

        /// <summary>
        /// A limit human resources user
        /// </summary>
        HumanResources = 2,

        /// <summary>
        /// A limit candidate user 
        /// </summary>
        Candidates = 3
    }
}