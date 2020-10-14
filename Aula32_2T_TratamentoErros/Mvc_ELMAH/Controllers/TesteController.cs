using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ELMAH.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        // GET: Empty
        [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Erro Exception :: atributo [handleError]");
        }

        [HandleError(ExceptionType = typeof(InvalidOperationException), View ="ErrorInvalidOperation")]
        [HandleError(ExceptionType = typeof(HttpException),View = "ErrorHttpException")]
        public ActionResult ErroHttpErros()
        {
            if (new Random().Next(1, 2) == 1)
            {
                throw new HttpException("Erro de HttpException Customizado");
            }
            else
            {
                throw new InvalidOperationException("Erro de invalidaOperactionexception Customizado");
            }
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivisaoPorZero")]
        public ActionResult DivisaoPorZero()
        {
            throw new DivideByZeroException("Não existe divisão por zero... :: FilterConfig");
        }

        [HandleError]
        public ActionResult TesteErroGlobal()
        {
            throw new NotSupportedException("Erro Not SupportedException :: FilterConfig");
        }
    }
}