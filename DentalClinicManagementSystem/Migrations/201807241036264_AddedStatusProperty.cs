namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatusProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrators", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Branches", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Dentists", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Staffs", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Managers", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "Status");
            DropColumn("dbo.Staffs", "Status");
            DropColumn("dbo.Dentists", "Status");
            DropColumn("dbo.Branches", "Status");
            DropColumn("dbo.Administrators", "Status");
        }
    }
}
