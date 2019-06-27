using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using AppleWirelessKeyboard.Views;

namespace AppleWirelessKeyboard
{
	public static class TrayIcon
	{
		static TrayIcon()
		{
		}

		public static void Show()
		{
			CreateIcon();
		}

        public static void Close()
        {
            _Icon.Visible = false;
            _Icon.Dispose();
            _Icon = null;
        }

		private static NotifyIcon _Icon = new NotifyIcon();

		private static void CreateIcon()
		{
			_Icon.Text = "AppleWirelessKeyboard";
			_Icon.Icon = new Icon(App.GetResourceStream(new Uri("pack://application:,,,/Gnome-Preferences-Desktop-Keyboard-Shortcuts.ico")).Stream);
			_Icon.Visible = true;

			MenuItem[] menuItems = new[] { 
				new MenuItem(Properties.Resources.Configure, TriggerConfigure),
				new MenuItem(Properties.Resources.Restart, TriggerRestart),
				new MenuItem(Properties.Resources.RefreshConnection, TriggerRefresh),
				new MenuItem(Properties.Resources.Exit, TriggerExit)
			};

			ContextMenu menu = new ContextMenu(menuItems);
			_Icon.ContextMenu = menu;
		}

		private static void TriggerRestart(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(System.Windows.Application.ResourceAssembly.Location);
			System.Windows.Application.Current.Shutdown();
		}
		private static void TriggerConfigure(object sender, EventArgs e)
		{
			(new Configuration()).Show();
		}
		private static void TriggerExit(object sender, EventArgs e)
		{
			App.Current.Shutdown();
		}

		public static void TriggerRefresh(object sender, EventArgs e)
		{
            
		}
	}
}
