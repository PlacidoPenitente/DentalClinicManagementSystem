namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreatedModels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Administrators", newName: "Users");
            DropForeignKey("dbo.Branches", "Manager_Id", "dbo.Managers");
            DropIndex("dbo.Branches", new[] { "Manager_Id" });
            DropIndex("dbo.Dentists", new[] { "Branch_Id" });
            DropIndex("dbo.Staffs", new[] { "Branch_Id" });
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "CommissionRate", c => c.Single());
            AddColumn("dbo.Users", "Specialization", c => c.String());
            AddColumn("dbo.Users", "Position", c => c.Int());
            AddColumn("dbo.Users", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Users", "Branch_Id", c => c.Int());
            CreateIndex("dbo.Users", "Branch_Id");
            DropColumn("dbo.Branches", "Manager_Id");
            DropTable("dbo.Managers");
            DropTable("dbo.Dentists");
            DropTable("dbo.Staffs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
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
                        Position = c.Int(nullable: false),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dentists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
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
                        CommissionRate = c.Single(nullable: false),
                        Specialization = c.String(),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Branches", "Manager_Id", c => c.Int());
            DropIndex("dbo.Users", new[] { "Branch_Id" });
            DropColumn("dbo.Users", "Branch_Id");
            DropColumn("dbo.Users", "Discriminator");
            DropColumn("dbo.Users", "Position");
            DropColumn("dbo.Users", "Specialization");
            DropColumn("dbo.Users", "CommissionRate");
            DropColumn("dbo.Users", "Password");
            CreateIndex("dbo.Staffs", "Branch_Id");
            CreateIndex("dbo.Dentists", "Branch_Id");
            CreateIndex("dbo.Branches", "Manager_Id");
            AddForeignKey("dbo.Branches", "Manager_Id", "dbo.Managers", "Id");
            RenameTable(name: "dbo.Users", newName: "Administrators");
        }
    }
}
