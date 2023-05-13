using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes.Objetos
{
    public class Votacao
    {
        public virtual string ID { get; set; }
        public virtual string VotosNulos { get; set; }
        public virtual string PorcentagemVotosNulos { get; set; }
        public virtual string VotosBrancos { get; set; }
        public virtual string PorcentagemVotosBrancos { get; set; }
        public virtual string VotosAecio { get; set; }
        public virtual string PorcentagemVotosAecio { get; set; }
        public virtual string VotosDilma { get; set; }
        public virtual string PorcentagemVotosDilma { get; set; }
        public virtual string PorcentagemVotosApurados { get; set; }
    }
}
