using FluentNHibernate.Mapping;
using SunCore.Classes.UserAgriculture;

namespace SunCore.Mapping.UserAgriculture
{
    public class UserCoffeeMap : ClassMap<UserCoffee>
    {
        public UserCoffeeMap()
        {
            Id(c => c.Id);
            Map(c => c.AfterBoxing);
            Map(c => c.AfterClassification);
            Map(c => c.AfterDrying);
            Map(c => c.AfterFlowering);
            Map(c => c.AfterGrinding);
            Map(c => c.AfterHarvest);
            Map(c => c.AfterPacking);
            Map(c => c.AfterPlantation);
            Map(c => c.AfterProcessing);
            Map(c => c.AfterRoasting);
            Map(c => c.BeginningOfBoxing);
            Map(c => c.BeginningOfClassification);
            Map(c => c.BeginningOfDrying);
            Map(c => c.BeginningOfFlowering);
            Map(c => c.BeginningOfGrinding);
            Map(c => c.BeginningOfHarvest);
            Map(c => c.BeginningOfPacking);
            Map(c => c.BeginningOfPlantation);
            Map(c => c.BeginningOfProcessing);
            Map(c => c.BeginningOfRoasting);
            Map(c => c.Boxing);
            Map(c => c.Classification);
            Map(c => c.Drying);
            Map(c => c.Flowering);
            Map(c => c.Grinding);
            Map(c => c.Harvest);
            Map(c => c.IdCoffee);
            Map(c => c.IdFarm);
            Map(c => c.IsHarvest);
            Map(c => c.Name);
            Map(c => c.Packing);
            Map(c => c.Plantation);
            Map(c => c.Processing);
            Map(c => c.Roasting);
            Table(TableNames.UserCoffee);
        }
    }
}
