using System.Windows;
using AppleWirelessKeyboardCore.Keyboard;
using AppleWirelessKeyboardCore.Services;
using AppleWirelessKeyboardCore.Views;

namespace AppleWirelessKeyboardCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow Window { get; set; } = new MainWindow();
        public static KeyboardHandler Keyboard { get; set; }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartupShortcutService.Check();
            TrayIconService.Show();
            
            Keyboard = new KeyboardHandler();
            Keyboard.Start();

            Microsoft.Win32.SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        }

        void SystemEvents_PowerModeChanged(object sender, Microsoft.Win32.PowerModeChangedEventArgs e)
        {
            if (e.Mode == Microsoft.Win32.PowerModes.Resume)
            {
                // TODO refresh connection
            }
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            TrayIconService.Close();
            SettingsService.Default.Save();
        }
    }
}
