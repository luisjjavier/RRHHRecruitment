namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Trainings", "CandidateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainings", "CandidateId", c => c.Int(nullable: false));
            DropColumn("dbo.Trainings", "IsActive");
        }
    }
}
