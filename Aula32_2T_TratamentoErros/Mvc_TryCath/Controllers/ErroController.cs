﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_TryCath.Controllers
{
    public class ErroController : Controller
    {
        // GET: Erro
        public ActionResult Erro404()
        {
            return View();
        }
    }
}