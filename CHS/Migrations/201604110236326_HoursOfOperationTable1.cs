namespace CHS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HoursOfOperationTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoursOfOperations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dayOfWeek = c.String(),
                        openTime = c.String(),
                        closeTime = c.String(),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoursOfOperations");
        }
    }
}
