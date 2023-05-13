using AllVtnorton;
using BSharp.Classes;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Mapping
{
    public class ChapterMap : ClassMap<Chapter>
    {
        public ChapterMap()
        {
            Id(c => c.Id);
            Map(c => c.AuthorName);
            Map(c => c.Content);
            Map(c => c.IdAuthor);
            Map(c => c.IdSeason);
            Map(c => c.PostedOn);
            Map(c => c.Title);
            Map(c => c.UpdatedOn);
            Table(TableNames.Chapter);
        }
    }
}
