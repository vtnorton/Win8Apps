using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eleicao
{
    public class Item
    {
        public string Id { get; set; }
        public string VotosNulos { get; set; }
        public string PorcentagemVotosNulos { get; set; }
        public string VotosBrancos { get; set; }
        public string PorcentagemVotosBrancos { get; set; }
        public string VotosAecio { get; set; }
        public string PorcentagemVotosAecio { get; set; }
        public string VotosDilma { get; set; }
        public string PorcentagemVotosDilma { get; set; }
        public string PorcentagemVotosApurados { get; set; }
    }
}