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
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(c => c.Id);
            Map(c => c.IdAuthor);
            Map(c => c.IdCategory);
            Map(c => c.Online);
            Map(c => c.Content).Length(int.MaxValue);
            Map(c => c.PostedDate);
            Map(c => c.Title);
            Map(c => c.UpdatedDate);
            Map(c => c.URL);
            Map(c => c.FirstParagraph);
            Map(c => c.URLImage);
            Map(c => c.AuthorName);
            Map(c => c.CategoryName);
            Table(TableNames.Post);
        }
    }
}
