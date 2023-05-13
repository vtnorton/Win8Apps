using ProjectQuebec.Fluent.Sidebar.SettingsView;
using System;
using System.Collections.Generic;

namespace ProjectQuebec.Fluent.UICode.ListViews
{
    public class SettingsOptions
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Type PageType { get; set; }

        public static List<SettingsOptions> GetMainItems()
        {
            var items = new List<SettingsOptions>
            {
                new SettingsOptions() { Icon = "\uE115", Name = "Options", Description = "Formula for Schools, Language, restore and backup", PageType = typeof(Options) },
                new SettingsOptions() { Icon = "\uE771", Name = "Personalization", Description = "Dark mode, font size and others", PageType = typeof(Personalization) }
            };
            return items;
        }
    }
}
