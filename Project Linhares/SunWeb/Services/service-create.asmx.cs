using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SunWeb.Services
{
    /// <summary>
    /// Summary description for service_create
    /// </summary>
    [WebService(Namespace = "http://agroassistant.azurewebsites.net/Services/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class service_create : System.Web.Services.WebService
    {

        [WebMethod]
        public void AddEmployee(int xIdFarm, string xName, string xLastName, string xNickName, string xEmail, string xPhone, string xAddress, string xBirthday, bool xTemp, int xDaysAtWork, string xFistHiringDate, string xLastHiringDate, string xLastResignationDate, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCarteiraDeTrabalho, string xBrazilCNPJ)
        {
            int temp;
            if (xTemp == true)
                temp = 1;
            else
                temp = 0;
            Create createEmployee = new Create();
            createEmployee.NewEmployee(xIdFarm, xBrazilCPF, xBrazilRG, xPassport, xBrazilCarteiraDeTrabalho, xBrazilCNPJ, xName, xLastName, xNickName, xEmail, xPhone, xAddress, xBirthday, temp, xDaysAtWork, xFistHiringDate, xLastHiringDate, xLastResignationDate);
        }

        public void AddClient(int xIdFarm, string xName, string xLastName, string xNickName, string xEmail, string xPhone, string xAddress, string xBirthday, string xBrazilCPF, string xBrazilRG, string xPassport, string xBrazilCarteiraDeTrabalho, string xBrazilCNPJ)
        {
            Create createClient = new Create();
            createClient.NewClient(xIdFarm, xBrazilCPF, xBrazilRG, xPassport, xBrazilCarteiraDeTrabalho, xBrazilCNPJ, xName, xLastName, xNickName, xEmail, xPhone, xAddress, xBirthday);
        }
    }
}
