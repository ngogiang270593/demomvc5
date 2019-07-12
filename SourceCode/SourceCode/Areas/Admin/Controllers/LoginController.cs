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
            string Password = EncodePassword(model.Password);
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

        public static string EncodePassword(string originalPassword)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            System.Security.Cryptography.MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes).Replace("-", "");
        }
    }
}