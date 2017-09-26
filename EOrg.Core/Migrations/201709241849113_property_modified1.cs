namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class property_modified1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "NidNumber1", c => c.String());
            AddColumn("dbo.Installmet", "SellId1", c => c.Guid(nullable: false));
            AddColumn("dbo.Product", "SubCategoryId1", c => c.Guid(nullable: false));
            AddColumn("dbo.Product", "EmiAvailable1", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductColor", "ColorId1", c => c.Guid());
            AddColumn("dbo.Specification", "CpuSpeed1", c => c.Double(nullable: false));
            AddColumn("dbo.Specification", "Ram1", c => c.Double(nullable: false));
            AddColumn("dbo.Specification", "Rom1", c => c.Double(nullable: false));
            AddColumn("dbo.Specification", "SimCard1", c => c.String());
            AddColumn("dbo.Specification", "BrandId1", c => c.Guid(nullable: false));
            AddColumn("dbo.Sell", "ProductId1", c => c.Guid(nullable: false));
            AddColumn("dbo.Sell", "CustomerId1", c => c.Guid(nullable: false));
            AddColumn("dbo.Sell", "ColorId1", c => c.Guid());
            AddColumn("dbo.Sell", "EmiTypeId1", c => c.Guid());
            AddColumn("dbo.SubCategory", "CategoryId1", c => c.Guid(nullable: false));
            DropColumn("dbo.Customer", "NIDNumber");
            DropColumn("dbo.Installmet", "SellId");
            DropColumn("dbo.Product", "SubCategoryId");
            DropColumn("dbo.Product", "EmiAvailable");
            DropColumn("dbo.ProductColor", "ColorId");
            DropColumn("dbo.Specification", "CpuSpeed");
            DropColumn("dbo.Specification", "Ram");
            DropColumn("dbo.Specification", "Rom");
            DropColumn("dbo.Specification", "SimCard");
            DropColumn("dbo.Specification", "BrandId");
            DropColumn("dbo.Sell", "ProductId");
            DropColumn("dbo.Sell", "CustomerId");
            DropColumn("dbo.Sell", "ColorId");
            DropColumn("dbo.Sell", "EmiTypeId");
            DropColumn("dbo.SubCategory", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubCategory", "CategoryId", c => c.Guid(nullable: false));
            AddColumn("dbo.Sell", "EmiTypeId", c => c.Guid());
            AddColumn("dbo.Sell", "ColorId", c => c.Guid());
            AddColumn("dbo.Sell", "CustomerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Sell", "ProductId", c => c.Guid(nullable: false));
            AddColumn("dbo.Specification", "BrandId", c => c.Guid(nullable: false));
            AddColumn("dbo.Specification", "SimCard", c => c.String());
            AddColumn("dbo.Specification", "Rom", c => c.Double(nullable: false));
            AddColumn("dbo.Specification", "Ram", c => c.Double(nullable: false));
            AddColumn("dbo.Specification", "CpuSpeed", c => c.Double(nullable: false));
            AddColumn("dbo.ProductColor", "ColorId", c => c.Guid());
            AddColumn("dbo.Product", "EmiAvailable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "SubCategoryId", c => c.Guid(nullable: false));
            AddColumn("dbo.Installmet", "SellId", c => c.Guid(nullable: false));
            AddColumn("dbo.Customer", "NIDNumber", c => c.String());
            DropColumn("dbo.SubCategory", "CategoryId1");
            DropColumn("dbo.Sell", "EmiTypeId1");
            DropColumn("dbo.Sell", "ColorId1");
            DropColumn("dbo.Sell", "CustomerId1");
            DropColumn("dbo.Sell", "ProductId1");
            DropColumn("dbo.Specification", "BrandId1");
            DropColumn("dbo.Specification", "SimCard1");
            DropColumn("dbo.Specification", "Rom1");
            DropColumn("dbo.Specification", "Ram1");
            DropColumn("dbo.Specification", "CpuSpeed1");
            DropColumn("dbo.ProductColor", "ColorId1");
            DropColumn("dbo.Product", "EmiAvailable1");
            DropColumn("dbo.Product", "SubCategoryId1");
            DropColumn("dbo.Installmet", "SellId1");
            DropColumn("dbo.Customer", "NidNumber1");
        }
    }
}
