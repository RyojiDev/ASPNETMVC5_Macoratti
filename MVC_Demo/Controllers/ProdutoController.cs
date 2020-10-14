using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Produtos()
        {
            Produto produto = new Produto()
            {
                Id = 1,
                Nome = "Computador",
                Descricao = "Um otimo computador"
            };

            return View(produto);
        }
    }
}