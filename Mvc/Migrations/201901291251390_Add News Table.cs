namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        Title = c.String(),
                        ShortDescribe = c.String(),
                        Describe = c.String(),
                        NewsDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "AccountId", "dbo.Accounts");
            DropIndex("dbo.News", new[] { "AccountId" });
            DropTable("dbo.News");
        }
    }
}
