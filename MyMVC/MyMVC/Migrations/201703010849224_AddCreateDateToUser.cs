namespace MyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreateDateToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SysUser", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SysUser", "CreateDate");
        }
    }
}
