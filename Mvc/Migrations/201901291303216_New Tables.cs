namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.News", "AccountId", "dbo.Accounts");
            CreateTable(
                "dbo.NewsCommands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        NewsId = c.Int(nullable: false),
                        Commandtxt = c.String(),
                        LikeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.NewsLikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        NewsId = c.Int(nullable: false),
                        LikeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.NewsId);
            
            AddForeignKey("dbo.News", "AccountId", "dbo.Accounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.NewsLikes", "NewsId", "dbo.News");
            DropForeignKey("dbo.NewsLikes", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.NewsCommands", "NewsId", "dbo.News");
            DropForeignKey("dbo.NewsCommands", "AccountId", "dbo.Accounts");
            DropIndex("dbo.NewsLikes", new[] { "NewsId" });
            DropIndex("dbo.NewsLikes", new[] { "AccountId" });
            DropIndex("dbo.NewsCommands", new[] { "NewsId" });
            DropIndex("dbo.NewsCommands", new[] { "AccountId" });
            DropTable("dbo.NewsLikes");
            DropTable("dbo.NewsCommands");
            AddForeignKey("dbo.News", "AccountId", "dbo.Accounts", "Id", cascadeDelete: true);
        }
    }
}
