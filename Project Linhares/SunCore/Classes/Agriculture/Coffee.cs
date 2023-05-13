namespace SunCore.Classes.Agriculture
{
    public class Coffee : Agriculture
    {
        public virtual int Plantation { get; set; }
        public virtual int Flowering { get; set; }
        public virtual int Harvest { get; set; }
        public virtual int Processing { get; set; }
        public virtual int Drying { get; set; }
        public virtual int Roasting { get; set; }
        public virtual int Grinding { get; set; }
        public virtual int Classification { get; set; }
        public virtual int Packing { get; set; }
        public virtual int Boxing { get; set; }
    }
}
