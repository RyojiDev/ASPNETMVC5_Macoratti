using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{

    public class ClienteController : Controller
    {
       
        // GET: Cliente
        public ActionResult Index()
        {
            using (ClienteContext clienteContext = new ClienteContext())
            {
                List<Cliente> clientes = clienteContext.clientes.ToList();
                return View(clientes);
            }
        }

        public ActionResult Detalhes(int id)
        {
           using(ClienteContext clienteContext = new ClienteContext())
            {
                Cliente cliente = clienteContext.clientes.Single(p => p.ClienteId == id);

                return View(cliente);
            }
        }


    }
}