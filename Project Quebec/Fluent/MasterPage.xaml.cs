using Microsoft.Toolkit.Uwp.UI.Controls;
using ProjectQuebec.Code.FileHandle;
using ProjectQuebec.Code.Model;
using ProjectQuebec.Code.Util;
using ProjectQuebec.Fluent.Sidebar;
using ProjectQuebec.Fluent.Sidebar.AboutViews;
using ProjectQuebec.Fluent.Sidebar.SettingsView;
using ProjectQuebec.Fluent.UICode;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.System;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ProjectQuebec.Fluent
{
    public sealed partial class MasterPage : Page, IPage
    {
        public int ViewId { get; set; }
        public static int _tabconter = 0;
        private double defaultControlsWidth = 0.0;
        private CoreApplicationViewTitleBar mainCoreTitleBar;
        private static FileInteraction fileInteraction = new FileInteraction();

        #region APP
        public MasterPage()
        {
            InitializeComponent();

            Loaded += Page_Loaded;
            KeyDown += Editor_KeyDown;
            gridPane.AllowDrop = true;
            gridPane.Drop += MainGrid_Drop;
            gridPane.DragEnter += MainGrid_DragEnter;

            FileOpend.AllFilesList.CollectionChanged += OnCollectionChanged;
            Helpers._openPage.CollectionChanged += OnNewPageCalled;
            Helpers._openFileEvent.CollectionChanged += OnOpenFileEvent;
            Helpers._openChangelog.CollectionChanged += OnChangelogEvent;
            Window.Current.SizeChanged += Current_SizeChanged;

            HamburgerMenuControl.ItemsSource = MenuItem.GetMainItems();
            HamburgerMenuControl.OptionsItemsSource = MenuItem.GetOptionsItems();
            TabsListView.ItemsSource = FileOpend.AllFilesList;
            AllTabsListView.ItemsSource = FileOpend.AllFilesList;

            if (_tabconter == 0)
                GoToWelcome();
            SetAcrylic();

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

            this.SizeChanged += (s, e) =>
            {
                if (e.NewSize.Width < 1000)
                {
                    gridPane.ColumnDefinitions[0].Width = new GridLength(0);
                    gridTabs.ColumnDefinitions[1].Width = new GridLength(0);
                    HamburgerMenuControl.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                }
                else
                {
                    gridPane.ColumnDefinitions[0].Width = new GridLength(335);
                    gridTabs.ColumnDefinitions[1].Width = new GridLength(335);
                    HamburgerMenuControl.DisplayMode = SplitViewDisplayMode.CompactInline;
                    SetAcrylic();
                }

                if (e.NewSize.Width < 700)
                {
                    gridTitleBar.RowDefinitions[0].Height = new GridLength(0);
                    gridTitleBar.RowDefinitions[1].Height = new GridLength(45);
                    gridMobileShell.Visibility = Visibility.Visible;
                    HamburgerMenuControl.DisplayMode = SplitViewDisplayMode.Overlay;

                    if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
                    {
                        try
                        {
                            AcrylicBrush HamburguerColor = new AcrylicBrush()
                            {
                                BackgroundSource = AcrylicBackgroundSource.Backdrop,
                                TintColor = (Application.Current.Resources["rsColorMain60"] as SolidColorBrush).Color,
                                FallbackColor = (Application.Current.Resources["rsColorMain60"] as SolidColorBrush).Color,
                                TintOpacity = 0.6
                            };
                            HamburgerMenuControl.PaneBackground = HamburguerColor;
                            gridTabHamburguer.Background = HamburguerColor;
                        }
                        catch (Exception)
                        {
                            HamburgerMenuControl.PaneBackground = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                            gridTabHamburguer.Background = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                        }
                    }
                    else
                    {
                        HamburgerMenuControl.PaneBackground = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                        gridTabHamburguer.Background = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                    }
                }
                else
                {
                    gridTitleBar.RowDefinitions[0].Height = new GridLength(32);
                    gridTitleBar.RowDefinitions[1].Height = new GridLength(0);
                    gridMobileShell.Visibility = Visibility.Collapsed;

                    if(contentFrame.SourcePageType != typeof(NewFile) || contentFrame.SourcePageType != typeof(Settings) || contentFrame.SourcePageType != typeof(About) || contentFrame.SourcePageType != typeof(Personalization) || contentFrame.SourcePageType != typeof(Options))
                    {
                        if (contentFrame.SourcePageType == null)
                            contentFrame.Navigate(typeof(NewFile));
                        else if (frameEditor.SourcePageType != typeof(Editor) || frameEditor.SourcePageType != typeof(WelcomePage))
                        {
                            if (frameEditor.SourcePageType == typeof(Editor) || frameEditor.SourcePageType == typeof(WelcomePage))
                                contentFrame.Navigate(contentFrame.SourcePageType);
                            else
                                contentFrame.Navigate(frameEditor.SourcePageType);
                        }
                        else
                        {
                            contentFrame.Navigate(typeof(NewFile));
                        }
                    }                    

                    if (FileOpend.CurrentFile.DisplayName != null && frameEditor.SourcePageType != typeof(Editor))
                        frameEditor.Navigate(typeof(Editor), FileOpend.CurrentFile);
                    else if (FileOpend.CurrentFile.DisplayName == null && frameEditor.SourcePageType != typeof(Editor))
                    {
                        if (frameEditor.SourcePageType != typeof(WelcomePage))
                            GoToWelcome();
                    }
                }
            };
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.mainCoreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            this.mainCoreTitleBar.ExtendViewIntoTitleBar = true;
            this.mainCoreTitleBar.LayoutMetricsChanged += TitleBar_LayoutMetricsChanged;
            this.ViewId = ApplicationView.GetForCurrentView().Id;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (FileOpend.CurrentFile == null && e.Parameter != null)
                FileOpend.CurrentFile = (FileObject)e.Parameter;

            if (FileOpend.CurrentFile.DisplayName != null)
            {
                TabsListView.SelectedItem = FileOpend.CurrentFile;
                frameEditor.Navigate(typeof(Editor), FileOpend.CurrentFile);
            }

            ((App)Application.Current).Views.Add(this);
            if (!CoreApplication.GetCurrentView().IsMain)
            {
                //this.TabsListView.ItemsSource = FileOpend.AllFilesList.Where(c => c.Tab == ApplicationView.GetForCurrentView().Id);
                //this.TabsListView.Items.Clear();
                //OpenFile((FileObject)e.Parameter);
                //TODO: Em fileList criar uma lista para cada instancia que esta rodando.
                //O erro que está acontecendo é porque ele está tentando adicionar na TabsView algo que só pode ser adicionado no
                //observable collection (Biding Mode, one way)
                ////_currentFile = (FileObject)e.Parameter;
                ////FileOpend.AllFilesList.Add(_currentFile);
                //this.TabsListView.Items.Add(_currentFile);
            }
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            ((App)Application.Current).Views.Remove(this);
        }

        private void OnMenuItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = e.ClickedItem as MenuItem;

            HamburgerMenuControl.IsPaneOpen = false;
            gridTabs.ColumnDefinitions[0].Width = new GridLength(48);

            if ((contentFrame.SourcePageType != menuItem.PageType) && CanClosePages())
            {
                if (((Frame)Window.Current.Content).ActualWidth >= 700)
                {
                    contentFrame.Navigate(menuItem.PageType, null);
                    gridPane.ColumnDefinitions[0].Width = new GridLength(335);
                    gridTabs.ColumnDefinitions[1].Width = new GridLength(335);
                }
                else
                    frameEditor.Navigate(menuItem.PageType, null);
            }
            else
            {
                if (gridPane.ColumnDefinitions[0].Width == new GridLength(335))
                {
                    gridPane.ColumnDefinitions[0].Width = new GridLength(0);
                    gridTabs.ColumnDefinitions[1].Width = new GridLength(0);
                }
                else
                {
                    gridPane.ColumnDefinitions[0].Width = new GridLength(335);
                    gridTabs.ColumnDefinitions[1].Width = new GridLength(335);
                }
            }
        }
        CoreDispatcher IPage.Dispatcher { get { return this.Dispatcher; } }
        #endregion

        #region _CUSTOPTITLE_
        private void TitleBar_LayoutMetricsChanged(CoreApplicationViewTitleBar sender, object args)
        {
            if (FlowDirection == FlowDirection.LeftToRight)
            {
                gridTabTabs.Margin = new Thickness() { Left = mainCoreTitleBar.SystemOverlayLeftInset, Right = mainCoreTitleBar.SystemOverlayRightInset };
            }
            else
            {
                gridTabTabs.Margin = new Thickness() { Left = mainCoreTitleBar.SystemOverlayRightInset, Right = mainCoreTitleBar.SystemOverlayLeftInset };
            }
            defaultControlsWidth = sender.SystemOverlayRightInset;
            GrapPanel.Height = sender.Height;
            gridTabTabs.Height = sender.Height;
            TabsListView.MaxWidth = Window.Current.Bounds.Width - (defaultControlsWidth + CreateNewTab.ActualWidth);
            Window.Current.SetTitleBar(GrapPanel);
        }
        private void Current_SizeChanged(object sender, WindowSizeChangedEventArgs e)
        {
            double maxWidth = e.Size.Width - (defaultControlsWidth + CreateNewTab.ActualWidth);
            TabsListView.MaxWidth = maxWidth;
        }
        #endregion

        #region DRAGANDDROP
        private async void CreateNewView(object model)
        {
            int newViewId = 0;
            //TODO: BUG, não necessáriamente o arquivo aberto
            //TabsListView.Items.Remove(FileOpend.CurrentFile);
            GoToWelcome();

            CoreApplicationView newView = CoreApplication.CreateNewView();

            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var frame = new Frame();
                frame.Navigate(typeof(MasterPage), FileOpend.CurrentFile);
                Window.Current.Content = frame;
                Window.Current.Activate();
                newViewId = ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }
        private void TabsListView_DragEnter(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Move;
            e.DragUIOverride.IsCaptionVisible = false;
            e.DragUIOverride.IsGlyphVisible = false;
        }
        private async void TabsListView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            if (TabsListView.Items.Count == 1 && !CoreApplication.GetCurrentView().IsMain)
            {
                await ApplicationViewSwitcher.SwitchAsync(((App)Application.Current).Views[0].ViewId, this.ViewId, ApplicationViewSwitchingOptions.ConsolidateViews);
            }
            e.Data.RequestedOperation = DataPackageOperation.Move;

        }
        private async void TabsListView_Drop(object sender, DragEventArgs e)
        {
            var Deferral = e.GetDeferral();

            OpenFile(FileOpend.CurrentFile);

            IPage p = ((App)Application.Current).Views.Single((x) =>
            {
                return x.ViewId == ApplicationView.GetForCurrentView().Id; ;
            });
            //TODO: Include what file to be removed
            await p.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => p.RemoveFile());

            Deferral.Complete();
        }
        private void MainGrid_DragEnter(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Move;
            e.DragUIOverride.IsCaptionVisible = false;
            e.DragUIOverride.IsGlyphVisible = false;
        }
        private async void MainGrid_Drop(object sender, DragEventArgs e)
        {
            if (e.AcceptedOperation == DataPackageOperation.Move)
            {
                try
                {
                    var files = await e.DataView.GetStorageItemsAsync();

                    foreach (StorageFile file in files)
                    {
                        FileObject xFile = FileInteraction.StorageFileToFileObj(file);
                        FileOpend.AllFilesList.Add(xFile);
                        OpenFile(xFile);
                    }
                }
                catch (COMException) //IsTabDropping
                {
                    var Deferral = e.GetDeferral();
                    CoreWindow window = CoreWindow.GetForCurrentThread();
                    //TabsListView.Items.Remove(FileOpend.CurrentFile);
                    await window.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => CreateNewView(FileOpend.CurrentFile));
                    Deferral.Complete();
                }
            }
        }
        #endregion

        #region METHODS
        public void RemoveFile()
        {

        }
        private bool CanClosePages()
        {
            if (contentFrame.Navigate(typeof(Options)) ||
                contentFrame.Navigate(typeof(Personalization)) ||
                contentFrame.Navigate(typeof(NewFile)))
                return true;
            else
                return false;
        }
        public void RemoveFile(FileObject file)
        {
            if (FileOpend.CurrentFile != null)
            {
                _tabconter--;
                FileOpend.AllFilesList.Remove(file);
                FileOpend.CurrentFile = null;
                //this.TabsListView.ItemsSource = FileOpend.AllFilesList.Where(c => c.Tab == ApplicationView.GetForCurrentView().Id);
            }
        }
        public void OpenFile(FileObject file)
        {
            _tabconter++;
            FileOpend.CurrentFile = file;
            btnWelcomePage.Background = new SolidColorBrush(Colors.Transparent);
            frameEditor.Navigate(typeof(Editor), file);
            TabsListView.SelectedItem = file;
        }
        public void GoToWelcome()
        {
            frameEditor.Navigate(typeof(WelcomePage));
            TabsListView.SelectedIndex = -1;
            btnWelcomePage.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
        }
        private void SetAcrylic()
        {
            if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
            {
                try
                {
                    AcrylicBrush Hamburguercolor = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMain60"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColorMain60"] as SolidColorBrush).Color,
                        TintOpacity = 0.6
                    };

                    gridTitleBar.Background = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMain60"] as SolidColorBrush).Color,
                        TintOpacity = 0.7
                    };

                    AcrylicBrush EightPercent = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        TintOpacity = 0.8
                    };

                    gridTabPane.Background = EightPercent;
                    contentFrame.Background = EightPercent;
                    AllTabsListView.Background = EightPercent;
                    HamburgerMenuControl.PaneBackground = Hamburguercolor;
                    gridTabHamburguer.Background = Hamburguercolor;
                }
                catch (Exception)
                {
                    AllTabsListView.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                    HamburgerMenuControl.PaneBackground = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                    contentFrame.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                    gridTitleBar.Background = Application.Current.Resources["rsColorMain60"] as SolidColorBrush;
                    gridTabPane.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                    gridTabHamburguer.Background = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                }
            }
            else
            {
                AllTabsListView.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                HamburgerMenuControl.PaneBackground = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
                contentFrame.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                gridTitleBar.Background = Application.Current.Resources["rsColorMain60"] as SolidColorBrush;
                gridTabPane.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                gridTabHamburguer.Background = Application.Current.Resources["rsColorMain70"] as SolidColorBrush;
            }
        }
        #endregion METHODS

        #region INTERACTIONS
        private void TabsView_Click(object sender, RoutedEventArgs e)
        {
            if (gridMainGrid.ColumnDefinitions[1].Width == new GridLength(0))
                gridMainGrid.ColumnDefinitions[1].Width = new GridLength(250);
            else
                gridMainGrid.ColumnDefinitions[1].Width = new GridLength(0);
        }
        private void btnTabs_Click(object sender, RoutedEventArgs e)
        {
            frameEditor.Navigate(typeof(TabsView));
        }
        private void btnClose_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FileObject file = (FileObject)(sender as Grid).DataContext;
            RemoveFile(file);
        }
        private void btnWelcomePage_Click(object sender, RoutedEventArgs e)
        {
            GoToWelcome();
        }
        private async void CreateNewTab_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TabsListView.Items.Add(FileOpend.AllFilesList[await fileInteraction.OpenFile()]);
                _tabconter++;
            }
            catch (Exception)
            {

            }
        }
        private void TabsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            FileObject fileToOpen = e.ClickedItem as FileObject;
            OpenFile(fileToOpen);
        }
        private void CloseAll_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.CloseAllFiles();
            fileInteraction.CloseAllFiles();
            _tabconter = 0;
        }
        private void SlidableListItem_SwipeStatusChanged(SlidableListItem sender, Microsoft.Toolkit.Uwp.UI.Controls.SwipeStatusChangedEventArgs args)
        {
            var file = (FileObject)sender.DataContext;
            if (args.NewValue == SwipeStatus.Idle)
            {
                if (args.OldValue == SwipeStatus.SwipingPassedLeftThreshold)
                    FileOpend.AllFilesList.Remove(file);
            }
        }
        #endregion INTERACTIONS

        #region EVENTS
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (FileOpend.AllFilesList.Count >= 1)
            {
                //this.TabsListView.ItemsSource = FileOpend.AllFilesList.Where(c => c.Tab == ApplicationView.GetForCurrentView().Id);
                if (FileOpend.GetLastAddedFile().DisplayName != null)
                {
                    OpenFile(FileOpend.GetLastAddedFile());
                    CloseAll.Visibility = Visibility.Visible;
                    TabsView.Visibility = Visibility.Visible;
                }
            }
            else
            {
                GoToWelcome();
                CloseAll.Visibility = Visibility.Collapsed;
                TabsView.Visibility = Visibility.Collapsed;
                _tabconter = 0;
            }

            if (TabsListView.ActualWidth > GrapPanel.ActualWidth - 400)
            {
                ///TODO: Colocar limite de abas abertas
            }
        }
        void OnNewPageCalled(object sender, NotifyCollectionChangedEventArgs e)
        {
            var page = (Type)Helpers._openPage[Helpers._openPage.Count - 1];

            if (((Frame)Window.Current.Content).ActualWidth >= 700)
            {
                if (gridPane.ColumnDefinitions[0].Width == new GridLength(0))
                {
                    gridPane.ColumnDefinitions[0].Width = new GridLength(335);
                    gridTabs.ColumnDefinitions[1].Width = new GridLength(335);
                }

                contentFrame.Navigate(page);
            }
            else
            {
                frameEditor.Navigate(page);
            }
        }
        void OnOpenFileEvent(object sender, NotifyCollectionChangedEventArgs e)
        {
            OpenFile(FileOpend.GetLastAddedFile());
            TabsListView.SelectedItem = FileOpend.CurrentFile;
        }
        void OnChangelogEvent(object sender, NotifyCollectionChangedEventArgs e)
        {
            TabsListView.SelectedIndex = -1;
            btnWelcomePage.Background = new SolidColorBrush(Colors.Transparent);
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                ObservableCollection<ChangelogModel> myCollection = sender as ObservableCollection<ChangelogModel>;
                frameEditor.Navigate(typeof(ChangelogDetails), myCollection[myCollection.Count - 1]);
            }
        }
        private void Editor_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            var view = ApplicationView.GetForCurrentView();
            if (e.Key == VirtualKey.Escape)
            {
                if (view.IsFullScreenMode)
                    view.ExitFullScreenMode();
            }
        }
        #endregion EVENTS

        #region CONTEXTMENU
        private void menuCloseAll_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.CloseAllFiles();
            fileInteraction.CloseAllFiles();
        }
        private void menuCloseTab_Click(object sender, RoutedEventArgs e)
        {
            RemoveFile((FileObject)(sender as MenuFlyoutItem).DataContext);
        }
        private void menuCloseOtherTabs_Click(object sender, RoutedEventArgs e)
        {
            var file = (FileObject)(sender as MenuFlyoutItem).DataContext;
            //TODO: bug que não remove tudo e precisa remover duas vezes, parece ser o for
            fileInteraction.CloseAllButThis(file);
            fileInteraction.CloseAllButThis(file);
        }
        private void menuCloseUnmodified_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.CloseAllButUnmodifed();
            fileInteraction.CloseAllButUnmodifed();

            //TODO: Not getting current file apropriated
            if (FileOpend.CurrentFile.DisplayName.EndsWith("*"))
                TabsListView.SelectedItem = FileOpend.CurrentFile;
        }
        private void menuNewWindows_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void menuSaveThis_Click(object sender, RoutedEventArgs e)
        {
            await fileInteraction.SaveFile((FileObject)(sender as MenuFlyoutItem).DataContext);
        }
        private void menuSaveAll_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.SaveAllFiles();
        }
        private void menuRename_Click(object sender, RoutedEventArgs e)
        {

        }
        private void menuPinFile_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}