using E2014Classes.Objetos;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes.Mapeamento
{
    public class PresidenteMap : ClassMap<Presidente>
    {
            public PresidenteMap()
            {
                Id(c => c.ID);
                Map(c => c.Nome);
                Map(c => c.Numero);
                Map(c => c.Partido);
                Map(c => c.VotosValidos);
                Map(c => c.Por);
                Table("tbl_presitente");
                //Era para ser tbl_presidente, mas como no banco foi digitado errado após todos os dados terem sido cadastrados vai ficar assim, correção virá para o segundo turno.
            }
    }
}
