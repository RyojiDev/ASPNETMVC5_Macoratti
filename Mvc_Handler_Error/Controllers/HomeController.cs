using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Handler_Error.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HandleError]
        public ActionResult Index()
        {
            throw new Exception("chii deu pau na action Index");
            return View();
        }

        public ActionResult Sobre()
        {
            throw new Exception("chii deu pau na action Index");
            return View();
        }

    }
}