using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_FilterChildActionOnly.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Titulo = "Action Index()";
            return View();
        }

        [Authorize]
        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Action Sobre()";
            return View();
        }

        [ChildActionOnly]
        public ActionResult Produtos(List<string> NomesProdutos)
        {
            return View(NomesProdutos);
        }
    }
}