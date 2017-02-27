using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class SysUserRole
    {
        public int ID { get; set; }
        public int SysUserId { get; set; }
        public int SysRoleId { get; set; }

        public virtual SysRole SysRoles { get; set; }
        public virtual SysUser SysUsers { get; set; }
    }
}