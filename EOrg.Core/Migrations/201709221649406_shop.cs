namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        SubCategoryID = c.Guid(nullable: false),
                        EMIAvailable = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        Specification_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Specification", t => t.Specification_ID)
                .Index(t => t.Specification_ID);
            
            CreateTable(
                "dbo.CustomField",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Value = c.String(nullable: false),
                        Product_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Specification",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Weight = c.Double(nullable: false),
                        DisplaySize = c.Double(nullable: false),
                        FrontCamera = c.Double(nullable: false),
                        BackCamera = c.Double(nullable: false),
                        CPUSpeed = c.Double(nullable: false),
                        RAM = c.Double(nullable: false),
                        ROM = c.Double(nullable: false),
                        Battery = c.String(),
                        SIMCard = c.String(),
                        Processor = c.String(),
                        Warranty = c.String(),
                        BrandID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SubCategory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CategoryID = c.Guid(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Customer", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "CreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "UpdatedBy", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Specification_ID", "dbo.Specification");
            DropForeignKey("dbo.CustomField", "Product_ID", "dbo.Product");
            DropIndex("dbo.CustomField", new[] { "Product_ID" });
            DropIndex("dbo.Product", new[] { "Specification_ID" });
            AlterColumn("dbo.Customer", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Customer", "CreatedBy", c => c.String());
            AlterColumn("dbo.Customer", "FullName", c => c.String());
            DropTable("dbo.SubCategory");
            DropTable("dbo.Specification");
            DropTable("dbo.CustomField");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
            DropTable("dbo.Brand");
        }
    }
}
