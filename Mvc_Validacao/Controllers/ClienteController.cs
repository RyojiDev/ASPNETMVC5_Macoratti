using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Validacao.Models;

namespace Mvc_Validacao.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            //Validação do lado do servidor
            //if (string.IsNullOrEmpty(cliente.Nome))
            //    ModelState.AddModelError("Nome", "O nome é obrigatorio");

            //if (string.IsNullOrEmpty(cliente.Email))
            //    ModelState.AddModelError("Email", "O email é obrigatorio");

            //if (string.IsNullOrEmpty(cliente.Telefone))
            //    ModelState.AddModelError("Telefone", "Otelefone é obrigatorio");

            //if (cliente.Idade == 0)
            //{
            //    ModelState.AddModelError("Idade", "Idade é obrigatoria");
            //}
            //else
            //{
            //    if (cliente.Idade >= 21)
            //    {
            //        ModelState.AddModelError("Idade", "A idade informada tem que ser maior que 21 anos");
            //    }
            //}

            // a validação falhou ?
            if (!ModelState.IsValid)
            {
                //sim falhou
                return View(cliente);
            }
            else
            {
                // se ta tudo ok
                return View("Validacao",cliente);
            }

            
        }

        public ActionResult Validacao(Cliente cliente)
        {
            return View(cliente);
        }

        public  ActionResult ValidaEmailDisponivel(string email)
        {
            List<string> emailIndisponivel = new List<string>()
            {
                "ryojikitanoneto@hotmail.com",
                "teste@teste.com.br",
                "ryojikitanodev@gmail.com"
            };
            //se o email não existir na lista então retorna true
            //caso contrario retorna false
            return Json(emailIndisponivel.All(emailIn => emailIn.ToString().ToLower() != email), JsonRequestBehavior.AllowGet);
        }
    }
}