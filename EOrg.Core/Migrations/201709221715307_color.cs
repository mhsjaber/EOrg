namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class color : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ColorItem",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ColorID = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Product_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ColorItem", "Product_ID", "dbo.Product");
            DropIndex("dbo.ColorItem", new[] { "Product_ID" });
            DropTable("dbo.ColorItem");
            DropTable("dbo.Color");
        }
    }
}
