using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aula_07_EX.CursoAspNetMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           /* routes.MapRoute(
                name: "Index",
                url:"{controller}/{action}/{nome}/{atividade}/{curso}",
                defaults: new {controller="Home", action = "Index", nome = UrlParameter.Optional, atividade = UrlParameter.Optional , curso = UrlParameter.Optional}
                );*/

        }
    }
}
