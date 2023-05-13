using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class ListaEmailsMap : ClassMap<ListaEmails>
    {
        public ListaEmailsMap()
        {
            Id(c => c.Id);
            Map(c => c.Titulo);
            Map(c => c.Descricao);
            Map(c => c.Inscritos);
            Map(c => c.FooterMenssage);
            Table(TableNames.ListaEmails);
        }
    }
}
