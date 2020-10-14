using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_JsonResult.Models;

namespace Mvc_JsonResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetEstados()
        {
            List<Estados> oEstados = new List<Estados>(Estados.GetEstados());
            return Json(oEstados);
        }
    }
}