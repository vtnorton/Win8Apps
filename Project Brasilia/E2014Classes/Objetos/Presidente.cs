using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes.Objetos
{
    public class Presidente
    {
        public virtual int ID { get; set; }
        public virtual int Numero { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Partido { get; set; }
        public virtual int VotosValidos { get; set; }
        public virtual decimal Por { get; set; }
    }
}
