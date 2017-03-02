namespace MyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyUser1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SysUser", "UserName", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SysUser", "UserName", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
