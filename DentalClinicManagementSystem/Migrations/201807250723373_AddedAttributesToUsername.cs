namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToUsername : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Administrators", "Username", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Administrators", "Username", c => c.String(maxLength: 32));
        }
    }
}
