using SunCore.Classes;
using SunCore.Classes.Agriculture;
using SunCore.Classes.UserAgriculture;
using SunCore.Repository;
using SunCore.Repository.Agriculture;
using SunCore.Repository.UserAgriculture;
using System;
using System.Data.SqlClient;

namespace SunCore.Methods
{
    public class Create
    {
        private SqlConnection conns = new SqlConnection(ConnectionDB.ConnectionString());
        private SqlCommand sqlCommand;

        public int NewEmployee(int xIdFarm, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCDTNumero, 
            string xBrasilCDTDataDeEmissao, string xBrazilCDTSigla, string xBrazilCDTSerie, string xBrazilCDTPIS, string xBrazilCDTCadastro, 
            string xBrazilCNH, string xBrazilCNPJ, string xName, string xLastName, string xNickName, string xEmail, string xPhone, string xAddress, 
            string xBirthday, string xObservation, string xBirthCountry, string xNeighborhood, string xCity, string xState, string xSex, 
            string xJob, string xHiringDate, string xSaralyObservation, string xSaraly, string xVacation, string xTimeOfWork, string xDayOfWork, int xTemp)
        {
             
            Employee objEmployee = new Employee();
            EmployeeRepository repoEmployee = new EmployeeRepository();
            int xIdDocument = NewDocument(xBrazilCPF, xBrazilRG, xPassport, xBrazilCDTNumero, xBrasilCDTDataDeEmissao, xBrazilCDTSigla, xBrazilCDTSerie, xBrazilCDTPIS, xBrazilCDTCadastro, xBrazilCNH, xBrazilCNPJ);

            objEmployee.Address = xAddress.Trim();
            objEmployee.Birthday = xBirthday;
            objEmployee.Email = xEmail.ToLower().Trim();
            objEmployee.IdDocument = xIdDocument;
            objEmployee.IdFarm = xIdFarm;
            objEmployee.LastName = Strings.FistUppercaseAllWords(xLastName);
            objEmployee.Name = Strings.FistUppercaseAllWords(xName);
            objEmployee.NickName = Strings.FistUppercaseAllWords(xNickName);
            objEmployee.Phone = xPhone.Trim();
            objEmployee.Temp = xTemp;
            objEmployee.City = Strings.FistUppercaseAllWords(xCity).Trim();
            objEmployee.DayOfWork = xDayOfWork.Trim();
            objEmployee.HiringDate = xHiringDate.Trim();
            objEmployee.Job = xJob;
            objEmployee.BirthCountry = xBirthCountry;
            objEmployee.Neighborhood = Strings.FistUppercaseAllWords(xNeighborhood).Trim();
            objEmployee.Observation = xObservation.Trim();
            objEmployee.Salary = xSaraly.Trim();
            objEmployee.SalaryObservation = xSaralyObservation.Trim();
            objEmployee.Sex = xSex.Trim();
            objEmployee.State = xState.Trim();
            objEmployee.TimeOfWork = xTimeOfWork;
            objEmployee.Vacation = xVacation;

            repoEmployee.Create(objEmployee);

            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Employee, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }
        public void NewClient(int xIdFarm, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCDTNumero, 
            string xBrasilCDTDataDeEmissao, string xBrazilCDTSigla, string xBrazilCDTSerie, string xBrazilCDTPIS, string xBrazilCDTCadastro, 
            string xBrazilCNH, string xBrazilCNPJ, string xName, string xLastName, string xNickName, string xEmail, string xPhone, string xAddress, string xBirthday,
            string xObservation, string xBirthCountry, string xNeighborhood, string xCity, string xState, string xSex)
        {
            Client objClient = new Client();
            ClientRepository repoClient = new ClientRepository();
            int xIdDocument = NewDocument(xBrazilCPF, xBrazilRG, xPassport, xBrazilCDTNumero, xBrasilCDTDataDeEmissao, xBrazilCDTSigla, xBrazilCDTSerie, xBrazilCDTPIS, xBrazilCDTCadastro, xBrazilCNH, xBrazilCNPJ);

            objClient.Address = xAddress.Trim();
            objClient.Birthday = xBirthday;
            objClient.Email = xEmail.ToLower().Trim();
            objClient.IdDocument = xIdDocument;
            objClient.IdFarm = xIdFarm;
            objClient.LastName = Strings.FistUppercaseAllWords(xLastName);
            objClient.Name = Strings.FistUppercaseAllWords(xName);
            objClient.NickName = Strings.FistUppercaseAllWords(xNickName);
            objClient.Phone = xPhone.Trim();
            objClient.City = Strings.FistUppercaseAllWords(xCity).Trim();
            objClient.BirthCountry = xBirthCountry;
            objClient.Neighborhood = Strings.FistUppercaseAllWords(xNeighborhood).Trim();
            objClient.Observation = xObservation.Trim();
            objClient.Sex = xSex.Trim();
            objClient.State = xState.Trim();

            repoClient.Create(objClient);
        }
        private int NewDocument(string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCDTNumero, string xBrasilCDTDataDeEmissao, string xBrazilCDTSigla, string xBrazilCDTSerie, string xBrazilCDTPIS, string xBrazilCDTCadastro, string xBrazilCNH, string xBrazilCNPJ)
        {
            Document objDocument = new Document();
            DocumentRepository repoDocument = new DocumentRepository();

            objDocument.BrazilCDTNumero = xBrazilCDTNumero.Trim();
            objDocument.BrazilCNPJ = xBrazilCNPJ.Trim();
            objDocument.BrazilCPF = xBrazilCPF.Trim();
            objDocument.BrazilRG = xBrazilRG.Trim();
            objDocument.Passport = xPassport.ToUpper().Trim();
            objDocument.BrazilCDTDataDeEmissao = xBrasilCDTDataDeEmissao;
            objDocument.BrazilCDTCadastro = xBrazilCDTCadastro;
            objDocument.BrazilCDTPIS = xBrazilCDTPIS;
            objDocument.BrazilCDTSerie = xBrazilCDTSerie;
            objDocument.BrazilCDTSigla = xBrazilCDTSigla;
            objDocument.BrazilCNH = xBrazilCNH;

            repoDocument.Create(objDocument);

            return 2;

            //using (conns)
            //{
            //    conns.Open();
            //    sqlCommand = new SqlCommand("select top 100 * from " + TableNames.Document + " where BrazilCPF = '" + xBrazilCPF + "' and BrazilRG = '" + xBrazilRG + "' and Passport = '" + xPassport + "' and BrazilCDTNumero = '" + xBrazilCDTNumero + "' and BrazilCDTDataDeEmissao = '" + xBrasilCDTDataDeEmissao + "' and BrazilCDTSigla = '" + xBrazilCDTSigla + "' and BrazilCDTSerie = '" + xBrazilCDTSerie + "' and BrazilCDTPIS = '" + xBrazilCDTPIS + "' and BrazilCDTCadastro = '" + xBrazilCDTCadastro + "' and BrazilCNH = '" + xBrazilCNH + "' and BrazilCNPJ = '" + xBrazilCNPJ + "' order by Id desc;", conns);
            //    sqlCommand.ExecuteNonQuery();
            //    Int32 newId = (Int32)sqlCommand.ExecuteScalar();
            //    conns.Close();
            //    return Convert.ToInt32(newId);
            //}
        }
        public void NewFarm(int xSize, int xType, int xUserId, string xName, string xOwner, string xAddress, int xIdRegion, int xIdCountry)
        {
            //SqlCommands sql = new SqlCommands();
            //sql.SQLCommand("Insert into " + TableNames.Farm + " (Size, Type, AllowedUsers, Name, Owner, Address, IdCountry, IdRegion) VALUES (" + xSize + "," + xType + ",'" + xUserId + "','" + xName + "','" + xOwner + "','" + xAddress + "', '"+xIdCountry+"','"+xIdRegion+"')");
            Farm objFarm = new Farm();
            FarmRepository repoFarm = new FarmRepository();

            objFarm.Address = xAddress.Trim();
            objFarm.AllowedUsers = xUserId.ToString();
            objFarm.Name = Strings.FistUppercaseAllWords(xName).Trim();
            objFarm.Owner = Strings.FistUppercaseAllWords(xOwner).Trim();
            objFarm.Size = xSize;
            objFarm.Type = xType;
            objFarm.IdRegion = xIdRegion;
            objFarm.IdCountry = xIdCountry;

            repoFarm.Create(objFarm);
        }
        public void NewUser(int xIdFarm, int xIdEmployee, int xAccessType, int xUnity, string xPassword)
        {
            User objUser = new User();
            UserRepository repoUser = new UserRepository();

            objUser.IdEmployee = xIdEmployee;
            objUser.AccessType = xAccessType;
            objUser.FirstLogin = DateTime.Now;
            objUser.LastLogin = DateTime.Now;
            objUser.Password = Encode.Base64Encode(xPassword).Trim();
            objUser.Unity = xUnity;
            
            repoUser.Create(objUser);
        }
        public void NewProducitonCost(int xIdFarm, decimal xFertilizer, decimal xMicroNutrients, decimal xHerbicide, decimal xFungicide, decimal xInsecticide, decimal xManure, decimal xFuel, decimal xLubricant, decimal xCleaningEquipament, decimal xTools, decimal xAccessories, decimal xOthers, decimal xEmployee, decimal xTempEmployee, decimal xOvertime, decimal xEletricity, decimal xMachineMaintenance, decimal xPublicTransport, decimal xThirdpartyTransport, string xDescription, decimal xServicesOthers, string xUsername, DateTime xMouthOfReference)
        {
            ProductionCost objProductionCost = new ProductionCost();
            ProductionCostRepository repoProductionCost = new ProductionCostRepository();

            objProductionCost.Accessories = xAccessories;
            objProductionCost.CleaningEquipament = xCleaningEquipament;
            objProductionCost.Description = xDescription;
            objProductionCost.Eletricity = xEletricity;
            objProductionCost.Employee = xEmployee;
            objProductionCost.Fertilizer = xFertilizer;
            objProductionCost.Fuel = xFuel;
            objProductionCost.Fungicide = xFungicide;
            objProductionCost.Herbicide = xHerbicide;
            objProductionCost.IdFarm = xIdFarm;
            objProductionCost.Insecticide = xInsecticide;
            objProductionCost.Lubricant = xLubricant;
            objProductionCost.MachineMaintenance = xMachineMaintenance;
            objProductionCost.Manure = xManure;
            objProductionCost.MicroNutrients = xMicroNutrients;
            objProductionCost.MonthOfReference = xMouthOfReference.ToString();
            objProductionCost.Others = xOthers;
            objProductionCost.Overtime = xOvertime;
            objProductionCost.PublicTransport = xPublicTransport;
            objProductionCost.ServicesOthers = xServicesOthers;
            objProductionCost.TempEmployee = xTempEmployee;
            objProductionCost.ThirdpartyTransport = xThirdpartyTransport;
            objProductionCost.TimeOfPost = DateTime.Now.ToString();
            objProductionCost.Tools = xTools;
            objProductionCost.Username = Strings.FistUppercaseAllWords(xUsername.Trim());
            objProductionCost.TotalServices = xFertilizer + xMicroNutrients + xHerbicide + xFungicide + xInsecticide + xManure + xFuel + xLubricant + xCleaningEquipament + xTools + xAccessories + xOthers;
            objProductionCost.ServicesOthers = xEmployee + xTempEmployee + xOvertime + xEletricity + xMachineMaintenance + xPublicTransport + xThirdpartyTransport + xServicesOthers;
            objProductionCost.TotalCost = objProductionCost.TotalServices + objProductionCost.TotalCost;

            repoProductionCost.Create(objProductionCost);
        }

