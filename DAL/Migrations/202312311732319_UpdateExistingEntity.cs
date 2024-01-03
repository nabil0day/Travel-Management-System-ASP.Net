namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingEntity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Complains", "ComplainText", c => c.String());
            AlterColumn("dbo.Reviews", "Review_Title", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "Review_Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Review_Description", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Reviews", "Review_Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Complains", "ComplainText", c => c.String(nullable: false));
        }
    }
}
