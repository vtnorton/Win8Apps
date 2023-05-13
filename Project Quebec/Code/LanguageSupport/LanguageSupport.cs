using ProjectQuebec.Data;
using System.Collections.ObjectModel;

namespace ProjectQuebec.Code.LanguageSupport
{
    public class LanguageSupport
    {
        public static Language WhatLanguageItIs(string FileName)
        {
            foreach (var language in LanguageDataSource.GetAllLanguage())
            {
                foreach (var item in language.Extention)
                {
                    if (FileName.EndsWith(item))
                        return LanguageDataSource.GetLanguageByExtention(item);                        
                }
            }

            return null;
        }
    }
}
