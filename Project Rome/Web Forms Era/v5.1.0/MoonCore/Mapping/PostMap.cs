using FluentNHibernate.Mapping;
using Core.Shared;
using MoonCore.Classes;

namespace MoonCore.Mapping
{
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(c => c.Id);
            Map(c => c.IdCategory);
            Map(c => c.Content).Length(int.MaxValue);
            Map(c => c.PostedDate);
            Map(c => c.Title);
            Map(c => c.UpdatedDate);
            Map(c => c.URL);
            Map(c => c.FirstParagraph);
            Map(c => c.URLImage);
            Map(c => c.CategoryName);
            Map(c => c.PostHTML);
            Table(TableNames.Post);
        }
    }
}
