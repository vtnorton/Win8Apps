using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes.Objetos
{
    public class Votos
    {
        public virtual int ID { get; set; }
        public virtual DateTime UltimaAtualizacao { get; set; }
        public virtual int VotosNulos { get; set; }
        public virtual int VotosBrancos { get; set; }
        public virtual int TotaldeVotos { get; set; }
        public virtual int secoesTotalizadas { get; set; }
        public virtual int eleitoradoApurado { get; set; }
        public virtual int VotosPendentes { get; set; }
    }
}
