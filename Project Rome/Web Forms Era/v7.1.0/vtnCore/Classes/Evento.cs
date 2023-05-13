namespace vtnCore.Classes
{
    public class Evento
    {
        public virtual int Id { get; set; }
        public virtual int Dia { get; set; }
        public virtual int JaPassou { get; set; }
        public virtual int EhOnline { get; set; }
        public virtual int Ano { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Mes { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string URL { get; set; }
        public virtual string Data { get; set; }
    }
}
