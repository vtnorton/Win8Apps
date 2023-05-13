using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVtnorton
{
    public class StringConnectionDev
    {
        public static String Databese = "vtnorton-sql-devmode";
        public static String ServerDB = "axna8xeyyv.database.windows.net";
        public static String PortDB = "1433";
        public static String LoginDB = "vtn_db_lg-042@axna8xeyyv";
        public static String UserIDDB = "vtn_db_lg-042@axna8xeyyv";
        public static String PassworldDB = "#M1161W4Jm";
        public static String TrustedConnection = "False";
        public static String Encrypt = "True";
        public static String ConnectionTimeout = "30";

        public static string ConnectionString()
        {
          return  "Data Source=axna8xeyyv.database.windows.net;Initial Catalog=vtnorton-sql-devmode;Persist Security Info=True;User ID=vtn_db_lg-042@axna8xeyyv;Password=#M1161W4Jm";
        }
    }
}
