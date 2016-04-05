namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetrelationshipbetweennavigationandcontent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Navigations", "Content_Id", "dbo.Contents");
            DropIndex("dbo.Navigations", new[] { "Content_Id" });
            AddColumn("dbo.Contents", "Navigation_Id", c => c.Int());
            CreateIndex("dbo.Contents", "Navigation_Id");
            AddForeignKey("dbo.Contents", "Navigation_Id", "dbo.Navigations", "Id");
            DropColumn("dbo.Navigations", "Content_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Navigations", "Content_Id", c => c.Int());
            DropForeignKey("dbo.Contents", "Navigation_Id", "dbo.Navigations");
            DropIndex("dbo.Contents", new[] { "Navigation_Id" });
            DropColumn("dbo.Contents", "Navigation_Id");
            CreateIndex("dbo.Navigations", "Content_Id");
            AddForeignKey("dbo.Navigations", "Content_Id", "dbo.Contents", "Id");
        }
    }
}
