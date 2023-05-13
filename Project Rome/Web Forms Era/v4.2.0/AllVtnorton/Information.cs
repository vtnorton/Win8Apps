using System;

namespace AllVtnorton
{
    public class Information
    {
        public static int Projects = 7;
        public static int Database = 1; // 1 - para banco de testes, 2 - para banco oficial
        public static int Build = 0489;
        public static string Developer = "Vítor Norton";
        public static string BuildInfo = Build + " (alpha)"; 
        public static string Vtnorton = "4.2." + BuildInfo;
        public static string BSharpFramework = "0.2." + BuildInfo; //Banco de dados e source principal
        public static string Hidra = "1.0." + BuildInfo; //Azure Mobile Service com B#
        public static string HidraOnline = "0.2." + Build + " (alpha)"; //Web com Hidra
        public static string AllVtnorton = "2.0." + BuildInfo;
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
        public static string URLSite = "http://www.vtnorton.com/"; 
        public static string URLInstagram = "http://www.instagram.com/vt_norton";
        public static string URLFacebook = "http://www.facebook.com/vitor.norton";
        
    }
}