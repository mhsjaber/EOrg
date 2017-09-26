namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_properties1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Installmet", newName: "Installment");
            AddColumn("dbo.Product", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.EmiType", "PayAmount", c => c.Int(nullable: false));
            AddColumn("dbo.EmiType", "TotalInstallment", c => c.Int(nullable: false));
            AlterColumn("dbo.Specification", "Weight", c => c.Double());
            AlterColumn("dbo.Specification", "DisplaySize", c => c.Double());
            AlterColumn("dbo.Specification", "FrontCamera", c => c.Double());
            AlterColumn("dbo.Specification", "BackCamera", c => c.Double());
            AlterColumn("dbo.Specification", "CpuSpeed", c => c.Double());
            AlterColumn("dbo.Specification", "Ram", c => c.Double());
            AlterColumn("dbo.Specification", "Rom", c => c.Double());
            DropColumn("dbo.Product", "BuyPrice");
            DropColumn("dbo.Product", "SellPrice");
            DropColumn("dbo.EmiType", "Price");
            DropColumn("dbo.EmiType", "Installment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmiType", "Installment", c => c.Int(nullable: false));
            AddColumn("dbo.EmiType", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "SellPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "BuyPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Specification", "Rom", c => c.Double(nullable: false));
            AlterColumn("dbo.Specification", "Ram", c => c.Double(nullable: false));
            AlterColumn("dbo.Specification", "CpuSpeed", c => c.Double(nullable: false));
            AlterColumn("dbo.Specification", "BackCamera", c => c.Double(nullable: false));
            AlterColumn("dbo.Specification", "FrontCamera", c => c.Double(nullable: false));
            AlterColumn("dbo.Specification", "DisplaySize", c => c.Double(nullable: false));
            AlterColumn("dbo.Specification", "Weight", c => c.Double(nullable: false));
            DropColumn("dbo.EmiType", "TotalInstallment");
            DropColumn("dbo.EmiType", "PayAmount");
            DropColumn("dbo.Product", "Price");
            RenameTable(name: "dbo.Installment", newName: "Installmet");
        }
    }
}
