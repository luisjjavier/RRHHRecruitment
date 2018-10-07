namespace RRHHRecruitment.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingLanguages : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Languages", new[] { "Name" });
            CreateTable(
                "dbo.LanguageCandidates",
                c => new
                    {
                        Language_Id = c.Int(nullable: false),
                        Candidate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Language_Id, t.Candidate_Id })
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: true)
                .Index(t => t.Language_Id)
                .Index(t => t.Candidate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LanguageCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.LanguageCandidates", "Language_Id", "dbo.Languages");
            DropIndex("dbo.LanguageCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.LanguageCandidates", new[] { "Language_Id" });
            DropTable("dbo.LanguageCandidates");
            CreateIndex("dbo.Languages", "Name", unique: true);
        }
    }
}
