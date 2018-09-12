using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.Repositories
{
    public sealed class LanguangesRepository : BaseRepository<Language> , ILanguagesRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recruitmentContext"></param>
        public LanguangesRepository(RecruitmentContext recruitmentContext) :
            base(recruitmentContext)
        {
        }
    }
}
