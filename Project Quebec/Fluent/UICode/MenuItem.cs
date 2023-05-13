using System;
using System.Collections.Generic;

namespace ProjectQuebec.Fluent.UICode
{
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string SymbolTestName { get; set; }
        public string TextBoxTestName { get; set; }
        public Type PageType { get; set; }

        public static List<MenuItem> _items = new List<MenuItem>();

        public static List<MenuItem> GetMainItems()
        {
            _items.Add(new MenuItem() { Icon = "\uE710", Name = "New File", PageType = typeof(Sidebar.NewFile), TextBoxTestName = "HamburguerTextSettings", SymbolTestName = "HamburguerSymbolSettings" });
            //_items.Add(new MenuItem() { Icon = "\uE923", Name = "Tabs", PageType = typeof(Sidebar.TabsView), TextBoxTestName = "HamburguerTextSettings", SymbolTestName = "HamburguerSymbolSettings" });
            //_items.Add(new MenuItem() { Icon = "\uE838", Name = "Solution Explorer", PageType = typeof(Sidebar.SolutionExplorer), TextBoxTestName = "HamburguerTextSolution", SymbolTestName = "HamburguerSymbolSolution" });
            // _items.Add(new MenuItem() { Icon = "\uE11A", Name = "Search", PageType = typeof(Sidebar.Search), TextBoxTestName = "HamburguerTextSearch", SymbolTestName = "HamburguerSymbolSearch" });
            //_items.Add(new MenuItem() { Icon = "\uEC25", Name = "GitHub", PageType = typeof(Sidebar.GitHub), TextBoxTestName = "HamburguerTextGitHub", SymbolTestName = "HamburguerSymbolGitHub" });
            // _items.Add(new MenuItem() { Icon = "\uEADF", Name = "Tasks", PageType = typeof(Sidebar.Taks), TextBoxTestName = "HamburguerTextTasks", SymbolTestName = "HamburguerSymbolTasks" });

            //if(ApplicationData.Current.LocalSettings.Values["formula4schools"] == null)
            //{
            //    _items.Add(new MenuItem() { Icon = "\uE8F1", Name = "School", PageType = typeof(Sidebar.School), TextBoxTestName = "HamburguerTextSchools", SymbolTestName = "HamburguerSymbolSchools" });
            //}
            //else if(bool.Parse(ApplicationData.Current.LocalSettings.Values["formula4schools"].ToString()))
            //{
            //    _items.Add(new MenuItem() { Icon = "\uE8F1", Name = "School", PageType = typeof(Sidebar.School), TextBoxTestName = "HamburguerTextSchools", SymbolTestName = "HamburguerSymbolSchools" });
            //}

            return _items;
        }

        public static List<MenuItem> GetOptionsItems()
        {
            var items = new List<MenuItem>
            {
                new MenuItem() { Icon = "\uE115", Name = "Settings", PageType = typeof(Sidebar.Settings), TextBoxTestName = "HamburguerTextSettings", SymbolTestName = "HamburguerSymbolSettings" },
               // new MenuItem() { Icon = "\uE11B", Name = "Help", PageType = typeof(Sidebar.Help), TextBoxTestName = "HamburguerTextSettings", SymbolTestName = "HamburguerSymbolHelp" },
                new MenuItem() { Icon = "\uE167", Name = "About", PageType = typeof(Sidebar.About), TextBoxTestName = "HamburguerTextAbout", SymbolTestName = "HamburguerSymbolAbout" }
            };
            return items;
        }
    }
}
