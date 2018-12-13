using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyWeb.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Show(int pageNum)
        {
            ViewBag.PageNum = pageNum;
            return View();
        }
    }
}