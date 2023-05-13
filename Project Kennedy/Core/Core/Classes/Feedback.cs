namespace Core.Classes
{
    public class Feedback
    {
        public int ID { get; set; }
        public int IdCidade { get; set; }
        public int IdGaleria { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Link { get; set; }
        public string Tipo { get; set; } //Sugestão ou problema
        public string Status { get; set; }
    }
}
