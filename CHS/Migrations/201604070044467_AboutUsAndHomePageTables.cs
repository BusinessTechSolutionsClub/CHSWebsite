namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AboutUsAndHomePageTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContentShortDescription = c.String(),
                        Content = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.HomePages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            AlterColumn("dbo.Users", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Users", "ApplicationUserId");
            AddForeignKey("dbo.Users", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.HomePages", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AboutUs", "User_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "ApplicationUserId" });
            DropIndex("dbo.HomePages", new[] { "User_Id" });
            DropIndex("dbo.AboutUs", new[] { "User_Id" });
            AlterColumn("dbo.Users", "ApplicationUserId", c => c.String());
            DropTable("dbo.HomePages");
            DropTable("dbo.AboutUs");
        }
    }
}
