namespace ShoeStoreTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableSlide : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Slides", "Slogan", c => c.String());
            AddColumn("dbo.Slides", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Slides", "Content");
            DropColumn("dbo.Slides", "Slogan");
        }
    }
}
