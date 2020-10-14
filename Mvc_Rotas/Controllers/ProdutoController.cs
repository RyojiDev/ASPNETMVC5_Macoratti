using Mvc_Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Rotas.Controllers
{
    public class ProdutoController : Controller
    {
        private List<Produto> todosProdutos;
        public ProdutoController()
        {
            todosProdutos = new Produto().TodosProdutos().OrderBy(p => p.Preco).ToList();
        }
        // GET: Produto
        public ActionResult Index()
        {
            ViewBag.Produtos = "Todos os produtos";

            return View(todosProdutos);
        }

        public ActionResult Detalhes(int produtoid)
        {
            return View(todosProdutos.FirstOrDefault(p=>p.ProdutoId == produtoid));
        }

        public ActionResult Categorias(string categoria)
        {
            List<Produto> _categoria = todosProdutos.Where(x => x.Categoria == categoria).ToList();
            ViewBag.Categoria = categoria;

            return View(_categoria);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}