using AllVtnorton;
using FluentNHibernate.Mapping;
using BSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Mapping
{
    public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap()
        {
            Id(c => c.Id);
            Map(c => c.Birthday);
            Map(c => c.Description);
            Map(c => c.Email);
            Map(c => c.Name);
            Map(c => c.Job);
            Map(c => c.URL);
            Map(c => c.URLCover);                        
            Map(c => c.URLProfile);
            Map(c => c.Password);
            Table(TableNames.Author);
        }
    }
}
