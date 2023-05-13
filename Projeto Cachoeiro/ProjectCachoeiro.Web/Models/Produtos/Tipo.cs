using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class Tipo : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sigla { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
