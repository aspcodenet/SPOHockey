using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockeyWeb.Controllers
{
    public class HockeyController : Controller
    {

        public ActionResult Show(int id)
        {
            ViewData["HockeyPlayerId"] = id;
            ViewData["HockeyPlayerName"] = FetchNameFromDatabase(id);
            return View();
        }

        private string FetchNameFromDatabase(int id)
        {
            if (id == 13) return "Mats Sundin";
            if (id == 21) return "Peter Forsberg";
            return "Unknown";
        }


        // GET: Hockey
        public ActionResult Index()
        {
            return View();
        }
    }
}