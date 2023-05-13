using System.Reflection;

namespace ProjectCachoeiro.Web.Util
{
    public class Information
    {
        //git rev-list --all --count
        private static int Major = 1;
        private static int Minor { get; set; }
        private static int Patch { get; set; }
        private static int CommitsSinceVersionSource { get; set; }
        private static int CommitsSinceVersionSourcePadded { get; set; }
        private static string BranchName { get; set; }
        private static string LegacySemVerPadded { get; set; }
        private static string Release = "1804";

        public static string Version()
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var assemblyName = assembly.GetName().Name;
            //var gitVersionInformationType = assembly.GetType(assemblyName + ".GitVersionInformation");

            //BranchName = gitVersionInformationType.GetField("BranchName").GetValue(null).ToString();
            //LegacySemVerPadded = gitVersionInformationType.GetField("LegacySemVerPadded").GetValue(null).ToString();
            //Minor = int.Parse(gitVersionInformationType.GetField("Minor").GetValue(null).ToString());
            //Patch = int.Parse(gitVersionInformationType.GetField("Patch").GetValue(null).ToString());
            //CommitsSinceVersionSource = int.Parse(gitVersionInformationType.GetField("CommitsSinceVersionSource").GetValue(null).ToString());
            //CommitsSinceVersionSourcePadded = int.Parse(gitVersionInformationType.GetField("CommitsSinceVersionSourcePadded").GetValue(null).ToString());

            return "test-version";

            //if (BranchName.Contains("master"))
            //    return Major + "." + Release + "." + CommitsSinceVersionSource;
            //else
            //    return Major + "." + Release + "." + CommitsSinceVersionSource + "-" + BranchName;
        }
    }
}
