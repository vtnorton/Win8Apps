namespace ProjectNice.Code
{
    public class Version
    {
        public static string Core = "1.3";
        
        #region WINDOWS 10
        public static string Win10Nice = "2.1." + CoreInformation.Build;
        #endregion
    }
}
