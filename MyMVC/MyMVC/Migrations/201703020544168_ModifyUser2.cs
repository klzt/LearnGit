namespace MyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyUser2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SysUser", name: "UserName", newName: "LoginName");
            AlterColumn("dbo.SysUser", "LoginName", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SysUser", "LoginName", c => c.String(nullable: false, maxLength: 11));
            RenameColumn(table: "dbo.SysUser", name: "LoginName", newName: "UserName");
        }
    }
}
