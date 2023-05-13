using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Classes
{
    public class TipoConquista
    {
        public int ID { get; set; }
        public int Pontos { get; set; }
        public string ImageBadge { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string RegrasDeNegocio { get; set; }
        public DateTime DataPostagem { get; set; }

    }
}
