using ProjectQuebec.Code.Model;
using System.Collections.ObjectModel;

namespace ProjectQuebec.Code.Util
{
    public class Helpers
    {
        public static ObservableCollection<int> _openFileEvent = new ObservableCollection<int>();
        public static ObservableCollection<object> _openPage = new ObservableCollection<object>();
        public static ObservableCollection<object[]> _openPageWithAttribute = new ObservableCollection<object[]>();
        public static ObservableCollection<ChangelogModel> _openChangelog = new ObservableCollection<ChangelogModel>();
    }
}
