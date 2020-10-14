using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Atividade_2.Models;

namespace Atividade_2.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index(Produto produto)
        {
            if (ModelState.IsValid)
            {
                return View("Validacao", produto);
            }
            return View(produto);
        }

        public ActionResult Validacao()
        {
            return View();
        }

        public ActionResult ValidaProdutoDuplicado(Produto produto)
        {
            List<string> produtos = new List<string>()
            {
                "Computador",
                "Impressora",
                "Notebook"
            };

            return Json(produtos.All(p => p.ToString().ToLower() != produto.Nome.ToLower()),JsonRequestBehavior.AllowGet);
        }
    }
}