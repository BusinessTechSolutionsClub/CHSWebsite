namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicesTableUpdataaddingwomenattribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "women", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "women");
        }
    }
}
