namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MultipleBranchesForManager : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Managers", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Managers", new[] { "Branch_Id" });
            AddColumn("dbo.Branches", "Manager_Id", c => c.Int());
            CreateIndex("dbo.Branches", "Manager_Id");
            AddForeignKey("dbo.Branches", "Manager_Id", "dbo.Managers", "Id");
            DropColumn("dbo.Managers", "Branch_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Managers", "Branch_Id", c => c.Int());
            DropForeignKey("dbo.Branches", "Manager_Id", "dbo.Managers");
            DropIndex("dbo.Branches", new[] { "Manager_Id" });
            DropColumn("dbo.Branches", "Manager_Id");
            CreateIndex("dbo.Managers", "Branch_Id");
            AddForeignKey("dbo.Managers", "Branch_Id", "dbo.Branches", "Id");
        }
    }
}
