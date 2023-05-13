using SunCore.Classes;
using SunCore.Repository;
using System;

namespace SunCore.Methods
{
    public class Update
    {
        public void UpdateEmployee(int xId, int xIdFarm, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCDTNumero,
            string xBrasilCDTDataDeEmissao, string xBrazilCDTSigla, string xBrazilCDTSerie, string xBrazilCDTPIS, string xBrazilCDTCadastro,
            string xBrazilCNH, string xBrazilCNPJ, string xName, string xLastName, string xNickName, string xEmail, string xPhone, string xAddress,
            string xBirthday, string xObservation, string xBirthCountry, string xNeighborhood, string xCity, string xState, string xSex,
            string xJob, string xHiringDate, string xSaralyObservation, string xSaraly, string xVacation, string xTimeOfWork, string xDayOfWork, int xTemp)
        {
            Employee objEmployee = new Employee();
            EmployeeRepository repoEmployee = new EmployeeRepository();

            UpdateDocument(repoEmployee.RetornarID(xId).IdDocument, xBrazilCPF, xBrazilRG, xPassport, xBrazilCDTNumero, xBrasilCDTDataDeEmissao, xBrazilCDTSigla, xBrazilCDTSerie, xBrazilCDTPIS, xBrazilCDTCadastro, xBrazilCNH, xBrazilCNPJ);
            objEmployee.Id = xId;
            objEmployee.Address = xAddress.Trim();
            objEmployee.Birthday = xBirthday;
            objEmployee.Email = xEmail.ToLower().Trim();
            objEmployee.IdDocument = repoEmployee.RetornarID(xId).IdDocument;
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

            repoEmployee.Update(objEmployee);
        }
        public void UpdateClient(int xId, int xIdFarm, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCDTNumero,
            string xBrasilCDTDataDeEmissao, string xBrazilCDTSigla, string xBrazilCDTSerie, string xBrazilCDTPIS, string xBrazilCDTCadastro,
            string xBrazilCNH, string xBrazilCNPJ, string xName, string xLastName, string xNickName, string xEmail, string xPhone, string xAddress, string xBirthday,
            string xObservation, string xBirthCountry, string xNeighborhood, string xCity, string xState, string xSex)
        {
            Client objClient = new Client();
            ClientRepository repoClient = new ClientRepository();

            UpdateDocument(repoClient.RetornarID(xId).IdDocument, xBrazilCPF, xBrazilRG, xPassport, xBrazilCDTNumero, xBrasilCDTDataDeEmissao, xBrazilCDTSigla, xBrazilCDTSerie, xBrazilCDTPIS, xBrazilCDTCadastro, xBrazilCNH, xBrazilCNPJ);
            objClient.Id = xId;
            objClient.Address = xAddress.Trim();
            objClient.Birthday = xBirthday;
            objClient.Email = xEmail.ToLower().Trim();
            objClient.IdDocument = repoClient.RetornarID(xId).IdDocument;
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

            repoClient.Update(objClient);
        }
        private void UpdateDocument(int xId, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCDTNumero, string xBrasilCDTDataDeEmissao, string xBrazilCDTSigla, string xBrazilCDTSerie, string xBrazilCDTPIS, string xBrazilCDTCadastro, string xBrazilCNH, string xBrazilCNPJ)
        {
            Document objDocument = new Document();
            DocumentRepository repoDocument = new DocumentRepository();
            
            objDocument.Id = xId;
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

            repoDocument.Update(objDocument);
        }
        public void UpdateFarm(int xId, int xSize, int xType, int xUserId, string xName, string xOwner, string xAddress, int xIsRegion, int xIdCountry)
        {
            Farm objFarm = new Farm();
            FarmRepository repoFarm = new FarmRepository();

            objFarm.Id = xId;
            objFarm.Address = xAddress.Trim();
            objFarm.AllowedUsers = xUserId.ToString();
            objFarm.Name = Strings.FistUppercaseAllWords(xName).Trim();
            objFarm.Owner = Strings.FistUppercaseAllWords(xOwner).Trim();
            objFarm.Size = xSize;
            objFarm.Type = xType;
            objFarm.IdRegion = xIsRegion;
            objFarm.IdCountry = xIdCountry;

            repoFarm.Update(objFarm);
        }
        public void UpdateUser(int xId, int xAccessType, int xUnity, string xPassword)
        {
            User objUser = new User();
            UserRepository repoUser = new UserRepository();

            objUser.Id = xId;
            objUser.IdEmployee = repoUser.RetornarID(xId).IdEmployee;
            objUser.AccessType = xAccessType;
            objUser.FirstLogin = repoUser.RetornarID(xId).FirstLogin;
            objUser.LastLogin = repoUser.RetornarID(xId).LastLogin;
            objUser.Password = Encode.Base64Encode(xPassword).Trim();
            objUser.Unity = xUnity;

            repoUser.Update(objUser);
        }
        public void UpdateProducitonCost(int xId, int xIdFarm, decimal xFertilizer, decimal xMicroNutrients, decimal xHerbicide, decimal xFungicide, decimal xInsecticide, decimal xManure, decimal xFuel, decimal xLubricant, decimal xCleaningEquipament, decimal xTools, decimal xAccessories, decimal xOthers, decimal xEmployee, decimal xTempEmployee, decimal xOvertime, decimal xEletricity, decimal xMachineMaintenance, decimal xPublicTransport, decimal xThirdpartyTransport, string xDescription, decimal xServicesOthers, string xUsername, DateTime xMouthOfReference)
        {
            ProductionCost objProductionCost = new ProductionCost();
            ProductionCostRepository repoProductionCost = new ProductionCostRepository();

            objProductionCost.Id = xId;
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
            objProductionCost.MonthOfReference = repoProductionCost.RetornarID(xId).MonthOfReference;
            objProductionCost.Tools = xTools;
            objProductionCost.Username = Strings.FistUppercaseAllWords(xUsername.Trim());
            objProductionCost.TotalServices = xFertilizer + xMicroNutrients + xHerbicide + xFungicide + xInsecticide + xManure + xFuel + xLubricant + xCleaningEquipament + xTools + xAccessories + xOthers;
            objProductionCost.ServicesOthers = xEmployee + xTempEmployee + xOvertime + xEletricity + xMachineMaintenance + xPublicTransport + xThirdpartyTransport + xServicesOthers;
            objProductionCost.TotalCost = objProductionCost.TotalServices + objProductionCost.TotalCost;

            repoProductionCost.Update(objProductionCost);
        }
    }
}
