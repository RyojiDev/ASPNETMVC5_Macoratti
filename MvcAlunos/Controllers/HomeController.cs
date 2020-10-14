using MvcAlunos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAlunos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            List<Aluno> alunos = new List<Aluno>()
            {
                 new Aluno()
                 {
                     Nome="Jose",
                     Email="jose@gmail.com"
                 },
                 new Aluno()
                 {
                     Nome="Ramires",
                     Email="Ramires@hotmail.com"
                 }
            };
            return View(alunos);
        }

        public ActionResult SobreDadosDoAluno()
        {
            return View();
        }
    }
}