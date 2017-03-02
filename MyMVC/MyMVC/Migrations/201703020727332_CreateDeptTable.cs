namespace MyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDeptTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SysDepartment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartName = c.String(),
                        DepartDesc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.SysUser", "SysDepartmentId", c => c.Int());
            CreateIndex("dbo.SysUser", "SysDepartmentId");
            AddForeignKey("dbo.SysUser", "SysDepartmentId", "dbo.SysDepartment", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SysUser", "SysDepartmentId", "dbo.SysDepartment");
            DropIndex("dbo.SysUser", new[] { "SysDepartmentId" });
            DropColumn("dbo.SysUser", "SysDepartmentId");
            DropTable("dbo.SysDepartment");
        }
    }
}
