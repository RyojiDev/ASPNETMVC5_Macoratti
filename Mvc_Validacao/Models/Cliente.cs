using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc_Validacao.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O nome deve ter no minimo 5 caracteres e no maximo 50")]
        [Display(Name = "Informe o nome do cliente")]
        public string Nome { get; set; }

        [Remote("ValidaEmailDisponivel","Cliente",ErrorMessage ="Email já cadastrado")]
        [Required(ErrorMessage ="O email deve ser informado")]
        [EmailAddress(ErrorMessage ="Informe um email valido")]
        public string Email { get; set; }
        [StringLength(10,MinimumLength = 6,ErrorMessage = "O telefone deve ter no minimo 6 caracteres")]
        public string Telefone { get; set; }
        [Required(ErrorMessage ="a idade é necessaria")]
        [Range(21,65,ErrorMessage ="A idade deve ser maior que 21 e menor que 65.")]
        public int Idade { get; set; }
    }
}