using RRHHRecruitment.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace RRHHRecruitment.Persistence.EntitiesConfigurations
{
    internal class EmployeesConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeesConfiguration()
        {
            Property(employee => employee.Identification).IsRequired();
            Property(employee => employee.Name).IsRequired();
        }
    }
}
