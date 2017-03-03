using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MyMVC.DAL;
using MyMVC.ViewModels;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class UserRoleController : Controller
    {
        // GET: UserRole
        public ActionResult Index(int? id)
        {
            var userRole = new UserRolesModel();
            AccountContext db = new AccountContext();
            userRole.SysUsers = db.SysUsers.ToList();
            //using (AccountContext db = new AccountContext())
            //{
            //    userRole.SysUsers = db.SysUsers.Include(t => t.SysUserRoles.Select(u => u.SysRoles))
            //                                             .Include(t => t.SysDepartment).ToList<SysUser>();
            //}
            if (id.HasValue)
            {
                ViewBag.CurrId = id.Value;
                userRole.SysUserRoles = userRole.SysUsers.Where(t => t.ID == id.Value).Single().SysUserRoles;
                userRole.SysRoles = userRole.SysUserRoles.Select(t => t.SysRoles);
            }

            return View(userRole);
        }
    }
}