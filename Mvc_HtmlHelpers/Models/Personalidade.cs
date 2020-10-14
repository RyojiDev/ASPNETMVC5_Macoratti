using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc_HtmlHelpers.Models
{
    public class Personalidade
    {
        [Display(Name="Código")]
        public int PersonalidadeId { get; set; }
        [Display(Name="Nome")]
        public string PersonalidadeNome { get; set; }
        [Display(Name="Foto")]
        public string PersonalidadeFoto { get; set; }
    }
}