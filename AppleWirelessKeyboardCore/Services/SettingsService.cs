using System;
using System.Collections.Generic;
using System.Text;

namespace AppleWirelessKeyboardCore.Services
{
    public class SettingsService
    {
        public static SettingsService Current { get; set; } = new SettingsService();


        public Language ActiveLanguage { get; set; } = Language.English;

    }
}
