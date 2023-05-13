using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Comercial
{
    public class Proposta : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Display(Name = "Numero da proposta")]
        public string Numero { get; set; }

        [Display(Name = "Observações")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "As observações não podem possuir mais de 1000 caracteres")]
        public string Observacoes { get; set; }

        [Display(Name = "Opções de pagamento")]
        public int IdOpcoesDePagamento { get; set; }

        [Required]
        public int IdContato { get; set; }

        [Required]
        public int IdCliente { get; set; }

        public Proposta()
        {

        }
        
    }
}
