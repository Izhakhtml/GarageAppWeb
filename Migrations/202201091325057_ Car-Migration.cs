namespace GarageAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOwner = c.String(),
                        CarNumber = c.Int(nullable: false),
                        IfPastTest = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
