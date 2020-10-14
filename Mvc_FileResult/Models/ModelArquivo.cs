using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Mvc_FileResult.Models
{
    public class ModelArquivo
    {
        public List<Arquivo> GetArquivos()
        {

            List<Arquivo> listaArquivos = new List<Arquivo>();
            DirectoryInfo dirInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/Arquivos"));

            int i = 0;

            foreach (var item in dirInfo.GetFiles())
            {
                listaArquivos.Add(new Arquivo()
                {
                    Id = i + 1,
                    ArquivoNome = item.Name,
                    ArquivoCaminho = dirInfo.FullName + @"\" + item.Name
                }) ;
                i = i + 1;
            }

            return listaArquivos;
        }
    }
}