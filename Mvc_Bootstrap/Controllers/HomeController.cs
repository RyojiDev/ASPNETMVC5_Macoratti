using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Paises = new List<string>()
            {
                "Brasil",
                "Equador",
                "Canada",
                "Peru",
                "Mexico"
            };
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Pagina Sobre";
            return View();
        }
    }
}