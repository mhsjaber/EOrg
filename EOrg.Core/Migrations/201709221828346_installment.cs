namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class installment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EMIType",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Price = c.Int(nullable: false),
                        Installment = c.Int(nullable: false),
                        Product_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
            AddColumn("dbo.Product", "BuyPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "SellPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EMIType", "Product_ID", "dbo.Product");
            DropIndex("dbo.EMIType", new[] { "Product_ID" });
            DropColumn("dbo.Product", "SellPrice");
            DropColumn("dbo.Product", "BuyPrice");
            DropTable("dbo.EMIType");
        }
    }
}
