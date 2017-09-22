namespace EOrg.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FullName = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        SpouseName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        NIDNumber = c.String(),
                        Occupation = c.String(),
                        SpouseOccupation = c.String(),
                        MonthlyIncome = c.Int(nullable: false),
                        MonthlyExpenditure = c.Int(nullable: false),
                        FamilyMembers = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "PresentAddress_ID", "dbo.Address");
            DropForeignKey("dbo.Customer", "PermanentAddress_ID", "dbo.Address");
            DropIndex("dbo.Customer", new[] { "PresentAddress_ID" });
            DropIndex("dbo.Customer", new[] { "PermanentAddress_ID" });
            DropTable("dbo.Address");
            DropTable("dbo.Customer");
        }
    }
}
