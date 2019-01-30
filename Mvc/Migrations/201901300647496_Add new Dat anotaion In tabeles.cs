namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddnewDatanotaionIntabeles : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.News", "ShortDescribe", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.News", "Describe", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Describe", c => c.String());
            AlterColumn("dbo.News", "ShortDescribe", c => c.String());
            AlterColumn("dbo.News", "Title", c => c.String());
        }
    }
}
