using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class EventoMap : ClassMap<Evento>
    {
        public EventoMap()
        {
            Id(c => c.Id);
            Map(c => c.Ano);
            Map(c => c.Descricao);
            Map(c => c.Dia);
            Map(c => c.EhOnline);
            Map(c => c.Endereco);
            Map(c => c.JaPassou);
            Map(c => c.Mes);
            Map(c => c.Nome);
            Map(c => c.URL);
            Map(c => c.Data);
            Table(TableNames.Evento);
        }
    }
}
