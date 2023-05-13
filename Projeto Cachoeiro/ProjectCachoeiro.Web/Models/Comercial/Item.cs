using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Comercial
{
    public class Item : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Display(Name = "Observações")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "As observações não podem possuir mais de 1000 caracteres")]
        public string Observacao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValorComDesconto { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [Required]
        public int IdProposta { get; set; }

        public Item()
        {

        }
        
    }
}
