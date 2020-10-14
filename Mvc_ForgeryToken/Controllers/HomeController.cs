using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ForgeryToken.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Transferir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Transferir")]
        public ContentResult ConfirmarTransferencia()
        {
            // a logica da transferencia
            return Content(Request.Form["Valor"] +
                " foi transferido da conta "
                + Request.Form["Conta"]);
        }
    }
}