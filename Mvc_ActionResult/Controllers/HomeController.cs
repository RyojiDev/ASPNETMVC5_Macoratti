using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ActionResult.Models;

namespace Mvc_ActionResult.Controllers
{
    public class HomeController : Controller
    {
        List<Produto> produtos = new List<Produto>()
        {
            new Produto()
            {
                 Id=1,
                 Nome="Celular",
                 Descricao="Smartphone do ano"
            }
        };
        // GET: Home
        public ViewResult Index()
        {
            return View(produtos);
        }

        public PartialViewResult Menu()
        {
            return PartialView("~/Views/Shared/_Menu.cshtml");
        }

        public ActionResult Redireciona()
        {
            return RedirectToAction("Aviso", new { aviso = "Redirefct To Action :: Index" });
        }

        public ViewResult Aviso(string aviso)
        {
            ViewBag.Aviso = aviso;
            return View();
        }
    }
}