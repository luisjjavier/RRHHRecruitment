using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class UsersRepository : BaseRepository<User> , IUsersRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recruitmentContext"></param>
        public UsersRepository(RecruitmentContext recruitmentContext):
            base(recruitmentContext)
        {
        }
    }
}
