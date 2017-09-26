namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temporary_test_1_remove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Brand", "Ayesha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Brand", "Ayesha", c => c.String());
        }
    }
}
