namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_name_change_ProductColor : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ColorItem", newName: "ProductColor");
            AlterColumn("dbo.ProductColor", "ColorID", c => c.Guid());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductColor", "ColorID", c => c.Guid(nullable: false));
            RenameTable(name: "dbo.ProductColor", newName: "ColorItem");
        }
    }
}
