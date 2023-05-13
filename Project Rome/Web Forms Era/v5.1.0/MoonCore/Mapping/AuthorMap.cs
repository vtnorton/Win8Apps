using FluentNHibernate.Mapping;
using Core.Shared;
using MoonCore.Classes;

namespace MoonCore.Mapping
{
    public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap()
        {
            Id(c => c.Id);
            Map(c => c.Bio);
            Map(c => c.Email);
            Map(c => c.Name);
            Map(c => c.URLProfile);
            Map(c => c.Password);
            Table(TableNames.Author);
        }
    }
}
