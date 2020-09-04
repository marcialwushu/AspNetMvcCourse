namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Setup : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.Customers", "MembershipType_Id", c => c.Byte());
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
            DropColumn("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte());
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 4000));
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 4000));
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "MembershipType_Id", c => c.Int());
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
