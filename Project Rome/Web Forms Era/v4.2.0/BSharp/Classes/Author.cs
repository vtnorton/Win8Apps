using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Author
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String URLProfile { get; set; }
        public virtual String URLCover { get; set; }
        public virtual String Birthday { get; set; }
        public virtual String Job { get; set; }
        public virtual String Email { get; set; }
        public virtual String URL { get; set; }
        public virtual String Password { get; set; }
        
    }
}
