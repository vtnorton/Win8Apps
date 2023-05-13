using ProjectQuebec.Code.Extentions;
using ProjectQuebec.Code.Model;
using System;
using System.Net;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.Web.Syndication;

namespace ProjectQuebec.Fluent.Sidebar.AboutViews
{
    public sealed partial class News : Page
    {
        public News()
        {
            this.InitializeComponent();
            GetSyndicationFeed("http://vtnorton.com/category/apps/formula-universal-code-editor/feed");

            if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
            {
                try
                {
                    listNews.Background = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColorMain70"] as SolidColorBrush).Color,
                        TintOpacity = 0.9
                    };
                }
                catch (System.Exception)
                {
                    listNews.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                }

            }
            else
            {
                listNews.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
            }
        }
        public async void GetSyndicationFeed(string feed)
        {
            try
            {
                SyndicationClient syndicationClient = new SyndicationClient();
                SyndicationFeed syndicationFeed = await syndicationClient.RetrieveFeedAsync(new Uri(feed));

                for (int i = 0; i < 6; i++)
                {
                    SyndicationItem item = syndicationFeed.Items[i];

                    RSS _rss = new RSS();
                    _rss.Title = item.Title.Text;
                    _rss.Url = item.Id.Replace("http://dev.vtnorton", "http://vtnorton");
                    _rss.Url = item.Id.Replace("http://yapp.vtnorton", "http://vtnorton");
                    _rss.Description = WebUtility.HtmlDecode(item.Summary?.Text.GetBetween("<p>", "</p>").RemoveHTML());

                    listNews.Items.Add(_rss);
                }

                progressBar.Visibility = Visibility.Collapsed;
                listNews.Visibility = Visibility.Visible;
                txtErroGettingFeed.Visibility = Visibility.Collapsed;
            }
            catch (Exception)
            {
                progressBar.Visibility = Visibility.Collapsed;
                txtErroGettingFeed.Visibility = Visibility.Visible;
            }
        }
    }
}
