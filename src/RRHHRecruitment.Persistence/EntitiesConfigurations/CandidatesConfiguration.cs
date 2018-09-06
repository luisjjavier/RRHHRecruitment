using System.Data.Entity.ModelConfiguration;
using RRHHRecruitment.Core.Models;

namespace RRHHRecruitment.Persistence.EntitiesConfigurations
{
    internal  sealed class CandidatesConfiguration : EntityTypeConfiguration<Candidate>
    {
        public CandidatesConfiguration()
        {
            Property(candidate => candidate.Identification).IsRequired();
            Property(candidate => candidate.Name).IsRequired();
        }
    }
}
