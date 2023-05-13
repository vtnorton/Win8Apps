using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models.Produtos;
using System;
using System.Threading.Tasks;

namespace ProjectCachoeiro.Web.Util
{
    public class Transformacao
    {
        private readonly ApplicationDbContext _context;

        public Transformacao(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CriarTituloAsync(Produto produto, int _familia)
        {
            Familia familia = await _context.Familia.SingleOrDefaultAsync(m => m.Id == _familia);
            Cor cor = await _context.Cor.SingleOrDefaultAsync(m => m.Id == produto.IdCor);
            Material material = await _context.Material.SingleOrDefaultAsync(m => m.Id == produto.IdMaterial);

            string titulo = "";

            if (!string.IsNullOrEmpty(familia.Sigla))
                titulo += familia.Sigla;
            else
                titulo += familia.Nome;

            titulo += " ";

            if (!string.IsNullOrEmpty(cor.Sigla))
                titulo += cor.Sigla;
            else
                titulo += cor.Nome;

            titulo += " " + material.Nome + " " + produto.NumeroBloco;

            return titulo.Trim();
        }
    }
}
