using SunCore.Classes;
using SunCore.Methods;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Services;

namespace SunWeb.Services
{
    /// <summary>
    /// Summary description for service_read
    /// </summary>
    [WebService(Namespace = "http://agroassistant.azurewebsites.net/Services/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class service_read : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Employee> ReadEmployee(int xIdFarm, bool xIsTemp)
        {
            Read readEmployee = new Read();
            return readEmployee.LoadEmployee();
        }
    }
}
