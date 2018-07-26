namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToUserClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Users", "SecurityQuestion1", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "SecurityQuestion2", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "SecurityQuestion3", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Answer1", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Answer2", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Answer3", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Username" });
            AlterColumn("dbo.Users", "Answer3", c => c.String());
            AlterColumn("dbo.Users", "Answer2", c => c.String());
            AlterColumn("dbo.Users", "Answer1", c => c.String());
            AlterColumn("dbo.Users", "SecurityQuestion3", c => c.String());
            AlterColumn("dbo.Users", "SecurityQuestion2", c => c.String());
            AlterColumn("dbo.Users", "SecurityQuestion1", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
        }
    }
}
