using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            foreach(string chave in formCollection)
            {
                Response.Write("Chave = " + chave + " ");
                Response.Write("Valor =" + formCollection[chave]);
                Response.Write("<br/>");
            }
            return View();
        }

        public void Salvar(FormCollection form1)
        {
            using(ClienteContext context = new ClienteContext()) {
              

                Cliente cliente = new Cliente()
                {
                 Nome = form1["nome"],
                 Email = form1["email"],
                 Telefone = form1["telefone"]

                };


                context.clientes.Add(cliente);
                context.SaveChanges();
            }

        }
    }
}