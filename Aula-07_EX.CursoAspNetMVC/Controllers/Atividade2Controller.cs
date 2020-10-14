using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_07_EX.CursoAspNetMVC.Controllers
{
    public class Atividade2Controller : Controller
    {
        // GET: Atividade2
        public ActionResult Index(string nome,string atividade, string curso)
        {
            ViewData["Nome"] = nome;
            ViewBag.Atividade = atividade;
            ViewBag.Curso = curso;


            return View();
        }
    }
}