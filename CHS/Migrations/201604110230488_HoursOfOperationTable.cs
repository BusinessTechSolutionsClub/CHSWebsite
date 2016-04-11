namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HoursOfOperationTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AboutUs", "User_Id1", c => c.Int());
            CreateIndex("dbo.AboutUs", "User_Id1");
            AddForeignKey("dbo.AboutUs", "User_Id1", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AboutUs", "User_Id1", "dbo.Users");
            DropIndex("dbo.AboutUs", new[] { "User_Id1" });
            DropColumn("dbo.AboutUs", "User_Id1");
        }
    }
}
