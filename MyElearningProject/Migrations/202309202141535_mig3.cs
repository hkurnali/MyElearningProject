namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Title1 = c.String(),
                        Title2 = c.String(),
                        Title3 = c.String(),
                        Title4 = c.String(),
                        Title5 = c.String(),
                        Title6 = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        MapURL = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        MessageDetail = c.String(),
                    })
                .PrimaryKey(t => t.MessageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Abouts");
        }
    }
}
