using ProjectQuebec.Code.LanguageSupport;
using System.Collections.Generic;

namespace ProjectQuebec.Data
{
    public class LanguageCategoryDataSource
    {
        private static List<LanguageCategory> _items = new List<LanguageCategory>()
        {
            new LanguageCategory()
            {
                Id = 0,
                Languages = new int[] {0},
                TypeIcon = "/Images/Icons/All.png",
                TypeName = "All Languages",
                TypeDescription = "Every language that is supported"
            },
            new LanguageCategory()
            {
                Id = 1,
                Languages = new int[] {0, 4, 6, 7, 8, 17},
                TypeIcon = "/Images/Icons/Mobile.png",
                TypeName = "Mobile",
                TypeDescription = "Like: Java and C#, JavaScript"
            },
            new LanguageCategory()
            {
                Id = 2,
                Languages = new int[] {0, 5, 6, 7, 8, 9, 12, 13, 14},
                TypeIcon = "/Images/Icons/Web.png",
                TypeName = "Web",
                TypeDescription = "Some examples are HTML, Javascript, CSS and Asp.Net"
            },
            new LanguageCategory()
            {
                Id = 3,
                Languages = new int[] {0, 3, 4, 13, 18},
                TypeIcon = "/Images/Icons/System.png",
                TypeName = "System languages",
                TypeDescription = "C, C++, Assembler, and more"
            },
            new LanguageCategory()
            {
                Id = 4,
                Languages = new int[] {0, 7, 10, 11, 13, 18},
                TypeIcon = "/Images/Icons/Architetural.png",
                TypeName = "Architetural languages",
                TypeDescription = "Java, C#, and more"
            },
            new LanguageCategory()
            {
                Id = 5,
                Languages = new int[] {0, 4, 7, 8, 10, 12, 13},
                TypeIcon = "/Images/Icons/Application.png",
                TypeName = "Application languages",
                TypeDescription = "PHP, Ruby, Perl, Python and more"
            }
        };
        public static IList<LanguageCategory> GetAllLanguageCategory()
        {
            return _items;
        }
        public static LanguageCategory GetLanguageCategoryById(int Id)
        {
            return _items.Find(item => item.Id == Id);
        }
    }
}
