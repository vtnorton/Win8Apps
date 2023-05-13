using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Classes
{
    public class ComentarioHistorico
    {
        public int ID { get; set; }
        public int IDComentario { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataDePostagem { get; set; }
    }
}
