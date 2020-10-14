using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using Elmah;

namespace Mvc_ELMAH.Filtros
{
    public class ElmahHandleErrorFilter : IExceptionFilter
    {
        public void OnException (ExceptionContext context)
        {
            if (context.ExceptionHandled)
            {
                ErrorSignal.FromCurrentContext().Raise(context.Exception);
            }
        }
    }
}