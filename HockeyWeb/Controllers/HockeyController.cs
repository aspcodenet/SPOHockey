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
            var player = GetPlayerFromDatabase(id);
            var team = GetTeamForPlayer(id);

            var viewModel = new ViewModels.ShowPlayerViewModel();
            viewModel.Id = player.Id;
            viewModel.Name = player.Firstname + " " + player.Lastname;
            var position = "";
            if (player.Position == "G")
                position = "Målvakt";
            if (player.Position == "D")
                position = "Back";
            if (player.Position == "O")
                position = "Forward";

            viewModel.PositionInCleartext = position;
            viewModel.Salary = player.Salary;

            viewModel.TeamName = team.Namn;
            viewModel.TeamId = team.Id;

            return View(viewModel);
        }

        public ActionResult Team(int id)
        {
            var team = GetTeamFromDatabase(id);
            return View(team);
        }


        public Team GetTeamForPlayer(int playerId)
        {
            for (var t = 1; t <= 3; t++)
            {
                var team = GetTeamFromDatabase(t);
                var p = team.Players.FirstOrDefault(x => x.Id == playerId);
                if (p != null) return team;
            }
            return null;

        }


        private Team GetTeamFromDatabase(int id)
        {
            var t = new Team();
            t.Id = id;
            if (id == 1)
            {
                t.Namn = "Djurgården";
                t.Players.Add(new Player {
                    Id = 13, Firstname = "Mats",
                    Lastname = "Sundin", Position = "O",
                    Salary = 20000});
                t.Players.Add(new Player { Id = 14, Firstname="Håkan", Lastname="Södergren",
                    Position = "O",
                    Salary = 2000
                });
                return t;
            }
            if (id == 2)
            {
                t.Namn = "AIK";
                t.Players.Add(new Player { Id = 1, Firstname = "Mats", Lastname = "Alba",
                    Position = "D",
                    Salary = 5000
                });
                t.Players.Add(new Player { Id = 4, Firstname = "Per-Erik", Lastname = "Eklund",
                    Position = "O",
                    Salary = 12000
                });
                return t;
            }
            if (id == 3)
            {
                t.Namn = "Hammarby";
                t.Players.Add(new Player { Id = 111, Firstname = "Marre", Lastname = "Czerkawski",
                    Position = "O",
                    Salary = 20000
                });
                t.Players.Add(new Player { Id = 114, Firstname = "Karl", Lastname = "Karlsson",
                    Position = "G",
                    Salary = 1000
                });
                t.Players.Add(new Player { Id = 113, Firstname = "Per", Lastname = "Persson",
                    Position = "D",
                    Salary = 300
                });
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