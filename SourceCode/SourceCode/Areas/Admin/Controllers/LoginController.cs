using Models.Dao;
using SourceCode.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SourceCode.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            var dao = new UsersDao();
            var result = dao.Login(model.UserName, model.Password);
            if (result)
            {

            }
            else
            {
                ModelState.AddModelError("","Đăng nhập không đúng.")
            }
            return View();
        }
    }
}