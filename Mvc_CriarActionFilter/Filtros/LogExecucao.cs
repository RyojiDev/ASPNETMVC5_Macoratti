using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_CriarActionFilter.Filtros
{
    public class LogExecucao : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string msgLog = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " -->" + filterContext.ActionDescriptor.ActionName + " em OnActionExecuting \t : "
               + DateTime.Now.ToString() + "\n";
            LogarHoraExecucao(msgLog);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string msgLog = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " -->" + filterContext.ActionDescriptor.ActionName + " em OnActionExecuted \t : "
                + DateTime.Now.ToString() + "\n";
            LogarHoraExecucao(msgLog);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string msgLog = "\n" + filterContext.RouteData.Values["controller"] + " -->" + filterContext.RouteData.Values["controller"] + " em OnResultedExecuted \t : "
               + DateTime.Now.ToString() + "\n";
            LogarHoraExecucao(msgLog);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string msgLog = "\n" + filterContext.RouteData.Values["controller"] + " -->" + filterContext.RouteData.Values["controller"] + " em OnResultnExecuting \t : "
                + DateTime.Now.ToString() + "\n";
            LogarHoraExecucao(msgLog);
        }

        private void LogarHoraExecucao(string dados)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Log/LogDados.txt"), dados);
        }
    }
}