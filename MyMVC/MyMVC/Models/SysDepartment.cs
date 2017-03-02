using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class SysDepartment
    {
        public int ID { get; set; }
        public string DepartName { get; set; }
        public string DepartDesc { get; set; }

        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}