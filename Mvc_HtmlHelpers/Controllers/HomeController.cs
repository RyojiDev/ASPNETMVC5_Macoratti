using Mvc_HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_HtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Personalidade> personalidades = new List<Personalidade>()
            {
                new Personalidade{PersonalidadeId=1, PersonalidadeNome="Robert Plant", PersonalidadeFoto=@"~\Fotos\robert.jpg"},
                new Personalidade{PersonalidadeId=1, PersonalidadeNome="Mahtama Ghandi", PersonalidadeFoto=@"~\Fotos\robert.jpg"},
                new Personalidade{PersonalidadeId=1, PersonalidadeNome="Janis Joplin", PersonalidadeFoto=@"~\Fotos\robert.jpg"},
                new Personalidade{PersonalidadeId=1, PersonalidadeNome="Luffy", PersonalidadeFoto=@"~\Fotos\luffy.jpg"}
            };
            return View(personalidades);
        }
    }
}