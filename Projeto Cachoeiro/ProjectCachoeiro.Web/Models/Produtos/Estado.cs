using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class Estado : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Nome do status")]
        [StringLength(50, ErrorMessage = "O título do status não pode ser maior do que 50 caracteres")]
        public string Nome { get; set; }

        [Required]
        public string Sigla { get; set; }

        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "A descrição não pode possuir mais de 1000 caracteres")]
        public string Descricao { get; set; }
        
        public Estado()
        {

        }
        
    }
}
