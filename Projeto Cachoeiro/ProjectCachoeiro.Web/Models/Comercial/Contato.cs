using ProjectCachoeiro.Web.Exceptions;
using ProjectCachoeiro.Web.Models.Utilitarios;
using ProjectCachoeiro.Web.Util;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Comercial
{
    public class Contato : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Primeiro nome")]
        [DataType(DataType.Text)]
        [MaxLength(30, ErrorMessage = "O primeiro nome não pode ter mais do que 30 caracteres")]
        public string PrimeiroNome { get; set; }

        [Required]
        [Display(Name = "Último nome")]
        [DataType(DataType.Text)]
        [MaxLength(30, ErrorMessage = "O último nome não pode ter mais do que 30 caracteres")]
        public string UltimoNome { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50, ErrorMessage = "O e-mail não pode ter mais do que 50 caracteres")]
        public string Email { get; set; }

        [Display(Name = "Telefone de contato")]
        public string Telefone { get; set; }

        [Display(Name = "Cargo na empresa")]
        public string Cargo { get; set; }

        [Display(Name = "Empresa")]
        public int IdEmpresa { get; set; }

        [Display(Name = "Observações")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "As observações não podem possuir mais de 1000 caracteres")]
        public string Observacao { get; set; }

        public int IdFotoPerfil { get; set; }
        
        public Contato()
        {

        }
    }
}
