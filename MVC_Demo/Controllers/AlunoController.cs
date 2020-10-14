using Business;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            //criei uma instancia da classe AlunoBUsiness
            AlunoBusiness business = new AlunoBusiness();

            List<AlunoBO> alunos = business.getAlunos().ToList();

            return View(alunos);
        }

        public ActionResult ListaAlunos()
        {
            AlunoBusiness alunoBusiness = new AlunoBusiness();
            List<AlunoBO> alunos = alunoBusiness.getAlunos().ToList();
            return View(alunos);
        }

        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(AlunoBO aluno)
        {


            if (ModelState.IsValid)
            {


                AlunoBusiness alunoBusiness = new AlunoBusiness();
                alunoBusiness.IncluirAluno(aluno);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            
            if(id != null) { 
                AlunoBO aluno = new AlunoBO();
                AlunoBusiness alunoBusiness = new AlunoBusiness();
                aluno = alunoBusiness.getAlunos().Where(p => p.Id == id).FirstOrDefault();
                return View(aluno);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post([Bind(Include = "Id,Idade,DataInscricao,Sexo,Email,Foto,Texto")]AlunoBO aluno)
        {
            AlunoBusiness alunoBusiness = new AlunoBusiness();
            aluno.Nome = alunoBusiness.getAlunos().Single(p => p.Id == aluno.Id).Nome;
            //AlunoBO aluno = alunoBusiness.getAlunos().Single(p => p.Id == id);
            //UpdateModel(aluno, includeProperties: new[] { "Id", "Idade", "Sexo", "DataIncricao" });
            if (ModelState.IsValid)
            {

                alunoBusiness.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Details(int? id)
        {
            if(id != null) { 
            AlunoBusiness alunoBusiness = new AlunoBusiness();
            AlunoBO aluno = alunoBusiness.getAlunos().Single(p => p.Id == id);
            return View(aluno);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Procurar(string procurarPor, string criterio)
        {
            AlunoBusiness alunoBusiness = new AlunoBusiness();
            if (procurarPor == "Nome")
            {
                AlunoBO aluno = alunoBusiness.getAlunos().SingleOrDefault(p => p.Nome == criterio || criterio == null);
                return View(aluno);
            }
            else
            {
                AlunoBO aluno = alunoBusiness.getAlunos().SingleOrDefault(p => p.Email == criterio || criterio == null);
                return View(aluno);
            }

        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            AlunoBusiness alunoBusiness = new AlunoBusiness();
            alunoBusiness.DeletarAluno(id);
            return RedirectToAction("Index");
        }

        /*[HttpPost]
        public ActionResult Delete(AlunoBO aluno)
        {
            if (ModelState.IsValid)
            {
                AlunoBusiness alunoBusiness = new AlunoBusiness();
                alunoBusiness.DeletarAluno(aluno.Id);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }*/


        public ActionResult SalvarAluno()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SalvarAluno(Aluno alunoData)
        {
            if (ModelState.IsValid)
            {
                using (ClienteContext cliente = new ClienteContext())
                {
                    Aluno aluno = new Aluno()
                    {
                        Nome = alunoData.Nome,
                        Idade = alunoData.Idade,
                        Sexo = alunoData.Sexo,
                        DataInscricao = DateTime.Now
                    };

                    cliente.aluno.Add(aluno);
                    cliente.SaveChanges();


                }

            }
            return View();

        }
    }
}