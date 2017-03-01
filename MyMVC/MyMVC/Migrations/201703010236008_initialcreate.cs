namespace MyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SysRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleDesc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SysUserRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SysUserId = c.Int(nullable: false),
                        SysRoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SysRole", t => t.SysRoleId, cascadeDelete: true)
                .ForeignKey("dbo.SysUser", t => t.SysUserId, cascadeDelete: true)
                .Index(t => t.SysUserId)
                .Index(t => t.SysRoleId);
            
            CreateTable(
                "dbo.SysUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SysUserRole", "SysUserId", "dbo.SysUser");
            DropForeignKey("dbo.SysUserRole", "SysRoleId", "dbo.SysRole");
            DropIndex("dbo.SysUserRole", new[] { "SysRoleId" });
            DropIndex("dbo.SysUserRole", new[] { "SysUserId" });
            DropTable("dbo.SysUser");
            DropTable("dbo.SysUserRole");
            DropTable("dbo.SysRole");
        }
    }
}
