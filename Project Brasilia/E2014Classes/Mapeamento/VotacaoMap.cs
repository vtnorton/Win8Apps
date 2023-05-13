using E2014Classes.Objetos;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes.Mapeamento
{
    public class VotacaoMap : ClassMap<Votacao>
    {
        public VotacaoMap()
        {
            Id(c => c.ID);
            Map(c => c.PorcentagemVotosAecio);
            Map(c => c.PorcentagemVotosApurados);
            Map(c => c.PorcentagemVotosBrancos);
            Map(c => c.PorcentagemVotosDilma);
            Map(c => c.PorcentagemVotosNulos);
            Map(c => c.VotosAecio);
            Map(c => c.VotosBrancos);
            Map(c => c.VotosDilma);
            Map(c => c.VotosNulos);
            Table("eleicao2014wpjs.Item");
        }
    }
}
