using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Visa(int id)
        {
            ViewData["productId"] = id;
            return View();
        }
    }
}