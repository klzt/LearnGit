using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class SysUser
    {
        //[DataType(DataType ErrorMessage ="只能是数字")]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}