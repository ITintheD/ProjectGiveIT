namespace GiveIT.UI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        ContactFirstName = c.String(),
                        ContactLastName = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNoExtension = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Charity",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        CharityId = c.Int(nullable: false, identity: true),
                        CharityName = c.String(),
                        MissionAndLocation = c.String(),
                        EIN = c.String(),
                        StreetAddress = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserProfile", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Charity", new[] { "UserId" });
            DropForeignKey("dbo.Charity", "UserId", "dbo.UserProfile");
            DropTable("dbo.Charity");
            DropTable("dbo.UserProfile");
        }
    }
}
