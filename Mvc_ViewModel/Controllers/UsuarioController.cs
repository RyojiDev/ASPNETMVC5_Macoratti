using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ViewModel.Models;
using Mvc_ViewModel.ViewModel;

namespace Mvc_ViewModel.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AlterarSenha()
        {
            // Usuario usuario = new Usuario();
            AlterarSenhaViewModel usuario = new AlterarSenhaViewModel();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult AlterarSenha(AlterarSenhaViewModel usuario)
        {
            //validar o Model
            //Persistir os dados
            return View(usuario);
        }
    }
}