using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Comercial
{
    public class OpcoesPagamento : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Forma de pagamento")]
        public string Nome { get; set; }
        [Display(Name = "Forma de pagamento (em inglês)")]
        public string NomeEmIngles { get; set; }
        public string NomeNaOmie { get; set; }
        public string Descricao { get; set; }
    }
}
