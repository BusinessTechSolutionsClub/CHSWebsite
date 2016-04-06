namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "Navigation_Id", "dbo.Navigations");
            DropIndex("dbo.Contents", new[] { "Navigation_Id" });
            AddColumn("dbo.Contents", "NavigationLinksId", c => c.Int(nullable: false));
            DropColumn("dbo.Contents", "NavigationLinkId");
            DropColumn("dbo.Contents", "Navigation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "Navigation_Id", c => c.Int());
            AddColumn("dbo.Contents", "NavigationLinkId", c => c.Int(nullable: false));
            DropColumn("dbo.Contents", "NavigationLinksId");
            CreateIndex("dbo.Contents", "Navigation_Id");
            AddForeignKey("dbo.Contents", "Navigation_Id", "dbo.Navigations", "Id");
        }
    }
}
