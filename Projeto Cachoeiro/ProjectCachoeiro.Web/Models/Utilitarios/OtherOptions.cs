namespace ProjectCachoeiro.Web.Models.Utilitarios
{
    public class OtherOptions
    {
        public string Descricao { get; set; }
        public string FeedbackEChamadoID { get; set; }
        public Links[] OpcoesRelacionadas { get; set; }
    }

    public class Links
    {
        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}
