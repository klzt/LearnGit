using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyMVC.DAL
{
    public class AccountContext : DbContext
    {
        public AccountContext() : base("MyMVCSql")
        {
        }
        
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUser> SysUsers { get; set; }

        public DbSet<SysUserRole> SysUserRoles { get; set; }

        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}