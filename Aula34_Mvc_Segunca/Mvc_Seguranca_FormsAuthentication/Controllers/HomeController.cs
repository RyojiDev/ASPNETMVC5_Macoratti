using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc_Seguranca_FormsAuthentication.Controllers
{
  
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AcessoRestrito()
        {
            return View();
        }

        public ActionResult AcessoLiberado()
        {
            return View();
        }

        public ActionResult AcessoNegado()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(string login,string senha)
        {
            //if (FormsAuthentication.Authenticate(login,senha))
            //{
            //    FormsAuthentication.SetAuthCookie(login, true);
            //    return RedirectToAction("AcessoRestrito");
            //}
            //else
            //{
            //    //FormsAuthentication.SignOut();
            //    return RedirectToAction("AcessoNegado");
            //}
            if(login == "ryoji" && senha == "12345678")
            {
                FormsAuthentication.SetAuthCookie(login, true);
                return RedirectToAction("AcessoLiberado");
            }
            else
            {
                ModelState.AddModelError("", "Login Invalido");
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}