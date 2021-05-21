using System;
using System.Drawing;
using AppleWirelessKeyboardCore.Views;
using Application = System.Windows.Application;
using Hardcodet.Wpf.TaskbarNotification;
using System.Windows.Controls;
using System.Windows;

namespace AppleWirelessKeyboardCore.Services
{
    public static class TrayIconService
    {
        private static TaskbarIcon Icon { get; set; } = CreateIcon();

        public static void Show()
        {
            Icon.Visibility = Visibility.Visible;
        }

        public static void Close()
        {
            Icon.Visibility = Visibility.Collapsed;
        }

        private static TaskbarIcon CreateIcon()
        {
            var contextMenu = new ContextMenu();

            var mnuConfigure = new MenuItem() { Header = TranslationService.Default.Configure };
            mnuConfigure.Click += TriggerConfigure;
            contextMenu.Items.Add(mnuConfigure);

            var mnuRestart = new MenuItem() { Header = TranslationService.Default.Restart };
            mnuRestart.Click += TriggerRestart;
            contextMenu.Items.Add(mnuRestart);

            var mnuRefresh = new MenuItem() { Header = TranslationService.Default.RefreshConnection };
            mnuRefresh.Click += TriggerRefresh;
            contextMenu.Items.Add(mnuRefresh);

            var mnuExit = new MenuItem() { Header = TranslationService.Default.Exit };
            mnuExit.Click += TriggerExit;
            contextMenu.Items.Add(mnuExit);

            var icon = Application.GetResourceStream(new Uri("pack://application:,,,/Gnome-Preferences-Desktop-Keyboard-Shortcuts.ico"))?.Stream;
            return new TaskbarIcon
            {
                ToolTipText = "AppleWirelessKeyboard",
                Icon = icon != null ? new Icon(icon) : null,
                Visibility = Visibility.Collapsed,
                ContextMenu = contextMenu
            };
        }

        private static void TriggerRestart(object sender, EventArgs e)
        {
            var executable = System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName;
            if(executable != null)
            {
                System.Diagnostics.Process.Start(executable);
                Application.Current.Shutdown();
            }
        }

        private static void TriggerConfigure(object sender, EventArgs e)
        {
            new Configuration().Show();
        }

        private static void TriggerExit(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        public static void TriggerRefresh(object sender, EventArgs e)
        {
            //TODO refresh connection
        }
    }
}