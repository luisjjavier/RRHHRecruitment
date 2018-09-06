namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestOfTables : DbMigration
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identification = c.String(nullable: false, maxLength: 500, unicode: false),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        EntryDate = c.DateTime(nullable: false),
                        Department = c.String(maxLength: 500, unicode: false),
                        Salary = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Job_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.Job_Id)
                .Index(t => t.Job_Id);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcademicLevel = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Institution = c.String(maxLength: 500, unicode: false),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
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
                "dbo.CompetitionCandidates",
                c => new
                    {
                        Competition_Id = c.Int(nullable: false),
                        Candidate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Competition_Id, t.Candidate_Id })
                .ForeignKey("dbo.Competitions", t => t.Competition_Id, cascadeDelete: true)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: true)
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
                .ForeignKey("dbo.Trainings", t => t.Training_Id, cascadeDelete: true)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: true)
                .Index(t => t.Training_Id)
                .Index(t => t.Candidate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkExperiences", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.TrainingCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.TrainingCandidates", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.Employees", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Candidates", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.CompetitionCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.CompetitionCandidates", "Competition_Id", "dbo.Competitions");
            DropIndex("dbo.TrainingCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.TrainingCandidates", new[] { "Training_Id" });
            DropIndex("dbo.CompetitionCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.CompetitionCandidates", new[] { "Competition_Id" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Languages", new[] { "Name" });
            DropIndex("dbo.WorkExperiences", new[] { "CandidateId" });
            DropIndex("dbo.Employees", new[] { "Job_Id" });
            DropIndex("dbo.Candidates", new[] { "JobId" });
            DropTable("dbo.TrainingCandidates");
            DropTable("dbo.CompetitionCandidates");
            DropTable("dbo.Users");
            DropTable("dbo.Languages");
            DropTable("dbo.WorkExperiences");
            DropTable("dbo.Trainings");
            DropTable("dbo.Employees");
            DropTable("dbo.Jobs");
            DropTable("dbo.Candidates");
        }
    }
}
