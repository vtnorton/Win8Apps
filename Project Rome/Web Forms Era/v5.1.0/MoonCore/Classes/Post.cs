using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonCore.Classes
{
    public class Post
    {
        public virtual int Id { get; set; }
        public virtual int IdCategory { get; set; }
        public virtual String CategoryName { get; set; }
        public virtual String Title { get; set; }
        public virtual String URL { get; set; }
        public virtual String Content { get; set; }
        public virtual String FirstParagraph { get; set; }
        public virtual String PostedDate { get; set; }
        public virtual String UpdatedDate { get; set; }
        public virtual String URLImage { get; set; }
        public virtual String PostHTML { get; set; }
        public virtual int Visits { get; set; }
    }
}
