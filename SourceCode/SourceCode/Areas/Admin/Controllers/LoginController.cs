using Models.Dao;
using SourceCode.Areas.Admin.Models;
using SourceCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
namespace SourceCode.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            var dao = new UsersDao();
            string Password = Encryptor.MD5Hash(model.Password);
            var result = dao.Login(model.UserName, Password);
            if (result)
            {
                var user = dao.GetById(model.UserName);
                var userSession = new UserLogin();
                userSession.UserName = user.UserName;
                userSession.UserID = user.UserId;
                Session.Add(CommonConstants.USER_SESSION, userSession);
                return RedirectToAction("Index", "Index");
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không đúng.");
            }
            return View();
        }
    }
}