namespace GarageAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GaragesDmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CarId_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.CarId_ID)
                .Index(t => t.CarId_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "CarId_ID", "dbo.Cars");
            DropIndex("dbo.Clients", new[] { "CarId_ID" });
            DropTable("dbo.Clients");
        }
    }
}
