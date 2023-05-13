using DouaiUWP.Data;

namespace DouaiUWP.ViewModels
{
    public class HistoryVersionViewModel
    {
        private int _itemId;
        public int ItemId
        {
            get
            {
                return _itemId;
            }
        }

        public string DateCreatedHourMinute
        {
            get
            {
                return UpdateRelease;
            }
        }
        public int Id { get; set; }
        public string UpdateRelease { get; set; }
        public string VersionName { get; set; }
        public string Changelog { get; set; }
        public static HistoryVersionViewModel FromItem(HistoryVersion item)
        {
            var viewModel = new HistoryVersionViewModel();

            viewModel.Id = item.Id;
            viewModel.Changelog = item.Changelog;
            viewModel.VersionName = item.VersionName;
            viewModel.UpdateRelease = item.UpdateRelease;

            return viewModel;
        }
    }
}
