using ProjectQuebec.Code.Model;
using ProjectQuebec.Fluent.UICode;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjectQuebec.Fluent.Sidebar.AboutViews
{
    public sealed partial class ChangelogDetails : Page
    {
        ApplicationView view = ApplicationView.GetForCurrentView();
        #region APP
        public ChangelogDetails()
        {
            this.InitializeComponent();
            if (view.IsFullScreenMode)
                btnFullScreen.Content = "\uE1D8";
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                ChangelogModel x = (ChangelogModel)e.Parameter;
                webviewEditor.NavigateToString(await ChangelogHTMLHelper.ChangelogHTML(x));
                txtDate.Text = x.ReleaseDate;
            }
        }
        #endregion

        #region METHODS
        private void Print()
        {

        }
        private void Share()
        {

        }
        private void FullScreen()
        {
            if (view.IsFullScreenMode)
            {
                view.ExitFullScreenMode();
                btnFullScreen.Content = "\uE1D9";
            }
            else
            {
                ///TODO: mensagem de erro se não conseguir
                if (view.TryEnterFullScreenMode())
                    btnFullScreen.Content = "\uE1D8";
            }
        }
        #endregion

        #region INTERACTIONS
        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            FullScreen();
        }

        private void btnShare_Click(object sender, RoutedEventArgs e)
        {
            Share();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            Print();
        }
        #endregion

        #region EVENTS
        private void webviewEditor_ScriptNotify(object sender, NotifyEventArgs e)
        {
            string MenssageRecived = e.Value;
            if (MenssageRecived.StartsWith("METHOD="))
            {
                switch (MenssageRecived)
                {
                    case "METHOD=PRINT;":
                        Print();
                        break;
                    case "METHOD=SHARE;":
                        Share();
                        break;
                    case "METHOD=FULLSCREEN;":
                        FullScreen();
                        break;
                }
            }
        }
        #endregion
    }
}
