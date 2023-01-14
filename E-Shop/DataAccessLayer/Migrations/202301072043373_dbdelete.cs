namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbdelete : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "RePassword", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "RePassword", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
        }
    }
}
