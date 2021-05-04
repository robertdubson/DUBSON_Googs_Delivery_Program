namespace DataLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cratTableStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Order", "OrderStatus_ID", c => c.Int());
            CreateIndex("dbo.Order", "OrderStatus_ID");
            AddForeignKey("dbo.Order", "OrderStatus_ID", "dbo.OrderStatus", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "OrderStatus_ID", "dbo.OrderStatus");
            DropIndex("dbo.Order", new[] { "OrderStatus_ID" });
            DropColumn("dbo.Order", "OrderStatus_ID");
            DropTable("dbo.OrderStatus");
        }
    }
}
