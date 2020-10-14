using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_ViewModel.Models
{
    public class Usuario
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email do usuário")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Senha de acesso")]
        public string Senha { get; set; }

        
        //public string Login { get; set; }
        //[DataType(DataType.Password)]
        //public string NovaSenha { get; set; }
        //[DataType(DataType.Password)]
        //public string ConfirmaSenha { get; set; }
    }
}