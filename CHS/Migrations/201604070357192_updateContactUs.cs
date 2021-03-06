namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateContactUs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        CellPhoneNumber = c.String(),
                        HoursOfOperation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactUs");
        }
    }
}
