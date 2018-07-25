namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddededMoreAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Administrators", "SecurityQuestion1", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "SecurityQuestion2", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "SecurityQuestion3", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "SecurityQuestion1", c => c.String());
            AlterColumn("dbo.Users", "SecurityQuestion2", c => c.String());
            AlterColumn("dbo.Users", "SecurityQuestion3", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "SecurityQuestion3", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "SecurityQuestion2", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "SecurityQuestion1", c => c.Int(nullable: false));
            AlterColumn("dbo.Administrators", "SecurityQuestion3", c => c.Int(nullable: false));
            AlterColumn("dbo.Administrators", "SecurityQuestion2", c => c.Int(nullable: false));
            AlterColumn("dbo.Administrators", "SecurityQuestion1", c => c.Int(nullable: false));
        }
    }
}
