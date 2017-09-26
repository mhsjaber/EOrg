namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class property_modified3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmiType1", newName: "EmiType");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EmiType", newName: "EmiType1");
        }
    }
}