        public void NewCoffee(string xRegion, string xType, int xPlantation, int xFlowering, int xHarvest, int xProcessing, int xDrying, int xRoasting, int xGrinding, int xClassification, int xPacking, int xBoxing)
        {
            Coffee objCoffee = new Coffee();
            CoffeeRepository repoCoffee = new CoffeeRepository();

            objCoffee.Boxing = xBoxing;
            objCoffee.Classification = xClassification;
            objCoffee.Drying = xDrying;
            objCoffee.Flowering = xFlowering;
            objCoffee.Grinding = xGrinding;
            objCoffee.Harvest = xHarvest;
            objCoffee.Packing = xPacking;
            objCoffee.Plantation = xPlantation;
            objCoffee.Processing = xProcessing;
            objCoffee.Region = xRegion;
            objCoffee.Roasting = xRoasting;
            objCoffee.Type = xType;

            repoCoffee.Create(objCoffee);
        }

        public void NewUserCoffee(int xIdFarm, bool xIsHarvest, string xName, int xIdCoffee, int xPlantation, string xBeginningOfPlantation, string xAfterPlantation, int xFlowering, string xBeginningOfFlowering, string xAfterFlowering, int xHarvest, string xBeginningOfHarvest, string xAfterHarvest, int xProcessing, string xBeginningOfProcessing, string xAfterProcessing, int xDrying, string xBeginningOfDrying, string xAfterDrying, int xRoasting, string xBeginningOfRoasting, string xAfterRoasting, int xGrinding, string xBeginningOfGrinding, string xAfterFrinding, int xClassification, string xBeginningOfClassification, string xAfterClassification, int xPacking, string xBeginningOfPacking, string xAfterPacking, int xBoxing, string xBeginningOfBoxing, string xAfterBoxing)
        {
            UserCoffee objCoffee = new UserCoffee();
            UserCoffeeRepository repoCoffee = new UserCoffeeRepository();

            if (xIsHarvest)
                objCoffee.IsHarvest = 1;
            else
                objCoffee.IsHarvest = 0;

            objCoffee.AfterBoxing = xAfterBoxing;
            objCoffee.AfterClassification = xAfterClassification;
            objCoffee.AfterDrying = xAfterDrying;
            objCoffee.AfterFlowering = xAfterFlowering;
            objCoffee.AfterGrinding = xAfterFrinding;
            objCoffee.AfterHarvest = xAfterHarvest;
            objCoffee.AfterPacking = xAfterPacking;
            objCoffee.AfterPlantation = xAfterPlantation;
            objCoffee.AfterProcessing = xAfterProcessing;
            objCoffee.AfterRoasting = xAfterRoasting;
            objCoffee.BeginningOfBoxing = xBeginningOfBoxing;
            objCoffee.BeginningOfClassification = xBeginningOfClassification;
            objCoffee.BeginningOfDrying = xBeginningOfDrying;
            objCoffee.BeginningOfFlowering = xBeginningOfFlowering;
            objCoffee.BeginningOfGrinding = xBeginningOfGrinding;
            objCoffee.BeginningOfHarvest = xBeginningOfHarvest;
            objCoffee.BeginningOfPacking = xBeginningOfPacking;
            objCoffee.BeginningOfPlantation = xBeginningOfPlantation;
            objCoffee.BeginningOfProcessing = xBeginningOfProcessing;
            objCoffee.BeginningOfRoasting = xBeginningOfRoasting;
            objCoffee.Name = xName.Trim();
            objCoffee.IdCoffee = xIdCoffee;
            objCoffee.IdFarm = xIdFarm;
            objCoffee.Boxing = xBoxing;
            objCoffee.Classification = xClassification;
            objCoffee.Drying = xDrying;
            objCoffee.Flowering = xFlowering;
            objCoffee.Grinding = xGrinding;
            objCoffee.Harvest = xHarvest;
            objCoffee.Packing = xPacking;
            objCoffee.Plantation = xPlantation;
            objCoffee.Processing = xProcessing;
            objCoffee.Roasting = xRoasting;

            repoCoffee.Create(objCoffee);
        }
    }
}
