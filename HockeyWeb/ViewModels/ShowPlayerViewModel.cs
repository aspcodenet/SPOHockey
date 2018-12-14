using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyWeb.ViewModels
{
    public class ShowPlayerViewModel
    {
        public string PositionInCleartext { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int TeamId { get; set; }
    }
}