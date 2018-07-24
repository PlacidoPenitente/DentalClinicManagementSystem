namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dentists",
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
                        CommissionRate = c.Single(nullable: false),
                        Specialization = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staffs",
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
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
            DropTable("dbo.Dentists");
            DropTable("dbo.Branches");
            DropTable("dbo.Administrators");
        }
    }
}
