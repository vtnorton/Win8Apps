using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Classes
{
    public class Foto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Link { get; set; }
        public DateTime DataPostagem { get; set; }
    }
}
