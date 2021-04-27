namespace DataLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTransportType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransportType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Transport", "TransportType_ID", c => c.Int());
            CreateIndex("dbo.Transport", "TransportType_ID");
            AddForeignKey("dbo.Transport", "TransportType_ID", "dbo.TransportType", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transport", "TransportType_ID", "dbo.TransportType");
            DropIndex("dbo.Transport", new[] { "TransportType_ID" });
            DropColumn("dbo.Transport", "TransportType_ID");
            DropTable("dbo.TransportType");
        }
    }
}
