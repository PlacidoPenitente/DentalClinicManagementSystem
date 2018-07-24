namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedIListToListInBranches : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        Religion = c.String(),
                        Address = c.String(),
                        TelephoneNo = c.String(),
                        MobileNo = c.String(),
                        Nickname = c.String(),
                        Username = c.String(),
                        SecurityQuestion1 = c.Int(nullable: false),
                        SecurityQuestion2 = c.Int(nullable: false),
                        SecurityQuestion3 = c.Int(nullable: false),
                        Answer1 = c.String(),
                        Answer2 = c.String(),
                        Answer3 = c.String(),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Branch_Id)
                .Index(t => t.Branch_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Managers", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Managers", new[] { "Branch_Id" });
            DropTable("dbo.Managers");
        }
    }
}
