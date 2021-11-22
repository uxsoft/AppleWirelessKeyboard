using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AppleWirelessKeyboard.WinUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BindingsView : Page
    {
        public BindingsView()
        {
            this.InitializeComponent();
            FrameworkElement el = new Button();
            var button = new Button();
            var navView = new NavigationView();
            var navItem = new NavigationViewItem();
            var frame = new Frame();
            var grid = new Grid();
            var toggle = new ToggleSwitch();
            var textBlock = new TextBlock();
            //var uiElement = new UIElement();
        }
    }
}
