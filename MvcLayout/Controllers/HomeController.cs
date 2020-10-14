using MvcLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Titulo"] = "Pagina de index do site";

            Produto produto = new Produto()
            {
                Nome="Smartphone Sansung Galaxy S5",
                Preco = 1999.00M
            };

            return View(produto);
        }

        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Pagina de sobre so site";
            return View();
        }
    }
}