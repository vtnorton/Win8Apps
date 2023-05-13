using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Data;

namespace ProjectRedmonde.Code
{
    [Bindable]
    public class PhotosDataSource
    {
        private static ObservableCollection<PhotoDataItem> _photos;
        private static ObservableCollection<IEnumerable<PhotoDataItem>> _groupedPhotos;
        public async Task<ObservableCollection<PhotoDataItem>> GetItemsAsync(bool online = false, int maxCount = -1)
        {
            if (_photos == null)
                await LoadAsync(online, maxCount);
            return _photos;
        }
        public async Task<ObservableCollection<IEnumerable<PhotoDataItem>>> GetGroupedItemsAsync(bool online = false, int maxCount = -1){
            if (_groupedPhotos == null)
                await LoadAsync(online, maxCount);
            return _groupedPhotos;
        }
        private static async Task LoadAsync(bool online, int maxCount)
        {
            _photos = new ObservableCollection<PhotoDataItem>();
            _groupedPhotos = new ObservableCollection<IEnumerable<PhotoDataItem>>();
            foreach (var item in await GetPhotosAsync(online))
            {
                _photos.Add(item);
                if (maxCount != -1)
                {
                    maxCount--;
                    if (maxCount == 0)
                        break;
                }
            }
            foreach (var group in _photos.GroupBy(x => x.Category))
                _groupedPhotos.Add(group);
        }
        private static async Task<IEnumerable<PhotoDataItem>> GetPhotosAsync(bool online)
        {
            var uri = new Uri($"ms-appx:///Images/Spotlight/Photos.json");
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            IRandomAccessStreamWithContentType randomStream = await file.OpenReadAsync();
            using (StreamReader r = new StreamReader(randomStream.AsStreamForRead()))
            {
                return Parse(await r.ReadToEndAsync());
            }
        }
        private static IEnumerable<PhotoDataItem> Parse(string jsonData)
        {
            return JsonConvert.DeserializeObject<IList<PhotoDataItem>>(jsonData);
        }

        public static ObservableCollection<PhotoDataItem> SearchPhotos()
        {
            //string[] filePaths = Directory.GetFiles(@"/Images/Spotlight/", "*.jpg");
            //string[] filePaths = Directory.GetFiles(@"ms-appx-web:///Images/Spotlight/", "*.jpg");

            string[] filePaths = Directory.GetFiles(@"ms-appx:///Images/Spotlight/");

            //var uri = new Uri($"ms-appx:///Images/Spotlight/");
            //StorageFolder file = await StorageFolder.GetFileFromApplicationUriAsync(uri);
            //IRandomAccessStreamWithContentType randomStream = await file.OpenReadAsync();

            //StorageFolder appInstalledFolder = Package.Current.InstalledLocation;
            //StorageFolder assets = await GetFolderAsync("Images/Spotlight");

            //IReadOnlyList<StorageFile> files = await assets.GetFilesAsync();

            //foreach (var item in files)
            //{
            //    _photos.Add(new PhotoDataItem { Title = "Untitled", Category = "Uncategorized", Thumbnail = item.Path + item.Name });
            //}

            for (int i = 0; i < filePaths.Length; i++)
            {
                _photos.Add(new PhotoDataItem { Title = "Untitled", Category = "Uncategorized", Thumbnail = filePaths[i] });
            }

            return _photos;
        }
    }
}
