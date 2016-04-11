namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleaningDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "NavigationId", "dbo.Navigations");
            DropForeignKey("dbo.Contents", "User_Id", "dbo.Users");
            DropIndex("dbo.Contents", new[] { "NavigationId" });
            DropIndex("dbo.Contents", new[] { "User_Id" });
            DropTable("dbo.Contents");
            DropTable("dbo.Navigations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Navigations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NavigationId = c.Int(nullable: false),
                        NavLinkDescription = c.String(),
                        ContentDetails = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Contents", "User_Id");
            CreateIndex("dbo.Contents", "NavigationId");
            AddForeignKey("dbo.Contents", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Contents", "NavigationId", "dbo.Navigations", "Id", cascadeDelete: true);
        }
    }
}
