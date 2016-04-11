namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NavigationLinkIdreplaced : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contents", "NavigationLinkId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "NavigationLinkId", c => c.Int(nullable: false));
        }
    }
}
