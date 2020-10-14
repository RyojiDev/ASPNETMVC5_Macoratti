using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_CriarActionFilter.Filtros;

namespace Mvc_CriarActionFilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [LogExecucao]
        public string Index()
        {
            return "Metodo Action Index)() foi invocado...";
        }

        [LogExecucao]
        public string Sobre()
        {
            return "Método Action Sobre() foi invocado";
        }

        [AutorizacaoPersonalizada]
        [LogExecucao]
        public ActionResult Mensagem()
        {
            return View();
        }
    }
}