namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Job_Id", "dbo.Jobs");
            DropIndex("dbo.Employees", new[] { "Job_Id" });
            RenameColumn(table: "dbo.Employees", name: "Job_Id", newName: "JobId");
            AlterColumn("dbo.Employees", "JobId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "JobId");
            AddForeignKey("dbo.Employees", "JobId", "dbo.Jobs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "JobId", "dbo.Jobs");
            DropIndex("dbo.Employees", new[] { "JobId" });
            AlterColumn("dbo.Employees", "JobId", c => c.Int());
            RenameColumn(table: "dbo.Employees", name: "JobId", newName: "Job_Id");
            CreateIndex("dbo.Employees", "Job_Id");
            AddForeignKey("dbo.Employees", "Job_Id", "dbo.Jobs", "Id");
        }
    }
}
