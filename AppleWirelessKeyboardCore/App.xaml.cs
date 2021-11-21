using System.Windows;
using AppleWirelessKeyboardCore.Keyboard;
using AppleWirelessKeyboardCore.Services;
using AppleWirelessKeyboardCore.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppleWirelessKeyboardCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow Window { get; set; } = new MainWindow();
        public static KeyboardHandler Keyboard { get; set; } = new KeyboardHandler();

        void Application_Startup(object sender, StartupEventArgs e)
        {
            StartupShortcutService.Check();
            TrayIconService.Show();
            
            Keyboard.Start();

            Microsoft.Win32.SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;

            StartAnalytics();

            
        }

        void StartAnalytics()
        {
            if (SettingsService.Default.EnableAnalytics == null)
            {
                var answer = MessageBox.Show(
                    TranslationService.Default.EnableAnalytics,
                    TranslationService.Default.EnableAnalyticsCaption,
                    MessageBoxButton.YesNo);

                SettingsService.Default.EnableAnalytics = answer == MessageBoxResult.Yes;
            }

            if (SettingsService.Default.EnableAnalytics == true)
            {
                AppCenter.Start("1201c236-2f12-4dbe-a021-42b7d0cf3aab",
                   typeof(Analytics), typeof(Crashes));
            }
        }

        void SystemEvents_PowerModeChanged(object sender, Microsoft.Win32.PowerModeChangedEventArgs e)
        {
            if (e.Mode == Microsoft.Win32.PowerModes.Resume)
            {
                // TODO refresh connection
            }
        }

        async void Application_Exit(object sender, ExitEventArgs e)
        {
            TrayIconService.Close();
            await SettingsService.Default.SaveAsync();
        }
    }
}
