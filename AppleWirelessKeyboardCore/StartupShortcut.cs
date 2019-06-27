using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace AppleWirelessKeyboardCore
{
    public static class StartupShortcut
    {
        private const string REGISTRY_RUN_KEY = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private const string REGISTRY_RUN_VALUENAME = "AppleWirelessKeyboard";

        public static void Register()
        {
            RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk.SetValue(REGISTRY_RUN_VALUENAME, Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8).Replace("/", "\\"));
        }
        public static void UnRegister()
        {
            RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk.DeleteValue(REGISTRY_RUN_VALUENAME);
        }
        private static string GetShortcutPath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            return Path.Combine(folder, Path.ChangeExtension(Assembly.GetEntryAssembly().GetName().Name, ".appref-ms"));
        }
        public static bool IsRegistered
        {
            get
            {
                RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, false);
                return rk.GetValue(REGISTRY_RUN_VALUENAME) != null;
            }
        }

        public static void Check()
        {
            if (AppleWirelessKeyboard.Properties.Settings.Default.StartupShortcut != IsRegistered)
                if (IsRegistered)
                    UnRegister();
                else Register();
        }
    }
}
