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
            var rk = Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            var shortcut = GetShortcutPath();
            if(shortcut != null)
                rk?.SetValue(REGISTRY_RUN_VALUENAME, shortcut);
        }

        public static void UnRegister()
        {
            var rk = Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk?.DeleteValue(REGISTRY_RUN_VALUENAME);
        }

        private static string? GetShortcutPath()
        {
            return System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName;
        }

        public static bool IsRegistered
        {
            get
            {
                var rk = Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, false);
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