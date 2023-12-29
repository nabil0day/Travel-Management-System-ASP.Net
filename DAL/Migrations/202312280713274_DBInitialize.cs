namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInitialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Booking_Title = c.String(nullable: false),
                        Booking_Descripion = c.String(nullable: false),
                        BookedBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.BookedBy)
                .Index(t => t.BookedBy);
            
            CreateTable(
                "dbo.Suggestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuggestedText = c.String(),
                        Time = c.DateTime(nullable: false),
                        SuggestedBy = c.String(maxLength: 128),
                        BookedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookedId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.SuggestedBy)
                .Index(t => t.SuggestedBy)
                .Index(t => t.BookedId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Uname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "BookedBy", "dbo.Users");
            DropForeignKey("dbo.Suggestions", "SuggestedBy", "dbo.Users");
            DropForeignKey("dbo.Suggestions", "BookedId", "dbo.Bookings");
            DropIndex("dbo.Suggestions", new[] { "BookedId" });
            DropIndex("dbo.Suggestions", new[] { "SuggestedBy" });
            DropIndex("dbo.Bookings", new[] { "BookedBy" });
            DropTable("dbo.Users");
            DropTable("dbo.Suggestions");
            DropTable("dbo.Bookings");
        }
    }
}
