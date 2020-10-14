using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_TryCath.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TratamentoBlockTryCatch()
        {
            try
            {
                throw new Exception("Erro capturado em um bloco try...cath");
            }
            catch (Exception e)
            {
                return View("Error",new HandleErrorInfo(e,"Home", "TratamentoBlockTryCatch"));
            }
        }

        public ActionResult TratamentoErroHttp()
        {
            return RedirectToAction("Teste");
        }
    }
}