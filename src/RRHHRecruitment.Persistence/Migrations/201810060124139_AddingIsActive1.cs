namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIsActive1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "Description", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainings", "Description");
        }
    }
}
