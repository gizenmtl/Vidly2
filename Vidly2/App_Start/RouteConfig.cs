using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();


            //filmin tarihlere göre rotalanması
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //     new { controller = "Movies", action="ByReleaseDate" },
            //     new {year = @"\d{4}", month=@"\d{2}"} //rotada yıl için 4 karakter, ay için de 2 karakter şartı koydum, eğer bu şekilde yazılmazsa 404 hatası basar.
            //     //new {year = @"2015 | 2016", month=@"\d{2}"} 
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
