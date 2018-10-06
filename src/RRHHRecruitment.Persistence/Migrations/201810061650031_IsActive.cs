namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "RecommendedBy", c => c.String(maxLength: 500, unicode: false));
            AddColumn("dbo.Candidates", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidates", "IsActive");
            DropColumn("dbo.Candidates", "RecommendedBy");
        }
    }
}
