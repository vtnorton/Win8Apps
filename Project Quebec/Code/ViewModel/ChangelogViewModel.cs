using ProjectQuebec.Code.Model;
using System.Collections.Generic;

namespace ProjectQuebec.Code.ViewModel
{
    public class ChangelogViewModel
    {
        public static List<ChangelogModel> _items = new List<ChangelogModel>()
        {
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 12/14/2017",
                Description = @"General bug fixes and improvements based on feedbacks.",
                VersionName = "v3.1710.371",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 10/21/2017",
                Description = @"Major update with Dark Mode, tabs improvements and a new user interface.",
                VersionName = "v3.1710.363",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 05/15/2017",
                Description = @"An error when opening a tab that was edited and wasn't saved.",
                VersionName = "v2.1705.190",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 05/01/2017",
                Description = @"General improvements and bug fixes",
                VersionName = "v2.1705.189",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 01/01/2017",
                Description = @"Added Swift and Visual Basic support as many other fixes and improvements.",
                VersionName = "v2.1.167",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 10/14/2016",
                Description = @"General improvements and bug fixes, on the feedback area",
                VersionName = "v2.0.151",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 09/30/2016",
                Description = @"This is a big release: see the full changelog.",
                VersionName = "v2.0.62",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 07/08/2016",
                Description = @"New: Json and Phyton support as many fixes",
                VersionName = "v1.2.62",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 06/02/2016",
                Description = @"New: Close all tabs button and more improvementes when closing and saving files, as many others general improvements and bug fixes",
                VersionName = "v1.1.62",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 05/31/2016",
                Description = @"I am fixing bugs, and here are the bugs that was fixed and what was changed.",
                VersionName = "v1.0.54",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 05/30/2016",
                Description = "In this version there are one bug fix.",
                VersionName = "v1.0.51",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 05/30/2016",
                Description = "In this version there are a few changes",
                VersionName = "v1.0.50",
            },
            new ChangelogModel()
            {
                ReleaseDate = "Released at: 05/30/2016",
                Description = "The app was released",
                VersionName = "v1.0.48",
            }
        };
        public static IList<ChangelogModel> GetAllChangelog()
        {
            return _items;
        }
    }
}
