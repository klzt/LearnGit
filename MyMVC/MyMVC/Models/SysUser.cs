using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class SysUser
    {
        //[DataType(DataType ErrorMessage ="只能是数字")]
        public int ID { get; set; }

        [MaxLength(10, ErrorMessage = "不能超过10位")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "不能为空")]
        [Column("LoginName"), Display(Name = "用户名")]
        public string UserName { get; set; }

        [MinLength(4, ErrorMessage = "最少4位数"), MaxLength(10, ErrorMessage = "不能超过10位")]
        [Display(Name = "密 码")]
        public string PassWord { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreateDate { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }

        public int? SysDepartmentId { get; set; }
        public virtual SysDepartment SysDepartment { get; set; }
    }
}