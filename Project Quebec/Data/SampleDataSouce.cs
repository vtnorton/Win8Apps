using ProjectQuebec.Code.LanguageSupport;
using System.Collections.Generic;

namespace ProjectQuebec.Data
{
    public class SampleDataSouce
    {
        private static IList<Language> _languages = LanguageDataSource.GetAllLanguage();
        private static List<Sample> _itemsFromOneLanguage = new List<Sample>();
        public IList<Sample> GetAllSampleByLanguageId(Language xLanguage)
        {
            _itemsFromOneLanguage.Clear();

            AddByLanguage(xLanguage);

            switch (xLanguage.Alias)
            {
                case "css":
                    AddByLanguage("xhtml");
                    AddByLanguage("js");
                    break;
                case "xhtml":
                    AddByLanguage("css");
                    AddByLanguage("js");
                    break;
                case "js":
                    AddByLanguage("xhtml");
                    AddByLanguage("css");
                    AddByLanguage("json5");
                    break;
                case "php":
                    AddByLanguage("xhtml");
                    AddByLanguage("css");
                    AddByLanguage("json5");
                    AddByLanguage("js");
                    break;
                case "c":
                    AddByLanguage("cpp");
                    break;
                case "cpp":
                    AddByLanguage("c");
                    break;
                case "python":
                case "java":
                case "csharp":
                    AddByLanguage("xml");
                    break;
            }

            AddByLanguage("txt");

            return _itemsFromOneLanguage;
        }
        private static void AddByLanguage(Language xSelecteLanguage)
        {
            for (int i = 0; i < xSelecteLanguage.SampleExtention.Length; i++)
            {
                Sample toAdd = new Sample();

                toAdd.SampleExtention = xSelecteLanguage.SampleExtention[i];
                toAdd.SampleImageURI = xSelecteLanguage.SampleImageURI[i];
                toAdd.SampleLanguage = xSelecteLanguage;
                toAdd.SampleURI = xSelecteLanguage.SampleURI[i];
                toAdd.Name = xSelecteLanguage.SampleTitle[i];
                toAdd.LanguageName = xSelecteLanguage.Name;

                _itemsFromOneLanguage.Add(toAdd);
            }
        }
        private static void AddByLanguage(string xAlias)
        {
            AddByLanguage(LanguageDataSource.GetLanguageByAlias(xAlias));
        }
    }
}
