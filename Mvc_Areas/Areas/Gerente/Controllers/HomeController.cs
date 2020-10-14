using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Areas.Areas.Gerente.Controllers
{
    public class HomeController : Controller
    {
        // GET: Gerente/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}