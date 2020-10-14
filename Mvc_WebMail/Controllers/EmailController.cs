using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Mvc_WebMail.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult EnviarEmail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EnviarEmail(string EmailDestino,string assunto, string mensagem)
        {
            try
            {
                WebMail.SmtpServer = "localhost";
                WebMail.SmtpPort = 25;
                WebMail.EnableSsl = false;
                WebMail.From = "macoratti@yahoo.com";
                //WebMail.UserName = "maccoratti";
                //WebMail.Password = "122345";

                WebMail.Send(to: EmailDestino,
                    subject:assunto,
                    body: mensagem,
                    isBodyHtml: true);
                return RedirectToAction("EmailEnviado");

            }catch(Exception ex)
            {
                ModelState.AddModelError("Erro_Form", ex.Message);
            }
            return View();
        }

        public ActionResult EmailEnviado()
        {
            return View();
        }
    }
}