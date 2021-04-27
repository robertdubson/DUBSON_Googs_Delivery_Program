namespace DataLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ownedEntities : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Order", "Destination_ID", "dbo.Destination");
            DropForeignKey("dbo.Order", "InvolvedTransport_ID", "dbo.Transport");
            DropForeignKey("dbo.Order", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Transport", "DeliveryType_ID", "dbo.DeliveryType");
            DropForeignKey("dbo.Transport", "TransportType_ID", "dbo.TransportType");
            DropForeignKey("dbo.Product", "DeliveryType_ID", "dbo.DeliveryType");
            DropIndex("dbo.Order", new[] { "Destination_ID" });
            DropIndex("dbo.Order", new[] { "InvolvedTransport_ID" });
            DropIndex("dbo.Order", new[] { "Product_ID" });
            DropIndex("dbo.Transport", new[] { "DeliveryType_ID" });
            DropIndex("dbo.Transport", new[] { "TransportType_ID" });
            DropIndex("dbo.Product", new[] { "DeliveryType_ID" });
            AlterColumn("dbo.Order", "Destination_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Order", "InvolvedTransport_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Order", "Product_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Transport", "DeliveryType_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Transport", "TransportType_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Product", "DeliveryType_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Order", "Destination_ID");
            CreateIndex("dbo.Order", "InvolvedTransport_ID");
            CreateIndex("dbo.Order", "Product_ID");
            CreateIndex("dbo.Transport", "DeliveryType_ID");
            CreateIndex("dbo.Transport", "TransportType_ID");
            CreateIndex("dbo.Product", "DeliveryType_ID");
            AddForeignKey("dbo.Order", "Destination_ID", "dbo.Destination", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Order", "InvolvedTransport_ID", "dbo.Transport", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Order", "Product_ID", "dbo.Product", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Transport", "DeliveryType_ID", "dbo.DeliveryType", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Transport", "TransportType_ID", "dbo.TransportType", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Product", "DeliveryType_ID", "dbo.DeliveryType", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "DeliveryType_ID", "dbo.DeliveryType");
            DropForeignKey("dbo.Transport", "TransportType_ID", "dbo.TransportType");
            DropForeignKey("dbo.Transport", "DeliveryType_ID", "dbo.DeliveryType");
            DropForeignKey("dbo.Order", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Order", "InvolvedTransport_ID", "dbo.Transport");
            DropForeignKey("dbo.Order", "Destination_ID", "dbo.Destination");
            DropIndex("dbo.Product", new[] { "DeliveryType_ID" });
            DropIndex("dbo.Transport", new[] { "TransportType_ID" });
            DropIndex("dbo.Transport", new[] { "DeliveryType_ID" });
            DropIndex("dbo.Order", new[] { "Product_ID" });
            DropIndex("dbo.Order", new[] { "InvolvedTransport_ID" });
            DropIndex("dbo.Order", new[] { "Destination_ID" });
            AlterColumn("dbo.Product", "DeliveryType_ID", c => c.Int());
            AlterColumn("dbo.Transport", "TransportType_ID", c => c.Int());
            AlterColumn("dbo.Transport", "DeliveryType_ID", c => c.Int());
            AlterColumn("dbo.Order", "Product_ID", c => c.Int());
            AlterColumn("dbo.Order", "InvolvedTransport_ID", c => c.Int());
            AlterColumn("dbo.Order", "Destination_ID", c => c.Int());
            CreateIndex("dbo.Product", "DeliveryType_ID");
            CreateIndex("dbo.Transport", "TransportType_ID");
            CreateIndex("dbo.Transport", "DeliveryType_ID");
            CreateIndex("dbo.Order", "Product_ID");
            CreateIndex("dbo.Order", "InvolvedTransport_ID");
            CreateIndex("dbo.Order", "Destination_ID");
            AddForeignKey("dbo.Product", "DeliveryType_ID", "dbo.DeliveryType", "ID");
            AddForeignKey("dbo.Transport", "TransportType_ID", "dbo.TransportType", "ID");
            AddForeignKey("dbo.Transport", "DeliveryType_ID", "dbo.DeliveryType", "ID");
            AddForeignKey("dbo.Order", "Product_ID", "dbo.Product", "ID");
            AddForeignKey("dbo.Order", "InvolvedTransport_ID", "dbo.Transport", "ID");
            AddForeignKey("dbo.Order", "Destination_ID", "dbo.Destination", "ID");
        }
    }
}
