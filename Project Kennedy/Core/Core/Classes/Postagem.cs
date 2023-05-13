using System;

namespace Core.Classes
{
    public class Postagem
    {
        public int Id { get; set; }

        public int IdAutor { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPostagem { get; set; }
        public DateTime DataAutalizacao { get; set; }
    }
}
