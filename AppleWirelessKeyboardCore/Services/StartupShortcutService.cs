using System;
using System.IO;
using System.Reflection;
using AppleWirelessKeyboardCore.Services;
using Microsoft.Win32;

namespace AppleWirelessKeyboardCore.Views

{
    public static class StartupShortcutService
    {
        private const string REGISTRY_RUN_KEY = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private const string REGISTRY_RUN_VALUENAME = "AppleWirelessKeyboard";

        public static void Register()
        {
            RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk?.SetValue(REGISTRY_RUN_VALUENAME,
                Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8).Replace("/", "\\"));
        }

        public static void UnRegister()
        {
            RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk?.DeleteValue(REGISTRY_RUN_VALUENAME);
        }

        private static string GetShortcutPath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            return Path.Combine(folder, Assembly.GetEntryAssembly()?.GetName()?.Name);
        }

        public static bool IsRegistered
        {
            get
            {
                RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, false);
                return rk?.GetValue(REGISTRY_RUN_VALUENAME) != null;
            }
        }

        public static void Check()
        {
            if (SettingsService.Default.StartupShortcut != IsRegistered)
                if (IsRegistered)
                    UnRegister();
                else Register();
        }
    }
}