namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_properties : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductColor", newName: "ProductQuantity");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ProductQuantity", newName: "ProductColor");
        }
    }
}
