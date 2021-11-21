using AppleWirelessKeyboard.WinUI.ViewModels;
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

namespace AppleWirelessKeyboard.WinUI.Views
{
    public sealed partial class PreferencesView : Page
    {
        public PreferencesView()
        {
            DataContext = ViewModel;
            InitializeComponent();
        }

        public PreferencesViewModel ViewModel { get; set; } = new();
    }
}
