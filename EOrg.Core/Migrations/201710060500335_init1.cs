namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropForeignKey("dbo.UserClaim", "UserId", "dbo.User");
            DropForeignKey("dbo.UserLogin", "UserId", "dbo.User");
            DropForeignKey("dbo.UserRole", "UserId", "dbo.User");
            DropIndex("dbo.Role", "RoleNameIndex");
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.User", "UserNameIndex");
            DropIndex("dbo.UserClaim", new[] { "UserId" });
            DropIndex("dbo.UserLogin", new[] { "UserId" });
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
                "dbo.Customer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FullName = c.String(nullable: false),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        SpouseName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        NidNumber = c.String(),
                        Occupation = c.String(),
                        SpouseOccupation = c.String(),
                        MonthlyIncome = c.Int(nullable: false),
                        MonthlyExpenditure = c.Int(nullable: false),
                        FamilyMembers = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        PermanentAddress_ID = c.Guid(),
                        PresentAddress_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.PermanentAddress_ID)
                .ForeignKey("dbo.Address", t => t.PresentAddress_ID)
                .Index(t => t.PermanentAddress_ID)
                .Index(t => t.PresentAddress_ID);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        District = c.String(),
                        Thana = c.String(),
                        PostOffice = c.String(),
                        Village = c.String(),
                        House = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Installment",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        SellId = c.Guid(nullable: false),
                        PaidAmount = c.Int(nullable: false),
                        Remark = c.String(),
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
                        Price = c.Int(nullable: false),
                        SubCategoryId = c.Guid(nullable: false),
                        Details = c.String(),
                        Size = c.String(),
                        EmiAvailable = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                        Manufacturer_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brand", t => t.Manufacturer_ID)
                .Index(t => t.Manufacturer_ID);
            
            CreateTable(
                "dbo.EmiType",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PayAmount = c.Int(nullable: false),
                        TotalInstallment = c.Int(nullable: false),
                        Product_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.ProductQuantity",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ColorId = c.Guid(),
                        Quantity = c.Int(nullable: false),
                        Product_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Product", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Sell",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        ColorId = c.Guid(),
                        Quantity = c.Int(nullable: false),
                        BuyPrice = c.Int(nullable: false),
                        SellPrice = c.Int(nullable: false),
                        PayType = c.Int(nullable: false),
                        EmiTypeId = c.Guid(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SubCategory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Role");
            DropTable("dbo.UserRole");
            DropTable("dbo.User");
            DropTable("dbo.UserClaim");
            DropTable("dbo.UserLogin");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserLogin",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });
            
            CreateTable(
                "dbo.UserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.ProductQuantity", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Product", "Manufacturer_ID", "dbo.Brand");
            DropForeignKey("dbo.EmiType", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.Customer", "PresentAddress_ID", "dbo.Address");
            DropForeignKey("dbo.Customer", "PermanentAddress_ID", "dbo.Address");
            DropIndex("dbo.ProductQuantity", new[] { "Product_ID" });
            DropIndex("dbo.EmiType", new[] { "Product_ID" });
            DropIndex("dbo.Product", new[] { "Manufacturer_ID" });
            DropIndex("dbo.Customer", new[] { "PresentAddress_ID" });
            DropIndex("dbo.Customer", new[] { "PermanentAddress_ID" });
            DropTable("dbo.SubCategory");
            DropTable("dbo.Sell");
            DropTable("dbo.ProductQuantity");
            DropTable("dbo.EmiType");
            DropTable("dbo.Product");
            DropTable("dbo.Installment");
            DropTable("dbo.Address");
            DropTable("dbo.Customer");
            DropTable("dbo.Color");
            DropTable("dbo.Category");
            DropTable("dbo.Brand");
            CreateIndex("dbo.UserLogin", "UserId");
            CreateIndex("dbo.UserClaim", "UserId");
            CreateIndex("dbo.User", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.UserRole", "RoleId");
            CreateIndex("dbo.UserRole", "UserId");
            CreateIndex("dbo.Role", "Name", unique: true, name: "RoleNameIndex");
            AddForeignKey("dbo.UserRole", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserLogin", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserClaim", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRole", "RoleId", "dbo.Role", "Id", cascadeDelete: true);
        }
    }
}
