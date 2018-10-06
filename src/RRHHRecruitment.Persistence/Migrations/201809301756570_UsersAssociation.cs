namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersAssociation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Competitions", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Jobs", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Trainings", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.WorkExperiences", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Languages", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Candidates", "UserId");
            CreateIndex("dbo.Competitions", "UserId");
            CreateIndex("dbo.Jobs", "UserId");
            CreateIndex("dbo.Employees", "UserId");
            CreateIndex("dbo.Trainings", "UserId");
            CreateIndex("dbo.WorkExperiences", "UserId");
            CreateIndex("dbo.Languages", "UserId");
            AddForeignKey("dbo.Employees", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Jobs", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Competitions", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Trainings", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Candidates", "UserId", "dbo.Users", "Id", cascadeDelete: false);
            AddForeignKey("dbo.WorkExperiences", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Languages", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Languages", "UserId", "dbo.Users");
            DropForeignKey("dbo.WorkExperiences", "UserId", "dbo.Users");
            DropForeignKey("dbo.Candidates", "UserId", "dbo.Users");
            DropForeignKey("dbo.Trainings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Competitions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Jobs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropIndex("dbo.Languages", new[] { "UserId" });
            DropIndex("dbo.WorkExperiences", new[] { "UserId" });
            DropIndex("dbo.Trainings", new[] { "UserId" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropIndex("dbo.Jobs", new[] { "UserId" });
            DropIndex("dbo.Competitions", new[] { "UserId" });
            DropIndex("dbo.Candidates", new[] { "UserId" });
            DropColumn("dbo.Languages", "UserId");
            DropColumn("dbo.WorkExperiences", "UserId");
            DropColumn("dbo.Trainings", "UserId");
            DropColumn("dbo.Employees", "UserId");
            DropColumn("dbo.Jobs", "UserId");
            DropColumn("dbo.Competitions", "UserId");
            DropColumn("dbo.Candidates", "UserId");
        }
    }
}
