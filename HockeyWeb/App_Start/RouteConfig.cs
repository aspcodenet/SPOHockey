﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HockeyWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "medPageNum",
                url: "articles/show/{pageNum}",
                defaults: new { controller = "Articles", action = "Show"}
            );

            //routes.MapRoute(
            //    name: "Article",
            //    url: "Articles/Show/{pageNum}",
            //    defaults: new { controller = "Articles",
            //        action = "Show", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
