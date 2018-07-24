namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInitialModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dentists", "Branch_Id", c => c.Int());
            AddColumn("dbo.Staffs", "Branch_Id", c => c.Int());
            CreateIndex("dbo.Dentists", "Branch_Id");
            CreateIndex("dbo.Staffs", "Branch_Id");
            AddForeignKey("dbo.Dentists", "Branch_Id", "dbo.Branches", "Id");
            AddForeignKey("dbo.Staffs", "Branch_Id", "dbo.Branches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.Dentists", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Staffs", new[] { "Branch_Id" });
            DropIndex("dbo.Dentists", new[] { "Branch_Id" });
            DropColumn("dbo.Staffs", "Branch_Id");
            DropColumn("dbo.Dentists", "Branch_Id");
        }
    }
}
