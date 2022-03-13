using System;
using System.IO;
using System.Reflection;
using AppleWirelessKeyboardCore.Services;
using Microsoft.Win32;

namespace AppleWirelessKeyboardCore.Views

{
    public static class StartupShortcutService
    {
        const string REGISTRY_RUN_KEY = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        const string REGISTRY_RUN_VALUENAME = "AppleWirelessKeyboard";

        public static void Register()
        {
            var rk = Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk?.SetValue(REGISTRY_RUN_VALUENAME,
                Assembly.GetExecutingAssembly().Location.Remove(0, 8).Replace("/", "\\"));
        }

        public static void UnRegister()
        {
            var rk = Registry.CurrentUser.OpenSubKey(REGISTRY_RUN_KEY, true);
            rk?.DeleteValue(REGISTRY_RUN_VALUENAME);
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