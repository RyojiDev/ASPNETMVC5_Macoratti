using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc_Contatos.Models;
using PagedList;

namespace Mvc_Contatos.Controllers
{
    public class ContatoController : Controller
    {
        private CadastroEntities db = new CadastroEntities();

        // GET: Contato
        public ActionResult Index(string procurarPor, string criterio, int? pagina, string ordenarPor)
        {
            ViewBag.OrdenarPorNome = string.IsNullOrEmpty(ordenarPor) ? "Nome desc" : "";
            ViewBag.OrdenarPorSexo = ordenarPor == "Sexo" ? "Sexo desc" : "Sexo";

            var contatos = db.Contatos.AsQueryable();

            if (procurarPor == "Sexo")
            {
               contatos = contatos.Where(p => p.Sexo == criterio || criterio == null);
            }
            else
            {
                contatos = contatos.Where(p => p.Nome.StartsWith(criterio) || criterio == null);
            }

            switch (ordenarPor)
            {
                case "Nome desc":
                    contatos = contatos.OrderByDescending(p => p.Nome);
                    break;
                case "Sexo desc":
                    contatos = contatos.OrderByDescending(p => p.Sexo);
                    break;
                case "Sexo":
                    contatos = contatos.OrderBy(p => p.Sexo);
                    break;
                default:
                    contatos = contatos.OrderBy(p => p.Nome);
                    break;

            }
            return View(contatos.ToPagedList(pagina ?? 1,5));
        }

        // GET: Contato/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contatos contatos = db.Contatos.Find(id);
            if (contatos == null)
            {
                return HttpNotFound();
            }
            return View(contatos);
        }

        // GET: Contato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contato/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Email,Sexo")] Contatos contatos)
        {
            if (ModelState.IsValid)
            {
                db.Contatos.Add(contatos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contatos);
        }

        // GET: Contato/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contatos contatos = db.Contatos.Find(id);
            if (contatos == null)
            {
                return HttpNotFound();
            }
            return View(contatos);
        }

        // POST: Contato/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Email,Sexo")] Contatos contatos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contatos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contatos);
        }

        // GET: Contato/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contatos contatos = db.Contatos.Find(id);
            if (contatos == null)
            {
                return HttpNotFound();
            }
            return View(contatos);
        }

        // POST: Contato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contatos contatos = db.Contatos.Find(id);
            db.Contatos.Remove(contatos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
