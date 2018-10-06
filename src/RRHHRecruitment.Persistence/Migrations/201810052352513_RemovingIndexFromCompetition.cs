namespace RRHHRecruitment.Persistence.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RemovingIndexFromCompetition : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Competitions", new[] { "Description" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Competitions", "Description", unique: true);
        }
    }
}
