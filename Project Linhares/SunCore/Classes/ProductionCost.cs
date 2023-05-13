namespace SunCore.Classes
{
    public class ProductionCost
    {
        public virtual int Id { get; set; }
        public virtual int IdFarm { get; set; }
        public virtual decimal Fertilizer { get; set; }//Adubo
        public virtual decimal MicroNutrients { get; set; } //Micro-nutrientes
        public virtual decimal Herbicide { get; set; }//Herbicida
        public virtual decimal Fungicide { get; set; }//Fungicide
        public virtual decimal Insecticide { get; set; }//Inseticida
        public virtual decimal Manure { get; set; }//Esterco
        public virtual decimal Fuel { get; set; }//Combustivel
        public virtual decimal Lubricant { get; set; } //Lubrificante
        public virtual decimal CleaningEquipament { get; set; } //Material de limpeza
        public virtual decimal Tools { get; set; }//Ferramentas
        public virtual decimal Accessories { get; set; }//Peças e acessórios
        public virtual decimal Others { get; set; } //Outros
        public virtual decimal Employee { get; set; }//Funcionários
        public virtual decimal TempEmployee { get; set; }//Funcionários temporários
        public virtual decimal Overtime { get; set; }//Horas extras
        public virtual decimal Eletricity { get; set; }//Eletricidade
        public virtual decimal MachineMaintenance { get; set; }//Manutenção da máquina
        public virtual decimal PublicTransport { get; set; }//Transporte público
        public virtual decimal ThirdpartyTransport { get; set; }//Transporte de terceiros
        public virtual decimal ServicesOthers { get; set; }//Outros de serviços
        public virtual decimal TotalServices { get; set; }
        public virtual decimal TotalCompras { get; set; }
        public virtual decimal TotalCost { get; set; }//Custo total
        public virtual string Description { get; set; } //Max: 1240
        public virtual string Username { get; set; } //Who made this //Max: 50
        public virtual string TimeOfPost { get; set; }
        public virtual string MonthOfReference { get; set; }

    }
}
