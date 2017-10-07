namespace ShoeStoreTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "DisplayOrder", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "DisplayOrder");
        }
    }
}
