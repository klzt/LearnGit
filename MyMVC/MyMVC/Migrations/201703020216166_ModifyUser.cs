namespace MyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SysUser", "PassWord", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SysUser", "PassWord", c => c.String());
        }
    }
}
