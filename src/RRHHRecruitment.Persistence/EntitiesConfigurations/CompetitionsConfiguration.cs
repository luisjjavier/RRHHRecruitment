using RRHHRecruitment.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace RRHHRecruitment.Persistence.EntitiesConfigurations
{
    internal class CompetitionsConfiguration : EntityTypeConfiguration<Competition>
    {
        internal CompetitionsConfiguration()
        {
            Property(competition => competition.Description).IsRequired();
            HasIndex(competition => competition.Description).IsUnique();
        }
    }
}
