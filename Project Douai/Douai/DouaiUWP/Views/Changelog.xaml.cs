using DouaiUWP.Data;
using DouaiUWP.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace DouaiUWP.Views
{
    public sealed partial class Changelog : Page
    {
        private HistoryVersionViewModel _lastSelectedItem;
        public Changelog()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var items = MasterListView.ItemsSource as List<HistoryVersionViewModel>;
            if (items == null)
            {
                items = new List<HistoryVersionViewModel>();
                foreach (var item in HistoryVersionDataSource.GetAllHistoryVersion())
                {
                    items.Add(HistoryVersionViewModel.FromItem(item));
                }
                MasterListView.ItemsSource = items;
            }

            if (e.Parameter != null)
            {
                var id = (int)e.Parameter;
                _lastSelectedItem =
                    items.Where((item) => item.Id == id).FirstOrDefault();
            }
            UpdateForVisualState(AdaptiveStates.CurrentState);
            DisableContentTransitions();
        }
        private void AdaptiveStates_CurrentStateChanged(object sender, VisualStateChangedEventArgs e)
        {
            UpdateForVisualState(e.NewState, e.OldState);
        }
        private void UpdateForVisualState(VisualState newState, VisualState oldState = null)
        {
            var isNarrow = newState == NarrowState;
            if (isNarrow && oldState == DefaultState && _lastSelectedItem != null)
                Frame.Navigate(typeof(ChangelogDetails), _lastSelectedItem.ItemId, new SuppressNavigationTransitionInfo());
            EntranceNavigationTransitionInfo.SetIsTargetElement(MasterListView, isNarrow);
            if (DetailContentPresenter != null)
                EntranceNavigationTransitionInfo.SetIsTargetElement(DetailContentPresenter, !isNarrow);
        }
        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = (HistoryVersionViewModel)e.ClickedItem;
            _lastSelectedItem = clickedItem;
            if (AdaptiveStates.CurrentState == NarrowState)
                Frame.Navigate(typeof(ChangelogDetails), clickedItem.ItemId, new DrillInNavigationTransitionInfo());
            else
                EnableContentTransitions();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            MasterListView.SelectedItem = _lastSelectedItem;
        }
        private void EnableContentTransitions()
        {
            DetailContentPresenter.ContentTransitions.Clear();
            DetailContentPresenter.ContentTransitions.Add(new EntranceThemeTransition());
        }
        private void DisableContentTransitions()
        {
            if (DetailContentPresenter != null)
                DetailContentPresenter.ContentTransitions.Clear();
        }
    }
}
