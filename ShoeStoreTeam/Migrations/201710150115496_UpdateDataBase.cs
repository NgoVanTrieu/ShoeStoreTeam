namespace ShoeStoreTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataBase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderDetails", "Name");
            DropColumn("dbo.Orders", "TongTien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "TongTien", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetails", "Name", c => c.String());
        }
    }
}
