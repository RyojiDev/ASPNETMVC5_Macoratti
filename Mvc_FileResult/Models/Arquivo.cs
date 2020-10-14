using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc_FileResult.Models
{
    public class Arquivo
    {
        public int Id { get; set; }

        [Display(Name="Nome")]
        public string ArquivoNome { get; set; }
        public string ArquivoCaminho { get; set; }
    }
}