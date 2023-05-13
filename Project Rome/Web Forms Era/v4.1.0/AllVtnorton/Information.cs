using System;

namespace AllVtnorton
{
    public class Information
    {
        public static int Prejects = 7;
        public static int Aplicatiovos = 1;
        public static int Programas = 2;
        public static int Sites = 2;
        public static int Build = 0402;
        public static string Developer = "Vítor Norton";
        public static string BuildInfo = Build + " (beta)"; 
        public static string Vtnorton = "4.1." + BuildInfo;
        public static string BSharpFramework = "0.2." + BuildInfo; //Banco de dados e source principal
        public static string Hidra = "1.0." + BuildInfo; //Azure Mobile Service com B#
        public static string HidraOnline = "0.1." + Build + " (alpha)"; //Web com Hidra
        public static string HidraWUA = "0.0." + (Build - 318) + " (alpha)";
        public static string Ladon = "1.0." + BuildInfo; //NHibernate com B#
        public static string Heartthrob = "0.2." + BuildInfo;
        public static string OpenSearch = "3.0." + (Build - 138) + " (alpha)";
        public static string Age = (DateTime.Now.Year - 2009) + " Years";
        public static string EmailContact = "contato@vtnorton.com";
        public static string EmailPersonal = "vitor@vtnorton.com";
        public static string UsernameSkype = "vtnorton";
        public static string UsernameTwitter = "@vt_norton";
        public static string UsernameInstagram = "@vt_norton";
        public static string URLTwitter = "http://www.twitter.com/vt_norton";
        public static string URLSite = "http://www.vtnorton.com/"; //Substituir em todos os lugares.
        public static string URLInstagram = "http://www.instagram.com/vt_norton";
        public static string URLFacebook = "http://www.facebook.com/vitor.norton";

        /// <summary>
        /// String de conexão com o banco de dados
        /// </summary>
        /// <returns>Retorna a String de conexão com o banco de dados atual</returns>
        public static string ActualStringConnection()
        {
            return StringConnection.ConnectionString();
            //return StringConnectionDev.ConnectionString();
        }
    }
}