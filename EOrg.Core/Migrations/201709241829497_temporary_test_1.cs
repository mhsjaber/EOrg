namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temporary_test_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brand", "Ayesha", c => c.String());
            AlterColumn("dbo.Sell", "ColorID", c => c.Guid());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sell", "ColorID", c => c.Guid(nullable: false));
            DropColumn("dbo.Brand", "Ayesha");
        }
    }
}
