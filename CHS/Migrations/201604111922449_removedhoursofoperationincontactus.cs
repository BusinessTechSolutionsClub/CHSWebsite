namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedhoursofoperationincontactus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContactUs", "HoursOfOperation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactUs", "HoursOfOperation", c => c.String());
        }
    }
}
