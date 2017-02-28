
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyMVC.DAL;
using MyMVC.Models;
using PagedList;

namespace MyMVC.Controllers
{
    public class AccountController : Controller
    {
        AccountContext db = new AccountContext();

        // GET: Account
        public ActionResult Index(string searchKey, string sortKey, string currFilter, int pager = 1)
        {
            if (searchKey == null)
            {
                searchKey = currFilter;
            }

            var user = db.SysUsers.Select(t => t);

            if (!string.IsNullOrEmpty(searchKey))
            {
                user = user.Where(t => t.UserName.Contains(searchKey));
            }

            if (!string.IsNullOrEmpty(sortKey))
            {
                user = user.OrderBy(t => t.UserName);
            }
            else
            {
                user = user.OrderByDescending(t => t.UserName);
            }

            ViewBag.currFilter = searchKey;
            ViewBag.OldSortKey = sortKey;
            ViewBag.sortKey = string.IsNullOrEmpty(sortKey) ? "1" : string.Empty;
            //ViewBag.DateTime = DateTime.Now;

            return View(user.ToPagedList(pager, 3));
        }

        public ActionResult Details(int id)
        {
            return View(db.SysUsers.Find(id));
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前..";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            var email = fc["loginEmail"];
            var pwd = fc["loginpwd"];

            var user = db.SysUsers.Where(t => t.PassWord == pwd && t.Email == email);
            if (user.Count() > 0)
            {
                ViewBag.LoginState = "欢迎您：" + email;
            }
            else
            {
                ViewBag.LoginState = email + "不存在";
            }

            return View();
        }

        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            var user = new SysUser()
            {
                UserName = fc["username"],
                PassWord = fc["password"],
                Email = fc["email"]
            };
            db.SysUsers.Add(user);
            db.SaveChanges();
            return View("Index", db.SysUsers);
        }

        public ActionResult Delete(int id)
        {
            var user = db.SysUsers.Find(id);
            user.UserName += "删除测试";
            db.SaveChanges();
            return View("Index", db.SysUsers);
        }

        [ChildActionOnly]
        public ActionResult ShowPartialAction()
        {
            ViewBag.DateTime = DateTime.Now.AddDays(1);
            return View("_PartialDateDemo");
            //return View("~/Views/Shared/_PartialDemo.cshtml");
        }

        public ActionResult ShowPartial()
        {
            //return View("~/Views/Shared/_PartialDemo.cshtml");
            ViewBag.DateTime = DateTime.Now.AddDays(1);
            return PartialView("_PartialDateDemo");
        }

    }
}