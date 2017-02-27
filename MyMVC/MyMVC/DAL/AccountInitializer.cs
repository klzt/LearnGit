using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMVC.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser>() {
                new SysUser() { UserName="joy",PassWord="123",Email="joy@163.com" },
                new SysUser() { UserName="jerry",PassWord="000",Email="jerry@qq.com" }
            };

            var sysRoles = new List<SysRole>() {
                new SysRole() { RoleName="Admin",RoleDesc="超级管理员" },
                new SysRole() { RoleName="Guest",RoleDesc="游客"}
            };


            sysUsers.ForEach(t => context.SysUsers.Add(t));
            sysRoles.ForEach(t => context.SysRoles.Add(t));

            //context.SysUsers.AddRange(sysUsers);
            //context.SysRoles.AddRange(sysRoles);

            context.SaveChanges();
        }
    }
}