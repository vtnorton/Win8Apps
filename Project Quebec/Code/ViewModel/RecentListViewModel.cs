using ProjectQuebec.Code.Extentions;
using ProjectQuebec.Code.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.Storage;
using Windows.Storage.AccessCache;

namespace ProjectQuebec.Code.ViewModel
{
    public class RecentListViewModel
    {
        public static StorageItemMostRecentlyUsedList mru = StorageApplicationPermissions.MostRecentlyUsedList;
        private static ObservableCollection<RecentList> _items = new ObservableCollection<RecentList>();

        public static void Add(StorageFile xStoragedFile)
        {

            RecentList recent = new RecentList()
            {
                Token = mru.Add(xStoragedFile, "$NAME:" + xStoragedFile.Name + ";$PATH:" + xStoragedFile.Path + ";"),
                FilePath = xStoragedFile.Path,
                FileName = xStoragedFile.Name
            };

            if (!_items.Any(n => n.FilePath == recent.FilePath))
                _items.Add(recent);

        }

        public static void Remove(string token)
        {
            mru.Remove(token);
            _items.Remove(_items.Where(n => n.Token == token).Single());
        }

        public static void RemoveAll()
        {
            foreach (var item in mru.Entries)
            {
                mru.Remove(item.Token);
            }
            _items = new ObservableCollection<RecentList>();
        }

        public static ObservableCollection<RecentList> RecentList()
        {
            foreach (var item in mru.Entries)
            {
                RecentList recent = new RecentList()
                {
                    Token = item.Token,
                    FilePath = item.Metadata.GetBetween("$PATH:", ";"),
                    FileName = item.Metadata.GetBetween("$NAME:", ";")
                };
                if (!_items.Any(n => n.FilePath == recent.FilePath))
                    _items.Add(recent);
            }
            return _items;
        }

        public static IEnumerable<RecentList> RecentList(int number)
        {
            if (RecentList().Count <= number)
                return RecentList();
            else
                return RecentList().Skip(0).Take(number);
            
            ///TODO: when adding a new (automatically) item, when it was clean, it won't update
        }
    }
}
