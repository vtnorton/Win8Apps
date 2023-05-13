using ProjectCachoeiro.Web.Models.Utilitarios;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class Espessura : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Expessura { get; set; }
        public string Nome { get; set; }
    }
}