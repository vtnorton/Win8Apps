namespace SunCore.Classes
{
    public class Farm
    {
        public virtual int Id { get; set; }
        public virtual int Size { get; set; } //Hectares quadrados
        public virtual int Type { get; set; } //Pecuaria, Agrononmia, Ambos
        public virtual int IdCountry { get; set; }
        public virtual int IdRegion { get; set; }
        public virtual string AllowedUsers { get; set; } //Max:300
        public virtual string Name { get; set; } //Max: 50
        public virtual string Owner { get; set; } //Max: 50
        public virtual string Address { get; set; } //Max: 330
        
        
        //Adicionar imagem, descrição
    }
}
