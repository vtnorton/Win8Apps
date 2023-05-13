using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonCore.Classes
{
    public class Author
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; } //Max: 120
        public virtual String Bio { get; set; } //Max: 800
        public virtual String URLProfile { get; set; } //Max: 120
        public virtual String Email { get; set; } //Max: 120
        public virtual String Password { get; set; } //Max: 150
        
    }
}
