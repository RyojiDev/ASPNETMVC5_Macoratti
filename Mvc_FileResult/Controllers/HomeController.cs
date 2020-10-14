using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_FileResult.Models;

namespace Mvc_FileResult.Controllers
{
    public class HomeController : Controller
    {
        ModelArquivo modelArquivo = new ModelArquivo();
        // GET: Home
        public ActionResult Index()
        {
            List<Arquivo> _arquivos = modelArquivo.GetArquivos();
            return View(_arquivos);
        }

        public FileResult Download(int id)
        {
            List<Arquivo> arquivos = modelArquivo.GetArquivos();
            //string nomeArquivo = arquivos.FirstOrDefault(p => p.Id == id).ArquivoCaminho;
            string nomeArquivo = (from arquivo in arquivos
                                  where arquivo.Id == id
                                  select arquivo.ArquivoCaminho).First();
            string contentType = "text/html";
            return File(nomeArquivo, contentType, "Arquivo.html");
        }
    }
}