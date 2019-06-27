using System;
using System.Drawing;
using System.Windows.Forms;
using AppleWirelessKeyboardCore.Views;
using Application = System.Windows.Application;

namespace AppleWirelessKeyboardCore.Services
{
    public static class TrayIconService
    {
        public static void Show()
        {
            Icon = CreateIcon();
        }

        public static void Close()
        {
            Icon.Visible = false;
            Icon.Dispose();
            Icon = null;
        }

        private static NotifyIcon? Icon { get; set; } = null;

        private static NotifyIcon CreateIcon() => new NotifyIcon
        {
            Text = "AppleWirelessKeyboard",
            Icon = new Icon(Application
                .GetResourceStream(
                    new Uri("pack://application:,,,/Gnome-Preferences-Desktop-Keyboard-Shortcuts.ico"))?.Stream),
            Visible = true,
            ContextMenu = new ContextMenu(new[]
            {
                new MenuItem(TranslationService.Default.Configure, TriggerConfigure),
                new MenuItem(TranslationService.Default.Restart, TriggerRestart),
                new MenuItem(TranslationService.Default.RefreshConnection, TriggerRefresh),
                new MenuItem(TranslationService.Default.Exit, TriggerExit)
            })
        };

        private static void TriggerRestart(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private static void TriggerConfigure(object sender, EventArgs e)
        {
            (new Configuration()).Show();
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