using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Diagnostics;
using System.Timers;
using System.Threading;
using AppleWirelessKeyboard.Keyboard;
using System.ComponentModel.Composition;
using uxsoft.Logging;

namespace AppleWirelessKeyboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow Window { get; set; } = new MainWindow();
        public static KeyboardHandler Keyboard { get; set; }

        public static ILog Log { get; set; } = DependencyInjection.Container.GetExport<ILog>().Value;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartupShortcut.Check();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(AppleWirelessKeyboard.Properties.Settings.Default.Language);
            TrayIcon.Show();
            Keyboard = new KeyboardHandler(new Profile(AppleWirelessKeyboard.Properties.Settings.Default.Profile));
            Keyboard.Start();

            Microsoft.Win32.SystemEvents.PowerModeChanged += new Microsoft.Win32.PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);
        }

        void SystemEvents_PowerModeChanged(object sender, Microsoft.Win32.PowerModeChangedEventArgs e)
        {
            if (e.Mode == Microsoft.Win32.PowerModes.Resume)
            {
                Thread.Sleep(20000);
            }
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            AppleWirelessKeyboard.Properties.Settings.Default.Profile = Keyboard.Profile.ToString();
            AppleWirelessKeyboard.Properties.Settings.Default.Save();
        }
    }
}
