using E2014Classes.Objetos;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes.Mapeamento
{
    public class VotosMap : ClassMap<Votos>
    {
        public VotosMap()
        {
            Id(c => c.ID);
            Map(c => c.eleitoradoApurado);
            Map(c => c.secoesTotalizadas);
            Map(c => c.TotaldeVotos);
            Map(c => c.UltimaAtualizacao);
            Map(c => c.VotosBrancos);
            Map(c => c.VotosNulos);
            Map(c => c.VotosPendentes);
            Table("tbl_votos");
        }
    }
}
