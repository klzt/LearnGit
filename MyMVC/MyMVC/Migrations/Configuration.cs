namespace MyMVC.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMVC.DAL.AccountContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyMVC.DAL.AccountContext context)
        {
            /*
            //更新指定字段
            var sysUsers = new List<SysUser>()
            {
                //new SysUser() { ID=43,CreateDate=DateTime.Now},
                //new SysUser() { ID=44,CreateDate=DateTime.Now.AddDays(10)},
                //new SysUser() { ID=45,CreateDate=DateTime.Now.AddDays(-10)},
                new SysUser() { ID=43,CreateDate=DateTime.Now,UserName="joy",PassWord="123",Email="joy@163.com"},
                new SysUser() { ID=44,CreateDate=DateTime.Now.AddDays(10),UserName="jerry",PassWord="000",Email="jerry@qq.com"},
                new SysUser() { ID=45,CreateDate=DateTime.Now.AddDays(-10),UserName="john",PassWord="000",Email="john@qq.com"},
            };

            sysUsers.ForEach(t => context.SysUsers.AddOrUpdate(s => s.ID, t));
            context.SaveChanges();
            */

            /* 更新/插入基础数据
            var sysUsers = new List<SysUser>() {
                new SysUser() { UserName="joy",PassWord="123",Email="joy@163.com" },
                new SysUser() { UserName="jerry",PassWord="000",Email="jerry@qq.com" },
                new SysUser() { UserName="john",PassWord="000",Email="john@qq.com" }
            };

            var sysRoles = new List<SysRole>() {
                new SysRole() { RoleName="Admin",RoleDesc="超级管理员" },
                new SysRole() { RoleName="Guest",RoleDesc="游客"}
            };

            
            sysUsers.ForEach(t => context.SysUsers.AddOrUpdate(r => r.UserName, t));
            sysRoles.ForEach(t => context.SysRoles.AddOrUpdate(s => s.RoleName, t));
            context.SaveChanges();

            var sysUserRoles = new List<SysUserRole>() {
                new SysUserRole() {
                    SysRoleId = sysRoles.First(t => t.RoleName == "Admin").ID,
                    SysUserId = sysUsers.First(t => t.UserName == "joy").ID
                },
                new SysUserRole() {
                    SysRoleId=sysRoles.First(t=>t.RoleName=="Guest").ID,
                    SysUserId=sysUsers.First(t=>t.UserName=="jerry").ID
                }
            };
            sysUserRoles.ForEach(t => context.SysUserRoles.Add(t));
            context.SaveChanges();

    */

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
