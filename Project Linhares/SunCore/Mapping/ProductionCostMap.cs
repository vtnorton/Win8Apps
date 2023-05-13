using FluentNHibernate.Mapping;
using SunCore;
using SunCore.Classes;

namespace SunCore.Mapping
{
    public class ProductionCostMap : ClassMap<ProductionCost>
    {
        public ProductionCostMap()
        {
            Id(c => c.Id);
            Map(c => c.Accessories);
            Map(c => c.CleaningEquipament);
            Map(c => c.Description);
            Map(c => c.Eletricity);
            Map(c => c.Employee);
            Map(c => c.Fertilizer);
            Map(c => c.Fuel);
            Map(c => c.Fungicide);
            Map(c => c.Herbicide);
            Map(c => c.IdFarm);
            Map(c => c.Insecticide);
            Map(c => c.Lubricant);
            Map(c => c.MachineMaintenance);
            Map(c => c.Manure);
            Map(c => c.MicroNutrients);
            Map(c => c.MonthOfReference);
            Map(c => c.Others);
            Map(c => c.Overtime);
            Map(c => c.PublicTransport);
            Map(c => c.ServicesOthers);
            Map(c => c.TempEmployee);
            Map(c => c.ThirdpartyTransport);
            Map(c => c.TimeOfPost);
            Map(c => c.Tools);
            Map(c => c.TotalCompras);
            Map(c => c.TotalCost);
            Map(c => c.TotalServices);
            Map(c => c.Username);
            Table(TableNames.ProductionCost);
        }
    }
}
