using ProjectCachoeiro.Web.Models.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class BundleItem : LogEntity
    {
        public int Id { get; set; }
        public int IdBundle { get; set; }
        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
    }
}
