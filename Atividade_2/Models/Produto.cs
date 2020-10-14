using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade_2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo nome deve ser preenchido")]
        [Display(Name="Informe o nome do Produto")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="O nome do produto só pode ser aceito se tiver no minimo 5 e no maximo 50 caracteres")]
        [Remote("ValidaProdutoDuplicado","Produto",ErrorMessage ="Nome de produto já existe na base de dados")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="O campo descricao deve ser preenchido")]
        [StringLength(50,MinimumLength =5,ErrorMessage = "A descrição do produto só pode ser aceito se tiver no minimo 5 e no maximo 50 caracteres")]
        public string Descricao { get; set; }
        [Range(2,10,ErrorMessage ="O valor maximo é de 2  a 10")]
        [Required]
        public int Estoque { get; set; }
    }
}