namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "NavigationId", c => c.Int(nullable: false));
            DropColumn("dbo.Contents", "NavigationLinksId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "NavigationLinksId", c => c.Int(nullable: false));
            DropColumn("dbo.Contents", "NavigationId");
        }
    }
}
