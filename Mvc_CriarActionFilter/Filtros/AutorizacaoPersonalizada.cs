using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_CriarActionFilter.Filtros
{
    public class AutorizacaoPersonalizada : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.MensagemAutorizacaoPersonalizada =
                 "Autorização customizada -> Método OnAuthorization ";
            filterContext.Controller.ViewBag.NomeAction = "Nome da Action ==>"
                + filterContext.ActionDescriptor.ActionName.ToString();
        }
    }
}