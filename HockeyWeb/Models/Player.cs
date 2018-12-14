using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyWeb.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Salary { get; set; }
        // Position varchar[1]
        // G - Goalie
        // D - Defence
        // O - Offense
        public string Position { get; set; }
    }
}