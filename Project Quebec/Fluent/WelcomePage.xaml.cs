using ProjectQuebec.Code;
using ProjectQuebec.Code.Extentions;
using ProjectQuebec.Code.FileHandle;
using ProjectQuebec.Code.Model;
using ProjectQuebec.Code.Util;
using ProjectQuebec.Code.ViewModel;
using ProjectQuebec.Fluent.Sidebar;
using System;
using System.Net;
using Windows.Networking.Connectivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Web.Syndication;

namespace ProjectQuebec.Fluent
{
    public sealed partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            this.InitializeComponent();
            version.Text = "Version: " + Information.Version();

            listRecentFiles.ItemsSource = RecentListViewModel.RecentList(4);

            if (listRecentFiles.Items.Count > 1)
            {
                hplClean.Visibility = Visibility.Visible;
            }
            if (listRecentFiles.Items.Count == 0)
                NotFound.Visibility = Visibility.Visible;

            ConnectionProfile InternetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();
            bool isWLANConnection = (InternetConnectionProfile == null) ? false : InternetConnectionProfile.IsWlanConnectionProfile;

            if (isWLANConnection)
            {
                GetSyndicationFeed("http://vtnorton.com/category/apps/formula-universal-code-editor/feed");
            }
            else
            {
                progressBar.Visibility = Visibility.Collapsed;
                txtInfo.Visibility = Visibility.Visible;
                txtErroGettingFeed.Visibility = Visibility.Collapsed;
            }
            
            ///TODO: Open folder does not work
            ///TODO: Remove one listitem (recentes) for small screens)
            ///TODO: Minimizar os títulos principais em telas menores que 300 pixels de altura
            ///TODO: Aumentar a lista de recentes para mostrar 25 itens no lugar de news

            this.SizeChanged += (s, e) =>
            {
                Thickness marginGridLinks = gridLinks.Margin;
                Thickness paddingMainGrid = mainGrid.Padding;

                if (e.NewSize.Width < 700)
                {
                    txtProgramName.Text = "Formula";
                    gridWelcome.ColumnDefinitions[1].Width = new GridLength(0);
                    marginGridLinks.Right = 15;
                    paddingMainGrid.Bottom = 15;
                    paddingMainGrid.Top = 35;
                    paddingMainGrid.Right = 25;
                    paddingMainGrid.Left = 25;
                }
                else if (e.NewSize.Width < 1000)
                {
                    gridWelcome.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
                    marginGridLinks.Right = 15;
                    paddingMainGrid.Bottom = 15;
                    paddingMainGrid.Top = 35;
                    paddingMainGrid.Right = 25;
                    paddingMainGrid.Left = 25;
                }
                else
                {
                    txtProgramName.Text = "Formula - Universal Code Editor";
                    gridWelcome.ColumnDefinitions[1].Width = new GridLength(2, GridUnitType.Star);
                    marginGridLinks.Right = 50;
                    paddingMainGrid.Bottom = 25;
                    paddingMainGrid.Top = 35;
                    paddingMainGrid.Right = 50;
                    paddingMainGrid.Left = 50;
                }

                gridLinks.Margin = marginGridLinks;
                mainGrid.Padding = paddingMainGrid;
            };
        }

        public async void GetSyndicationFeed(string feed)
        {
            txtInfo.Visibility = Visibility.Collapsed;
            progressBar.Visibility = Visibility.Visible;
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
                txtInfo.Visibility = Visibility.Collapsed;
                txtErroGettingFeed.Visibility = Visibility.Collapsed;
            }
            catch (Exception)
            {
                progressBar.Visibility = Visibility.Collapsed;
                txtInfo.Visibility = Visibility.Collapsed;
                txtErroGettingFeed.Visibility = Visibility.Visible;
            }
        }

        private async void listRecentFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            RecentList item = (RecentList)e.ClickedItem;
            FileInteraction fileInteraction = new FileInteraction();

            OpenFile(FileOpend.AllFilesList[await fileInteraction.OpenFile(item.Token)]);
        }

        private void OpenFile(FileObject file)
        {
            Frame.Navigate(typeof(Editor), file);
            MasterPage._tabconter++;
        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton hyperlink = (HyperlinkButton)e.OriginalSource;
            RecentList recent = (RecentList)hyperlink.DataContext;

            RecentListViewModel.Remove(recent.Token);
            listRecentFiles.ItemsSource = null;
            listRecentFiles.Items.Clear();
            listRecentFiles.ItemsSource = RecentListViewModel.RecentList(4);
        }

        private void hplClean_Click(object sender, RoutedEventArgs e)
        {
            hplClean.Visibility = Visibility.Collapsed;
            NotFound.Visibility = Visibility.Visible;
            RecentListViewModel.RemoveAll();
            listRecentFiles.ItemsSource = null;
            listRecentFiles.Items.Clear();
        }

        private async void openFile_Click(object sender, RoutedEventArgs e)
        {
            FileInteraction fileInteraction = new FileInteraction();
            int fileindex = await fileInteraction.OpenFile();
            Frame.Navigate(typeof(Editor), FileOpend.AllFilesList[fileindex]);
            MasterPage._tabconter++;
        }

        private void newFile_Click(object sender, RoutedEventArgs e)
        {
            Helpers._openPage.Add(typeof(NewFile));
        }

        private void txtInfo_Click(object sender, RoutedEventArgs e)
        {
            GetSyndicationFeed("http://vtnorton.com/category/apps/formula-universal-code-editor/feed");
        }
    }
}
