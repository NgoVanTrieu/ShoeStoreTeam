namespace ShoeStoreTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnTableCategoryAndProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Link", c => c.String());
            AddColumn("dbo.Products", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Link");
            DropColumn("dbo.Categories", "Link");
        }
    }
}
