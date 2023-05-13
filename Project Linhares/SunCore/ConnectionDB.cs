using SunCore;

namespace SunCore
{
    public class ConnectionDB
    {
        public static string ConnectionString()
        {
            if (Information.Database == 1)
            {
                //Surface
                //return @"Data Source=DESKTOP-LQ8HTPN\SQLEXPRESS;Initial Catalog=agronomy;Integrated Security=True";

                //MainPC
                return @"Data Source=VTN_MAIN\SQLEXPRESS;Initial Catalog=agronomy;Integrated Security=True";
            }
            else
            {
                //Surface
                //return @"Data Source=DESKTOP-LQ8HTPN\SQLEXPRESS;Initial Catalog=agronomy;Integrated Security=True";

                //MainPC
                //return @"Data Source=VTN_MAIN\SQLEXPRESS;Initial Catalog=agronomy;Integrated Security=True";

                return "Data Source=axna8xeyyv.database.windows.net;Initial Catalog=agronomy;Persist Security Info=True;User ID=vtn_db_lg-042@axna8xeyyv;Password=#M1161W4Jm";
            }
         
        }
    }
}
