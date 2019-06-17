using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "login/",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Menu",
                url: "menu/",
                defaults: new { controller = "Menu", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Anulaciones",
                url: "anulaciones/",
                defaults: new { controller = "MenuAnulaciones", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Envios",
                url: "envios/",
                defaults: new { controller = "MenuEnvios", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
