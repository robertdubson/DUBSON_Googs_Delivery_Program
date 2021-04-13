namespace DataLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDestination : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time_Of_Ordering = c.DateTime(nullable: false),
                        TimeNeededForDelivery = c.Double(nullable: false),
                        Destination_ID = c.Int(),
                        InvolvedTransport_ID = c.Int(),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Destination", t => t.Destination_ID)
                .ForeignKey("dbo.Transport", t => t.InvolvedTransport_ID)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.Destination_ID)
                .Index(t => t.InvolvedTransport_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Transport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Speed = c.Double(nullable: false),
                        InTheShop = c.Boolean(nullable: false),
                        DeliveryType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DeliveryType", t => t.DeliveryType_ID)
                .Index(t => t.DeliveryType_ID);
            
            CreateTable(
                "dbo.DeliveryType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeliveryType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Double(nullable: false),
                        Volume = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        TimeForPreparation = c.Double(nullable: false),
                        DeliveryType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DeliveryType", t => t.DeliveryType_ID)
                .Index(t => t.DeliveryType_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Product", "DeliveryType_ID", "dbo.DeliveryType");
            DropForeignKey("dbo.Order", "InvolvedTransport_ID", "dbo.Transport");
            DropForeignKey("dbo.Transport", "DeliveryType_ID", "dbo.DeliveryType");
            DropForeignKey("dbo.Order", "Destination_ID", "dbo.Destination");
            DropIndex("dbo.Product", new[] { "DeliveryType_ID" });
            DropIndex("dbo.Transport", new[] { "DeliveryType_ID" });
            DropIndex("dbo.Order", new[] { "Product_ID" });
            DropIndex("dbo.Order", new[] { "InvolvedTransport_ID" });
            DropIndex("dbo.Order", new[] { "Destination_ID" });
            DropTable("dbo.Product");
            DropTable("dbo.DeliveryType");
            DropTable("dbo.Transport");
            DropTable("dbo.Order");
        }
    }
}
