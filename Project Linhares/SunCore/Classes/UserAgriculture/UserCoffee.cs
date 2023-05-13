namespace SunCore.Classes.UserAgriculture
{
    public class UserCoffee: UserAgriculture
    {
        public virtual int IdCoffee { get; set; }
        public virtual int Plantation { get; set; }
        public virtual string BeginningOfPlantation { get; set; }
        public virtual string AfterPlantation { get; set; }
        public virtual int Flowering { get; set; }
        public virtual string BeginningOfFlowering { get; set; }
        public virtual string AfterFlowering { get; set; }
        public virtual int Harvest { get; set; }
        public virtual string BeginningOfHarvest { get; set; }
        public virtual string AfterHarvest { get; set; }
        public virtual int Processing { get; set; }
        public virtual string BeginningOfProcessing { get; set; }
        public virtual string AfterProcessing { get; set; }
        public virtual int Drying { get; set; }
        public virtual string BeginningOfDrying { get; set; }
        public virtual string AfterDrying { get; set; }
        public virtual int Roasting { get; set; }
        public virtual string BeginningOfRoasting { get; set; }
        public virtual string AfterRoasting { get; set; }
        public virtual int Grinding { get; set; }
        public virtual string BeginningOfGrinding { get; set; }
        public virtual string AfterGrinding { get; set; }
        public virtual int Classification { get; set; }
        public virtual string BeginningOfClassification { get; set; }
        public virtual string AfterClassification { get; set; }
        public virtual int Packing { get; set; }
        public virtual string BeginningOfPacking { get; set; }
        public virtual string AfterPacking { get; set; }
        public virtual int Boxing { get; set; }
        public virtual string BeginningOfBoxing { get; set; }
        public virtual string AfterBoxing { get; set; }
        
    }
}
