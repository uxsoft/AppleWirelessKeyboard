using AppleWirelessKeyboard.WinUI.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System.Linq;

namespace AppleWirelessKeyboard.WinUI
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Settings";
        }

        private void nav_Loaded(object sender, RoutedEventArgs e)
        {
            nav.SelectedItem = nav.MenuItems.FirstOrDefault();
        }

        private void nav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var targetType = args.SelectedItemContainer.Tag switch
            {
                "bindings" => typeof(BindingsView),
                _ => typeof(PreferencesView)
            };
            var navigationOptions = new FrameNavigationOptions()
            {
                TransitionInfoOverride = args.RecommendedNavigationTransitionInfo
            };

            contentFrame.NavigateToType(targetType, null, navigationOptions);
        }
    }
}
