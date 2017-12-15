namespace StrategicEworx.VerifyNG.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        Email = c.String(),
                        ConfirmEmail = c.String(),
                        TelephoneNumber = c.String(nullable: false, maxLength: 15),
                        DateOfBirth = c.DateTime(nullable: false),
                        ConfirmDateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        Nationality = c.String(nullable: false),
                        LGA = c.String(nullable: false),
                        MMaidenName = c.String(nullable: false),
                        MaritalStatus = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        bankVerificationNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
