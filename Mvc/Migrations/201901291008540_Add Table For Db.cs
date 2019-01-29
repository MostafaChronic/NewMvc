namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableForDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Gender = c.Boolean(nullable: false),
                        IsBlock = c.Boolean(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        AccountType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewsLikes", "NewsId", "dbo.News");
            DropForeignKey("dbo.NewsLikes", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.NewsCommands", "NewsId", "dbo.News");
            DropForeignKey("dbo.News", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.NewsCommands", "AccountId", "dbo.Accounts");
            DropIndex("dbo.NewsLikes", new[] { "NewsId" });
            DropIndex("dbo.NewsLikes", new[] { "AccountId" });
            DropIndex("dbo.News", new[] { "AccountId" });
            DropIndex("dbo.NewsCommands", new[] { "NewsId" });
            DropIndex("dbo.NewsCommands", new[] { "AccountId" });
            DropTable("dbo.NewsLikes");
            DropTable("dbo.News");
            DropTable("dbo.NewsCommands");
            DropTable("dbo.Accounts");
        }
    }
}
