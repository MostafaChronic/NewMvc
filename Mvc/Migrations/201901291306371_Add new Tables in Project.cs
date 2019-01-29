namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddnewTablesinProject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewsCommands", "CommandDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.NewsCommands", "LikeDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewsCommands", "LikeDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.NewsCommands", "CommandDate");
        }
    }
}
