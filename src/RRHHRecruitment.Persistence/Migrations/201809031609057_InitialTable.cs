namespace RRHHRecruitment.Persistence.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Description, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Competitions", new[] { "Description" });
            DropTable("dbo.Competitions");
        }
    }
}
