namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "RegisterDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "RegisterDate", c => c.DateTime(nullable: false));
        }
    }
}
