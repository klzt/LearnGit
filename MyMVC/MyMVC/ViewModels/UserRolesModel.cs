using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.ViewModels
{
    public class UserRolesModel
    {
        public IEnumerable<SysUser> SysUsers { get; set; }
        public IEnumerable<SysRole> SysRoles { get; set; }
        public IEnumerable<SysUserRole> SysUserRoles { get; set; }
    }
}