namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Activity_Title = c.String(nullable: false),
                        Activity_Description = c.String(nullable: false),
                        CreatedBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedbackText = c.String(),
                        Time = c.DateTime(nullable: false),
                        FeedbackBy = c.String(maxLength: 128),
                        ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.FeedbackBy)
                .Index(t => t.FeedbackBy)
                .Index(t => t.ActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "FeedbackBy", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Feedbacks", new[] { "ActivityId" });
            DropIndex("dbo.Feedbacks", new[] { "FeedbackBy" });
            DropIndex("dbo.Activities", new[] { "CreatedBy" });
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Activities");
        }
    }
}
