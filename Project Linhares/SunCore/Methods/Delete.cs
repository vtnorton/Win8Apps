using SunCore.Classes;
using SunCore.Classes.Agriculture;
using SunCore.Classes.UserAgriculture;
using SunCore.Repository;
using SunCore.Repository.Agriculture;
using SunCore.Repository.UserAgriculture;

namespace SunCore.Methods
{
    public class Delete { 
        private void DeleteDocument(int xId)
        {
            Document objDocument = new Document();
            DocumentRepository repoDocument = new DocumentRepository();
            objDocument.Id = xId;
            repoDocument.Delete(objDocument);
        }
        public void DeleteEmployee(int xId)
        {
            Employee objEmployee = new Employee();
            EmployeeRepository repoEmployee = new EmployeeRepository();
            DeleteDocument(repoEmployee.RetornarID(xId).IdDocument);
            objEmployee.Id = xId;
            repoEmployee.Delete(objEmployee);
        }
        public void DeleteFarm(int xId)
        {
            Farm objFarm = new Farm();
            FarmRepository repoFarm = new FarmRepository();
            objFarm.Id = xId;
            repoFarm.Delete(objFarm);
        }
        public void DeleteUser(int xId)
        {
            User objUser = new User();
            UserRepository repoUser = new UserRepository();
            objUser.Id = xId;
            repoUser.Delete(objUser);
        }
        public void DeleteClient(int xId)
        {
            Client objClient = new Client();
            ClientRepository repoClient = new ClientRepository();
            DeleteDocument(repoClient.RetornarID(xId).IdDocument);
            objClient.Id = xId;
            repoClient.Delete(objClient);
        }
        public void DeleteProductionCost(int xId)
        {
            ProductionCost ojbProductionCost = new ProductionCost();
            ProductionCostRepository repoProductionCost = new ProductionCostRepository();
            ojbProductionCost.Id = xId;
            repoProductionCost.Delete(ojbProductionCost);
        }

        #region AGRICULTURE
        public void Coffee(int xId)
        {
            Coffee objCoffee = new Coffee();
            CoffeeRepository repoCoffee = new CoffeeRepository();
            objCoffee.Id = xId;
            repoCoffee.Delete(objCoffee);
        }
        #endregion

        #region USER AGRICULTURE
        public void UserCoffee(int xId)
        {
            UserCoffee objCoffee = new UserCoffee();
            UserCoffeeRepository repoCoffee = new UserCoffeeRepository();
            objCoffee.Id = xId;
            repoCoffee.Delete(objCoffee);
        }
        #endregion
    }
}
