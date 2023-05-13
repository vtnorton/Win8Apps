namespace SunCore.Classes.UserAgriculture
{
    public class UserAgriculture
    {
        public virtual int Id { get; set; }
        public virtual int IdFarm { get; set; }
        public virtual int IsHarvest { get; set; } //Esta colhido? 1 para sim, 0 para não.
        public virtual string Name { get; set; }
    }
}
