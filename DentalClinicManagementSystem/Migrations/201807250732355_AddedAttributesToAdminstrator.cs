namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToAdminstrator : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Administrators", "Username", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Administrators", "Password", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Administrators", "Answer1", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "Answer2", c => c.String(nullable: false));
            AlterColumn("dbo.Administrators", "Answer3", c => c.String(nullable: false));
            CreateIndex("dbo.Administrators", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Administrators", new[] { "Username" });
            AlterColumn("dbo.Administrators", "Answer3", c => c.String());
            AlterColumn("dbo.Administrators", "Answer2", c => c.String());
            AlterColumn("dbo.Administrators", "Answer1", c => c.String());
            AlterColumn("dbo.Administrators", "Password", c => c.String());
            AlterColumn("dbo.Administrators", "Username", c => c.String());
        }
    }
}
