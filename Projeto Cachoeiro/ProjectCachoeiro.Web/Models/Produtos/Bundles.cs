using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class Bundles : LogEntity
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public int Codigo { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }
    }
}
