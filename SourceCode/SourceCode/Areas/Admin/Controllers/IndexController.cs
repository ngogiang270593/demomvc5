using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace SourceCode.Areas.Admin.Controllers
{
    public class IndexController : BaseController
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}