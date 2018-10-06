namespace RRHHRecruitment.Persistence.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identification = c.String(nullable: false, maxLength: 500, unicode: false),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        JobId = c.Int(nullable: false),
                        Department = c.String(maxLength: 500, unicode: false),
                        SalaryToWhichHeAspires = c.Double(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.JobId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        Password = c.String(nullable: false, maxLength: 500, unicode: false),
                        Username = c.String(nullable: false, maxLength: 500, unicode: false),
                        RoleType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500, unicode: false),
                        RiskLevel = c.Int(nullable: false),
                        MinSalary = c.Double(nullable: false),
                        MaxSalary = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identification = c.String(nullable: false, maxLength: 500, unicode: false),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        EntryDate = c.DateTime(nullable: false),
                        Department = c.String(maxLength: 500, unicode: false),
                        JobId = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.JobId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcademicLevel = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Institution = c.String(maxLength: 500, unicode: false),
                        UserId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Description = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WorkExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(maxLength: 500, unicode: false),
                        Job = c.String(maxLength: 500, unicode: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                        UserId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.Name, unique: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CompetitionCandidates",
                c => new
                    {
                        Competition_Id = c.Int(nullable: false),
                        Candidate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Competition_Id, t.Candidate_Id })
                .ForeignKey("dbo.Competitions", t => t.Competition_Id, cascadeDelete: false)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: false)
                .Index(t => t.Competition_Id)
                .Index(t => t.Candidate_Id);
            
            CreateTable(
                "dbo.TrainingCandidates",
                c => new
                    {
                        Training_Id = c.Int(nullable: false),
                        Candidate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Training_Id, t.Candidate_Id })
                .ForeignKey("dbo.Trainings", t => t.Training_Id, cascadeDelete: false)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: false)
                .Index(t => t.Training_Id)
                .Index(t => t.Candidate_Id);
            
            CreateTable(
                "dbo.WorkExperienceCandidates",
                c => new
                    {
                        WorkExperience_Id = c.Int(nullable: false),
                        Candidate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.WorkExperience_Id, t.Candidate_Id })
                .ForeignKey("dbo.WorkExperiences", t => t.WorkExperience_Id, cascadeDelete: false)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: false)
                .Index(t => t.WorkExperience_Id)
                .Index(t => t.Candidate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Languages", "UserId", "dbo.Users");
            DropForeignKey("dbo.WorkExperiences", "UserId", "dbo.Users");
            DropForeignKey("dbo.WorkExperienceCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.WorkExperienceCandidates", "WorkExperience_Id", "dbo.WorkExperiences");
            DropForeignKey("dbo.Candidates", "UserId", "dbo.Users");
            DropForeignKey("dbo.Trainings", "UserId", "dbo.Users");
            DropForeignKey("dbo.TrainingCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.TrainingCandidates", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.Competitions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Jobs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Candidates", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.CompetitionCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.CompetitionCandidates", "Competition_Id", "dbo.Competitions");
            DropIndex("dbo.WorkExperienceCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.WorkExperienceCandidates", new[] { "WorkExperience_Id" });
            DropIndex("dbo.TrainingCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.TrainingCandidates", new[] { "Training_Id" });
            DropIndex("dbo.CompetitionCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.CompetitionCandidates", new[] { "Competition_Id" });
            DropIndex("dbo.Languages", new[] { "UserId" });
            DropIndex("dbo.Languages", new[] { "Name" });
            DropIndex("dbo.WorkExperiences", new[] { "UserId" });
            DropIndex("dbo.Trainings", new[] { "UserId" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropIndex("dbo.Employees", new[] { "JobId" });
            DropIndex("dbo.Jobs", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Competitions", new[] { "UserId" });
            DropIndex("dbo.Candidates", new[] { "UserId" });
            DropIndex("dbo.Candidates", new[] { "JobId" });
            DropTable("dbo.WorkExperienceCandidates");
            DropTable("dbo.TrainingCandidates");
            DropTable("dbo.CompetitionCandidates");
            DropTable("dbo.Languages");
            DropTable("dbo.WorkExperiences");
            DropTable("dbo.Trainings");
            DropTable("dbo.Employees");
            DropTable("dbo.Jobs");
            DropTable("dbo.Users");
            DropTable("dbo.Competitions");
            DropTable("dbo.Candidates");
        }
    }
}
