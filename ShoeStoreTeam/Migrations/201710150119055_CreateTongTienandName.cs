namespace ShoeStoreTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTongTienandName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "Name", c => c.String());
            AddColumn("dbo.Orders", "TongTien", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "TongTien");
            DropColumn("dbo.OrderDetails", "Name");
        }
    }
}
