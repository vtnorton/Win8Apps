using ProjectCachoeiro.Web.Models.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class Cor : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
