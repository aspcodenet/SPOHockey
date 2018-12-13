﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyWeb.Models
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Namn { get; set; }
        public List<Player> Players { get; set; }
    }
}