using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Classes
{
    public class Comentario
    {
        public int ID { get; set; }
        public int IDFeedback { get; set; }
        public int IdAutor { get; set; }
        public int IdGaleria { get; set; }
        public int IdComentario { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public bool PostagemOficial { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataDePostagem { get; set; }
    }
}
