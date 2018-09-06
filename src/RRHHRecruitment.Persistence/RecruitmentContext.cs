using RRHHRecruitment.Core.Models;
using RRHHRecruitment.Persistence.EntitiesConfigurations;
using System.Data.Entity;

namespace RRHHRecruitment.Persistence
{
    /// <summary>
    /// Base class that all the application's <see cref="DbContext"/> should inherit from.
    /// </summary>
    public sealed class RecruitmentContext : DbContext
    {

        /// <summary>
        /// Builds a new connection string that
        /// </summary>
        public RecruitmentContext() :
            base("name=RRHHRecruitment")
        {

        }

        internal DbSet<Competition> Competitions { get; set; }

        internal DbSet<Language> Languages { get; set; }

        internal DbSet<Training> Trainings { get; set; }

        internal DbSet<Job> Jobs { get; set; }

        internal DbSet<User> Users { get; set; }

        internal DbSet<Employee> Employees { get; set; }

        internal DbSet<WorkExperience> WorkExperiences { get; set; }

        internal DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<string>().Configure(str => str.HasColumnType("varchar").HasMaxLength(500));

            modelBuilder.Configurations.Add(new CompetitionsConfiguration());
            modelBuilder.Configurations.Add(new UsersConfigurations());
            modelBuilder.Configurations.Add(new EmployeesConfiguration());
            modelBuilder.Configurations.Add(new CandidatesConfiguration());
            modelBuilder.Configurations.Add(new LanguagesConfiguration());
        }
    }
}