using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Chapter
    {
        public virtual int Id { get; set; }
        public virtual int IdSeason { get; set; }
        public virtual int IdAuthor { get; set; }
        public virtual String AuthorName { get; set; }
        public virtual String Title { get; set; }
        public virtual String Content { get; set; }
        public virtual String PostedOn { get; set; }
        public virtual String UpdatedOn { get; set; }
    }
}
