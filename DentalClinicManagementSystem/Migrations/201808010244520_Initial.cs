namespace DentalClinicManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Dentists");
            DropIndex("dbo.Administrators", new[] { "Username" });
            DropIndex("dbo.Branches", new[] { "Name" });
            DropIndex("dbo.Dentists", new[] { "Username" });
            CreateTable(
                "dbo.SecurityQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false, maxLength: 255),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Question, unique: true);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Answer1 = c.String(nullable: false),
                        Answer2 = c.String(nullable: false),
                        Answer3 = c.String(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        MiddleName = c.String(maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Gender = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Nationality = c.String(maxLength: 255),
                        Religion = c.String(maxLength: 255),
                        Address = c.String(nullable: false, maxLength: 255),
                        TelephoneNo = c.String(),
                        MobileNo = c.String(nullable: false, maxLength: 11),
                        Nickname = c.String(maxLength: 255),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Branch_Id = c.Int(),
                        SecurityQuestion1_Id = c.Int(),
                        SecurityQuestion2_Id = c.Int(),
                        SecurityQuestion3_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SecurityQuestions", t => t.SecurityQuestion1_Id)
                .ForeignKey("dbo.SecurityQuestions", t => t.SecurityQuestion2_Id)
                .ForeignKey("dbo.SecurityQuestions", t => t.SecurityQuestion3_Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Branch_Id)
                .Index(t => t.SecurityQuestion1_Id)
                .Index(t => t.SecurityQuestion2_Id)
                .Index(t => t.SecurityQuestion3_Id);
            
            AddColumn("dbo.Dentists", "SecurityQuestion1_Id", c => c.Int());
            AddColumn("dbo.Dentists", "SecurityQuestion2_Id", c => c.Int());
            AddColumn("dbo.Dentists", "SecurityQuestion3_Id", c => c.Int());
            AlterColumn("dbo.Branches", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Branches", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Dentists", "Username", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Dentists", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Dentists", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Dentists", "MiddleName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Dentists", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Dentists", "Nationality", c => c.String(maxLength: 255));
            AlterColumn("dbo.Dentists", "Religion", c => c.String(maxLength: 255));
            AlterColumn("dbo.Dentists", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Dentists", "Nickname", c => c.String(maxLength: 255));
            AlterColumn("dbo.Dentists", "CommissionRate", c => c.Int(nullable: false));
            AlterColumn("dbo.Dentists", "Specialization", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Branches", "Name", unique: true);
            CreateIndex("dbo.Dentists", "Username", unique: true);
            CreateIndex("dbo.Dentists", "SecurityQuestion1_Id");
            CreateIndex("dbo.Dentists", "SecurityQuestion2_Id");
            CreateIndex("dbo.Dentists", "SecurityQuestion3_Id");
            AddForeignKey("dbo.Dentists", "SecurityQuestion1_Id", "dbo.SecurityQuestions", "Id");
            AddForeignKey("dbo.Dentists", "SecurityQuestion2_Id", "dbo.SecurityQuestions", "Id");
            AddForeignKey("dbo.Dentists", "SecurityQuestion3_Id", "dbo.SecurityQuestions", "Id");
            DropColumn("dbo.Dentists", "SecurityQuestion1");
            DropColumn("dbo.Dentists", "SecurityQuestion2");
            DropColumn("dbo.Dentists", "SecurityQuestion3");
            DropColumn("dbo.Dentists", "Position");
            DropColumn("dbo.Dentists", "Discriminator");
            DropTable("dbo.Administrators");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 32),
                        Password = c.String(nullable: false, maxLength: 32),
                        SecurityQuestion1 = c.String(nullable: false),
                        SecurityQuestion2 = c.String(nullable: false),
                        SecurityQuestion3 = c.String(nullable: false),
                        Answer1 = c.String(nullable: false),
                        Answer2 = c.String(nullable: false),
                        Answer3 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Dentists", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Dentists", "Position", c => c.Int());
            AddColumn("dbo.Dentists", "SecurityQuestion3", c => c.String(nullable: false));
            AddColumn("dbo.Dentists", "SecurityQuestion2", c => c.String(nullable: false));
            AddColumn("dbo.Dentists", "SecurityQuestion1", c => c.String(nullable: false));
            DropForeignKey("dbo.Staffs", "SecurityQuestion3_Id", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Staffs", "SecurityQuestion2_Id", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Staffs", "SecurityQuestion1_Id", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Dentists", "SecurityQuestion3_Id", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Dentists", "SecurityQuestion2_Id", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Dentists", "SecurityQuestion1_Id", "dbo.SecurityQuestions");
            DropIndex("dbo.Staffs", new[] { "SecurityQuestion3_Id" });
            DropIndex("dbo.Staffs", new[] { "SecurityQuestion2_Id" });
            DropIndex("dbo.Staffs", new[] { "SecurityQuestion1_Id" });
            DropIndex("dbo.Staffs", new[] { "Branch_Id" });
            DropIndex("dbo.Staffs", new[] { "Username" });
            DropIndex("dbo.SecurityQuestions", new[] { "Question" });
            DropIndex("dbo.Dentists", new[] { "SecurityQuestion3_Id" });
            DropIndex("dbo.Dentists", new[] { "SecurityQuestion2_Id" });
            DropIndex("dbo.Dentists", new[] { "SecurityQuestion1_Id" });
            DropIndex("dbo.Dentists", new[] { "Username" });
            DropIndex("dbo.Branches", new[] { "Name" });
            AlterColumn("dbo.Dentists", "Specialization", c => c.String());
            AlterColumn("dbo.Dentists", "CommissionRate", c => c.Single());
            AlterColumn("dbo.Dentists", "Nickname", c => c.String());
            AlterColumn("dbo.Dentists", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Dentists", "Religion", c => c.String());
            AlterColumn("dbo.Dentists", "Nationality", c => c.String());
            AlterColumn("dbo.Dentists", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Dentists", "MiddleName", c => c.String());
            AlterColumn("dbo.Dentists", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Dentists", "Password", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Dentists", "Username", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Branches", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Branches", "Name", c => c.String(nullable: false, maxLength: 32));
            DropColumn("dbo.Dentists", "SecurityQuestion3_Id");
            DropColumn("dbo.Dentists", "SecurityQuestion2_Id");
            DropColumn("dbo.Dentists", "SecurityQuestion1_Id");
            DropTable("dbo.Staffs");
            DropTable("dbo.SecurityQuestions");
            CreateIndex("dbo.Dentists", "Username", unique: true);
            CreateIndex("dbo.Branches", "Name", unique: true);
            CreateIndex("dbo.Administrators", "Username", unique: true);
            RenameTable(name: "dbo.Dentists", newName: "Users");
        }
    }
}
