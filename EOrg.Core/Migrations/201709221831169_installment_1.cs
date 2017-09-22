namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class installment_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Installmet",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        SellID = c.Guid(nullable: false),
                        PaidAmount = c.Int(nullable: false),
                        Remark = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sell",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ProductID = c.Guid(nullable: false),
                        CustomerID = c.Guid(nullable: false),
                        ColorID = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        BuyPrice = c.Int(nullable: false),
                        SellPrice = c.Int(nullable: false),
                        PayType = c.Int(nullable: false),
                        EMITypeID = c.Guid(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sell");
            DropTable("dbo.Installmet");
        }
    }
}
