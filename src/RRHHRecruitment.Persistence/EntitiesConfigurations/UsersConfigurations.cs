using RRHHRecruitment.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace RRHHRecruitment.Persistence.EntitiesConfigurations
{
    internal sealed class UsersConfigurations : EntityTypeConfiguration<User>
    {
        public UsersConfigurations()
        {
            Property(user => user.Name).IsRequired();
            Property(user => user.Password).IsRequired();
            Property(user => user.Username).IsRequired();
            HasIndex(user => user.Username).IsUnique();
        }
    }
}
