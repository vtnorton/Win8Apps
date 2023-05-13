using ProjectCachoeiro.Web.Exceptions;
using ProjectCachoeiro.Web.Models.Utilitarios;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProjectCachoeiro.Web.Comercial
{
    public class GrupoDeClientes : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Nome do grupo")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "O nome do grupo não pode possuir mais de 50 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "A descrição não pode possuir mais de 1000 caracteres")]
        public string Descricao { get; set; }
        
        public GrupoDeClientes()
        {

        }
        
    }
}
