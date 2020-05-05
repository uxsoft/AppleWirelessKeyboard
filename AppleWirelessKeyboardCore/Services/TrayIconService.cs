using System;
using System.Drawing;
using System.Windows.Forms;
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

            return new TaskbarIcon
            {
                ToolTipText = "AppleWirelessKeyboard",
                Icon = new Icon(Application
                .GetResourceStream(
                    new Uri("pack://application:,,,/Gnome-Preferences-Desktop-Keyboard-Shortcuts.ico"))?.Stream),
                Visibility = Visibility.Collapsed,
                ContextMenu = contextMenu
            };
        }

        private static void TriggerRestart(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
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