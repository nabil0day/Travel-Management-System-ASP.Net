namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNewEntityNamedReviewComplain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComplainText = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        ComplainBy = c.String(maxLength: 128),
                        ReviewId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reviews", t => t.ReviewId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ComplainBy)
                .Index(t => t.ComplainBy)
                .Index(t => t.ReviewId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Review_Title = c.String(nullable: false, maxLength: 20),
                        Review_Description = c.String(nullable: false, maxLength: 15),
                        ReviewBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ReviewBy)
                .Index(t => t.ReviewBy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Complains", "ComplainBy", "dbo.Users");
            DropForeignKey("dbo.Complains", "ReviewId", "dbo.Reviews");
            DropForeignKey("dbo.Reviews", "ReviewBy", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "ReviewBy" });
            DropIndex("dbo.Complains", new[] { "ReviewId" });
            DropIndex("dbo.Complains", new[] { "ComplainBy" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Complains");
        }
    }
}
