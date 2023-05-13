using ProjectQuebec.Code.LanguageSupport;
using System.Collections.Generic;

namespace ProjectQuebec.Data
{
    public class LanguageDataSource
    {
        private static List<Language> _items = new List<Language>()
        {
             new Language //0
                {
                    Id = 0, Name = "C#",
                    Mime = new string[] { "text/x-csharp" },
                    Mode = "clike",
                    //File Extension
                    Extention = new string[] { ".cs" },
                    SampleExtention = new string[] {".cs",".cs", ".cs", ".cs"},
                    SampleTitle = new string[] {"Blank C# File", "C# Class", "C# Interface", "Hello World"},
                    SampleImageURI = new string[] {"", "", "", ""},
                    SampleURI = new string[] { "cs.txt", "cs01.txt","cs02.txt", "cs03.txt"},
                    Alias = "csharp",
                    ThereIsHint = false, Hint = null
                },
                new Language //1
                {
                    Id = 1, Name = "APL",
                    Mime = new string[] { "text/apl" },
                    Mode = "apl",
                    Extention = new string[] { ".apl", ".dyalog" },
                    SampleExtention = new string[] {".apl", ".dyalog"},
                    SampleTitle = new string[] {"Blank APL File", "Blank Dyalog file"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "apl.txt","dyalog.txt"},
                    Alias = "apl",
                    ThereIsHint = false, Hint = null
                },
                new Language //2
                {
                    Id = 2, Name = "PGP",
                    Mime = new string[] { "application/pgp", "application/pgp-keys", "application/pgp-signature" },
                    Mode = "asciiarmor",
                    Extention = new string[] { ".pgp" },
                    SampleExtention = new string[] {".pgp"},
                    SampleTitle = new string[] {"Blank PGP File"},
                    SampleImageURI = new string[] {""},
                    SampleURI = new string[] { "pgp.txt"},
                    Alias = "asciiarmor",
                    ThereIsHint = false, Hint = null
                },
                new Language //3
                {
                    Id = 3, Name = "C",
                    Mime = new string[] { "text/x-csrc" },
                    Mode = "clike",
                    Extention = new string[] { ".c", ".h" },
                    SampleExtention = new string[] {".c", ".h", ".c"},
                    SampleTitle = new string[] {"Blank C File", "Blank H File", "Hello World"},
                    SampleImageURI = new string[] {"", "", ""},
                    SampleURI = new string[] { "c.txt", "h.txt", "c01.txt"},
                    Alias = "c",
                    ThereIsHint = false, Hint = null
                },
                new Language //4
                {
                    Id = 4, Name = "C++",
                    Mime = new string[] { "text/x-c++src" },
                    Mode = "clike",
                    Extention = new string[] { ".cpp", ".c++", ".cc", ".cxx", ".hpp", ".h++", ".hh", ".hxx" },
                    SampleExtention = new string[] {".cpp", ".hpp"},
                    SampleTitle = new string[] {"Blank C++ File", "Blank H++ File"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "cpp.txt", "hpp.txt"},
                    Alias = "cpp",
                    ThereIsHint = false, Hint = null
                },
                new Language //5
                {
                    Id = 5, Name = "CSS",
                    Mime = new string[] { "text/css" },
                    Mode = "css",
                    Extention = new string[] { ".css" },
                    SampleExtention = new string[] {".css"},
                    SampleTitle = new string[] {"Blank CSS File"},
                    SampleImageURI = new string[] {""},
                    SampleURI = new string[] { "css.txt"},
                    Alias = "css",
                    ThereIsHint = false, Hint = null
                },
                new Language //6
                {
                    Id = 6, Name = "HTML",
                    Mime = new string[] { "text/html" },
                    Mode = "htmlmixed",
                    Extention = new string[] { ".html", ".htm" },
                    SampleExtention = new string[] {".html"},
                    SampleTitle = new string[] {"Blank HTML file"},
                    SampleImageURI = new string[] {""},
                    SampleURI = new string[] { "html.txt"},
                    Alias = "xhtml",
                    ThereIsHint = false, Hint = null
                },
                new Language //7
                {
                    Id = 7, Name = "Java",
                    Mime = new string[] { "text/x-java" },
                    Mode = "clike",
                    Extention = new string[] { ".java" },
                    SampleExtention = new string[] {".java", ".java"},
                    SampleTitle = new string[] {"Blank Java File", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "java.txt", "java01.txt"},
                    Alias = "java",
                    ThereIsHint = false, Hint = null
                },
                new Language //8
                {
                    Id = 8, Name = "JavaScript",
                    Mime = new string[] { "text/javascript", "text/ecmascript", "application/javascript", "application/x-javascript", "application/ecmascript" },
                    Mode = "javascript",
                    Extention = new string[] { ".js" },
                    SampleExtention = new string[] {".js", ".js"},
                    SampleTitle = new string[] {"Blank JavaScript file", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "js.txt", "js01.txt"},
                    Alias = "js",
                    ThereIsHint = false, Hint = null
                },
                new Language //9
                {
                    Id = 9, Name = "JSON",
                    Mime = new string[] { "application/json", "application/x-json" },
                    Mode = "javascript",
                    Extention = new string[] { ".json", ".map" },
                    SampleExtention = new string[] {".json", ".map"},
                    SampleTitle = new string[] {"Blank JSON File", "Blank Map File"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "json.txt", "map.txt"},
                    Alias = "json5",
                    ThereIsHint = false, Hint = null
                },
                new Language //10
                {
                    Id = 10, Name = "Lua",
                    Mime = new string[] { "text/x-lua" },
                    Mode = "lua",
                    Extention = new string[] { ".lua" },
                    SampleExtention = new string[] {".lua", ".lua"},
                    SampleTitle = new string[] {"Blank Lua File", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "lua.txt", "lua01.txt"},
                    Alias = "lua",
                    ThereIsHint = false, Hint = null
                },
                new Language //11
                {
                    Id = 11, Name = "Pascal",
                    Mime = new string[] { "text/x-pascal" },
                    Mode = "pascal",
                    Extention = new string[] { ".p", ".pas" },
                    SampleExtention = new string[] {".p", ".p"},
                    SampleTitle = new string[] {"Blank Pascal File", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "p.txt", "p01.txt"},
                    Alias = "pascal",
                    ThereIsHint = false, Hint = null
                },
                new Language //12
                {
                    Id = 12, Name = "PHP",
                    Mime = new string[] { "application/x-httpd-php" },
                    Mode = "php",
                    Extention = new string[] { ".php", ".php3", ".php4", ".php5", ".phtml" },
                    SampleExtention = new string[] {".php", ".php5", ".php"},
                    SampleTitle = new string[] {"Blank PHP File", "Blank PHP5 File", "Hello World"},
                    SampleImageURI = new string[] {"", "", "" },
                    SampleURI = new string[] { "php.txt", "php01.txt", "php02.txt"},
                    Alias = "php",
                    ThereIsHint = false, Hint = null
                },
                new Language //13
                {
                    Id = 13, Name = "Python",
                    Mime = new string[] { "text/x-python" },
                    Mode = "python",
                    Extention = new string[] { ".BUILD", ".bzl", ".py", ".pyw" },
                    SampleExtention = new string[] {".py", ".py"},
                    SampleTitle = new string[] {"Blank Python File", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "py.txt", "py01.txt"},
                    Alias = "python",
                    ThereIsHint = false, Hint = null
                },
                new Language //17
                {
                    Id = 17, Name = "Swift",
                    Mime = new string[] { "text/x-swift" },
                    Mode = "swift",
                    Extention = new string[] { ".swift"},
                    SampleExtention = new string[] {".swift"},
                    SampleTitle = new string[] {"Blank Swift File"},
                    SampleImageURI = new string[] {""},
                    SampleURI = new string[] { "swift.txt"},
                    Alias = "swift",
                    ThereIsHint = false, Hint = null
                },
                new Language //14
                {
                    Id = 14, Name = "SQL",
                    Mime = new string[] { "text/x-sql" },
                    Mode = "sql",
                    Extention = new string[] { ".sql" },
                    SampleExtention = new string[] {".sql", ".sql"},
                    SampleTitle = new string[] {"Blank SQL File", "Create table SQL"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] { "sql.txt", "sql02.txt"},
                    Alias = "sql", ThereIsHint = false, Hint = null
                },
                new Language //15
                {
                    Id = 15, Name = "Textfile",
                    Mime = new string[] { "text/x-textile" },
                    Mode = "textile",
                    Extention = new string[] { ".txt" },
                    SampleExtention = new string[] { ".txt"},
                    SampleTitle = new string[] {"Text file"},
                    SampleImageURI = new string[] {""},
                    SampleURI = new string[] {"txt.txt"},
                    Alias = "txt", ThereIsHint = false, Hint = null
                },
                new Language //18
                {
                    Id = 18, Name = "Visual Basic",
                    Mime = new string[] { "text/x-vb" },
                    Mode = "vb",
                    Extention = new string[] { ".vb" },
                    SampleExtention = new string[] { ".vb", ".vb"},
                    SampleTitle = new string[] {"Blank Visual Basic file", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] {"vb.txt","vb01.txt"},
                    Alias = "vb", ThereIsHint = false, Hint = null
                },
                new Language //16
                {
                    Id = 16, Name = "XML",
                    Mime = new string[] { "text/xml", "application/xml"  },
                    Mode = "xml",
                    Extention = new string[] { ".xml", ".xsl", ".xsd" },
                    SampleExtention = new string[] {".xml", ".xsl", ".xsd" },
                    SampleTitle = new string[] {"XML Document", "XSL Document", "XSD Document"},
                    SampleImageURI = new string[] {"", "", ""},
                    SampleURI = new string[] {"xml.txt", "xsl.txt", "xsd.txt"},
                    Alias = "xml", ThereIsHint = false, Hint = null,
                },
                new Language //19 cobol...
                {
                    Id = 19, Name = "Cobol",
                    Mime = new string[] { "text/x-cobol" },
                    Mode = "cobol",
                    Extention = new string[] { ".cbl" , ".cob", ".cpy"},
                    SampleExtention = new string[] {".cbl",".cbl"},
                    SampleTitle = new string[] {"Blank Cobal file", "Hello World"},
                    SampleImageURI = new string[] {"", ""},
                    SampleURI = new string[] {"cobol.txt","cobol01.txt"},
                    Alias = "cobal", ThereIsHint = false, Hint = null
                },
                new Language //coffeescript 20
                {
                    Id = 20, Name = "CoffeeScript",
                    Mime = new string[] {"application/vnd.coffeescript", "text/coffeescript", "text/x-coffeescript" },
                    Mode = "coffeescript",
                    Extention = new string[] { ".coffee" },
                    SampleExtention = new string[] { ".coffee", ".coffee" },
                    SampleTitle = new string[] { "Blank CoffeeScript file", "Hello World"},
                    SampleImageURI = new string[] { "","" },
                    SampleURI = new string[] { "coffee.txt",  "coffee01.txt"  },
                    Alias = "coffeescript", ThereIsHint = false, Hint = null
                },
                new Language //Crystal 21
                {
                    Id = 21, Name = "Crystal",
                    Mime = new string[] {"text/x-crystal" },
                    Mode = "crystal",
                    Extention = new string[] { ".cr" },
                    SampleExtention = new string[] { ".cr",".cr" },
                    SampleTitle = new string[] { "Blank Crystal file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "Crystal.txt",  "Crystal01.txt"  },
                    Alias = "crystal", ThereIsHint = false, Hint = null
                },
                new Language //Cython  23 create the mode
                {
                    Id = 23, Name = "Cython",
                    Mime = new string[] {"text/x-cython" },
                    Mode = "python",
                    Extention = new string[] { ".pyx",".pyxdep" },
                    SampleExtention = new string[] { ".pyx",".pyx" },
                    SampleTitle = new string[] { "Blank Cython file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "cython.txt",  "cython01.txt"  },
                    Alias = "cython", ThereIsHint = false, Hint = null
                },
                new Language //Fortran  24
                {
                    Id = 24, Name = "Fortran",
                    Mime = new string[] {"text/x-fortran" },
                    Mode = "fortran",
                    Extention = new string[] { ".f",".for",".f90",".f95",".f03" },
                    SampleExtention = new string[] { ".f",".f"  },
                    SampleTitle = new string[] { "Blank Fortran file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "fortran.txt",  "fortran01.txt" },
                    Alias = "fortran", ThereIsHint = false, Hint = null
                },
                new Language //F#  25
                {
                    Id = 25, Name = "F#",
                    Mime = new string[] {"text/x-fsharp" },
                    Mode = "mllike",
                    Extention = new string[] {  ".fs", ".fsi", ".ml", ".mli", ".fsx", ".fsscript" },
                    SampleExtention = new string[] { ".fs",".fs" },
                    SampleTitle = new string[] { "Blank F# file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "fsharp.txt",  "fsharp01.txt" },
                    Alias = "fsharp", ThereIsHint = false, Hint = null
                },
                new Language //Objective-C 26
                {
                    Id = 26, Name = "Objective-C",
                    Mime = new string[] {"text/x-objectivec" },
                    Mode = "clike.js",
                    Extention = new string[] { ".h", ".m", ".mm", ".C" },
                    SampleExtention = new string[] { ".m",".m" },
                    SampleTitle = new string[] { "Blank Objective-C file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "objectivec.txt",  "objectivec01.txt" },
                    Alias = "objective-c", ThereIsHint = false, Hint = null
                },
                new Language //Pascal 27
                {
                    Id = 27, Name = "Pascal",
                    Mime = new string[] {"text/x-pascal" },
                    Mode = "pascal",
                    Extention = new string[] { ".p", ".pl", ".pas", ".pascal" },
                    SampleExtention = new string[] { ".pas",".pas" },
                    SampleTitle = new string[] { "Blank Pascal file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "pascal.txt",  "pascal.txt" },
                    Alias = "pascal", ThereIsHint = false, Hint = null
                },
                new Language //Powershell  28
                {
                    Id = 28, Name = "PowerShell",
                    Mime = new string[] {"application/x-powershell" },
                    Mode = "powershell",
                    Extention = new string[] { ".ps1", ".ps1xml", ".psc1", ".psd1", ".psm1", ".pss", ".cdxml" },
                    SampleExtention = new string[] { ".ps1", ".ps1" },
                    SampleTitle = new string[] { "Blank PowerShell file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "powershell.txt",  "powershell1.txt" },
                    Alias = "powershell", ThereIsHint = false, Hint = null
                },
                new Language //Ruby  29
                {
                    Id = 29, Name = "Ruby",
                    Mime = new string[] {"text/x-ruby" },
                    Mode = "ruby",
                    Extention = new string[] { ".ps1", ".ps1xml", ".psc1", ".psd1", ".psm1", ".pss", ".cdxml" },
                    SampleExtention = new string[] { ".ps1", ".ps1" },
                    SampleTitle = new string[] { "Blank Ruby file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "ruby.txt",  "ruby01.txt" },
                    Alias = "ruby", ThereIsHint = false, Hint = null
                },
                new Language //Factor  30
                {
                    Id = 30, Name = "Factor",
                    Mime = new string[] {"text/x-factor" },
                    Mode = "factor",
                    Extention = new string[] { ".factor" },
                    SampleExtention = new string[] { ".factor", ".facto" },
                    SampleTitle = new string[] { "Blank Factor file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "factor.txt",  "factor01.txt" },
                    Alias = "factor", ThereIsHint = false, Hint = null
                },
                new Language //Diff   31
                {
                    Id = 31, Name = "Diff",
                    Mime = new string[] {"text/x-factor"}, //TODO: Verificar isso aqui
                    Mode = "diff",
                    Extention = new string[] { ".diff" },
                    SampleExtention = new string[] { ".diff" },
                    SampleTitle = new string[] { "Blank Diff file"},
                    SampleImageURI = new string[] { "" },
                    SampleURI = new string[] { "diff.txt" },
                    Alias = "diff", ThereIsHint = false, Hint = null
                },
                new Language //Groovy  32
                {
                    Id = 32, Name = "Groovy",
                    Mime = new string[] {"text/x-groovy" },
                    Mode = "groovy",
                    Extention = new string[] { ".groovy" },
                    SampleExtention = new string[] { ".groovy", ".groovy" },
                    SampleTitle = new string[] { "Blank Groovy file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "groovy.txt",  "groovy01.txt" },
                    Alias = "groovy", ThereIsHint = false, Hint = null
                },
                new Language //Elm  33
                {
                    Id = 33, Name = "Elm",
                    Mime = new string[] {"text/x-elm" },
                    Mode = "elm",
                    Extention = new string[] { ".elm" },
                    SampleExtention = new string[] { ".elm", ".elm" },
                    SampleTitle = new string[] { "Blank Elm file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "elm.txt",  "elm01.txt" },
                    Alias = "elm", ThereIsHint = false, Hint = null
                },
                new Language //Yaml  34
                {
                    Id = 34, Name = "Yaml",
                    Mime = new string[] {"text/x-yaml" },
                    Mode = "yaml",
                    Extention = new string[] { ".yml" },
                    SampleExtention = new string[] { ".yml", ".yml" },
                    SampleTitle = new string[] { "Blank Yaml file", "Hello World"},
                    SampleImageURI = new string[] { "", "" },
                    SampleURI = new string[] { "yml.txt",  "yml01.txt" },
                    Alias = "yaml", ThereIsHint = false, Hint = null
                }

        };
        public static IList<Language> GetAllLanguage()
        {
            return _items;
        }
        public static Language GetLanguageById(int Id)
        {
            return _items.Find(item => item.Id == Id);
        }

        public static Language GetLanguageByExtention(string extention)
        {
            Language toReturn = null;
            foreach (var item in _items)
            {
                for (int i = 0; i < item.Extention.Length; i++)
                {
                    if (item.Extention[i] == extention)
                        toReturn = item;
                }
            }
            return toReturn;
        }
        public static Language GetLanguageByAlias(string Alias)
        {
            Language toReturn = null;
            foreach (var item in _items)
            {
                if (item.Alias == Alias)
                    toReturn = item;
            }
            return toReturn;
        }
        public static IList<Language> GetAllLanguageById(int[] Id)
        {
            IList<Language> languages = new List<Language>();

            foreach (var language in _items)
            {
                for (int i = 0; i < Id.Length; i++)
                {
                    if (language.Id == Id[i])
                        languages.Add(language);
                }
            }

            return languages;
        }
        public static IList<string> GetAllExtentions()
        {
            IList<string> extentions = new List<string>();
            foreach (var language in _items)
            {
                for (int i = 0; i < language.Extention.Length; i++)
                {
                    extentions.Add(language.Extention[i]);
                }
            }
            return extentions;
        }
    }
}
