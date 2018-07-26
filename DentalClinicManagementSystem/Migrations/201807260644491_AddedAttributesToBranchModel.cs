namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToBranchModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branches", "Name", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Branches", "Address", c => c.String(nullable: false));
            CreateIndex("dbo.Branches", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Branches", new[] { "Name" });
            AlterColumn("dbo.Branches", "Address", c => c.String());
            AlterColumn("dbo.Branches", "Name", c => c.String());
        }
    }
}
