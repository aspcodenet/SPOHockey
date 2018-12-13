using HockeyWeb.Models;
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
            var model = GetPlayerFromDatabase(id);
            return View(model);
        }


        private Team GetTeamFromDatabase(int id)
        {
            var t = new Team();
            t.Id = id;
            if (id == 1)
            {
                t.Namn = "Djurgården";
                t.Players.Add(new Player { Id = 13, Firstname = "Mats", Lastname = "Sundin" });
                t.Players.Add(new Player { Id = 14, Firstname="Håkan", Lastname="Södergren"  });
                return t;
            }
            if (id == 2)
            {
                t.Namn = "AIK";
                t.Players.Add(new Player { Id = 1, Firstname = "Mats", Lastname = "Alba" });
                t.Players.Add(new Player { Id = 4, Firstname = "Per-Erik", Lastname = "Eklund" });
                return t;
            }
            if (id == 3)
            {
                t.Namn = "Hammarby";
                t.Players.Add(new Player { Id = 111, Firstname = "Marre", Lastname = "Czerkawski" });
                t.Players.Add(new Player { Id = 114, Firstname = "Karl", Lastname = "Karlsson" });
                t.Players.Add(new Player { Id = 113, Firstname = "Per", Lastname = "Persson" });
                return t;
            }
            return null;
        }


        private Player GetPlayerFromDatabase(int id)
        {
            for(var t = 1; t <=3; t++)
            {
                var  team = GetTeamFromDatabase(t);
                var p = team.Players.FirstOrDefault(x => x.Id == id);
                if (p != null) return p;
            }
            return null;
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