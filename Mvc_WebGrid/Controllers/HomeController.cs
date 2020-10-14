using Mvc_WebGrid.Models;
using System.Web.Mvc;

namespace Mvc_WebGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Campeonato Paulista - 2020";
            var model = Times.getTimes();
            return View(model);
        }

       
    }
}