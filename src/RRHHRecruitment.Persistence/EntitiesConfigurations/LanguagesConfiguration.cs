using System.Data.Entity.ModelConfiguration;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.EntitiesConfigurations
{
    internal  sealed class LanguagesConfiguration: EntityTypeConfiguration<Language>
    {
        public LanguagesConfiguration()
        {
            Property(language => language.Name).IsRequired();
        }
    }
}
