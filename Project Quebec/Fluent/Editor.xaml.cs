using ProjectQuebec.Code;
using ProjectQuebec.Code.Extentions;
using ProjectQuebec.Code.FileHandle;
using ProjectQuebec.Code.Util;
using ProjectQuebec.Fluent.Sidebar;
using System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace ProjectQuebec.Fluent
{
    public sealed partial class Editor : Page
    {
        private static FileObject file;
        private static FileInteraction fileInteraction = new FileInteraction();
        ApplicationView view = ApplicationView.GetForCurrentView();

        #region APP
        public Editor()
        {
            this.InitializeComponent();
            if (view.IsFullScreenMode)
                btnFullScreen.Content = "\uE1D9";
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                file = (FileObject)e.Parameter;
                FileOpend.CurrentFile = file;
                webviewEditor.NavigateToString(await EditorCore.EditorSyntax(file));
                txtLanguage.Text = file.FileLanguage.Name;
                if(file.TextEncoding != null)
                    txtEncoding.Text = file.TextEncoding.EncodingName;
            }
            this.KeyDown += Editor_KeyDown;
        }
        #endregion

        #region METHODS
        private async void SaveFile()
        {
            try
            {
                await fileInteraction.SaveFile(file);
            }
            catch (Exception)
            {

            }
        }
        private void SaveAll()
        {
            fileInteraction.SaveAllFiles();
        }
        private async void OpenFile()
        {
            Frame.Navigate(typeof(Editor), FileOpend.AllFilesList[await fileInteraction.OpenFile()]);
            MasterPage._tabconter++;
        }
        private void NewFile()
        {
            Helpers._openPage.Add(typeof(NewFile));
        }
        private void Search()
        {
        }
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

        #region EVENTS
        private void Editor_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Escape)
            {
                var view = ApplicationView.GetForCurrentView();
                if (view.IsFullScreenMode)
                    view.ExitFullScreenMode();
            }
        }
        private async void Editor_ScriptNotify(object sender, NotifyEventArgs e)
        {
            
            string MenssageRecived = e.Value;
            
            if (MenssageRecived.StartsWith("NUMBEROFLINES"))
            {
                if (MenssageRecived.Contains("ISCHANGED=TRUE"))
                {
                    file.ContentWithoutSaving = await webviewEditor.InvokeScriptAsync("eval", new string[] { "editor.getValue('<newlineformula>');" });
                    if (!file.DisplayName.EndsWith("*"))
                        file.DisplayName += "*";
                }

                txtTotalLines.Text = "Total " + MenssageRecived.GetBetween("NUMBEROFLINES=", ";");
            }else if (MenssageRecived.StartsWith("LINE"))
            {
                txtLines.Text = "Ln " + MenssageRecived.GetBetween("LINE=", ";") + ", Col " + MenssageRecived.GetBetween("COLUMN=", ";");
            }
            else if (MenssageRecived.StartsWith("METHOD="))
            {
                switch (MenssageRecived)
                {
                    case "METHOD=OPENFILE;":
                        OpenFile();
                        break;
                    case "METHOD=SAVEFILE;":
                        SaveFile();
                        break;
                    case "METHOD=SAVEALL;":
                        SaveAll();
                        break;
                    case "METHOD=ADDFILE;":
                        NewFile();
                        break;
                    case "METHOD=SEARCH;":
                        Search();
                        break;
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

        #region USERINTERACTION
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NewFile();
        }
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }
        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {
            SaveAll();
        }
        private void btnComment_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnUncomment_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnFormat_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Search();
        }
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            Print();
        }
        private void btnShare_Click(object sender, RoutedEventArgs e)
        {
            Share();
        }
        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            FullScreen();
        }
        #endregion
    }
}
