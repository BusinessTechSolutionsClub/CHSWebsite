namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingRelationship2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Contents", "NavigationId");
            AddForeignKey("dbo.Contents", "NavigationId", "dbo.Navigations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "NavigationId", "dbo.Navigations");
            DropIndex("dbo.Contents", new[] { "NavigationId" });
        }
    }
}
