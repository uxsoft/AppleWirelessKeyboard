using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using AppleWirelessKeyboardCore.Keyboard;

namespace AppleWirelessKeyboardCore.Services
{
    public class SettingsService
    {
        public static SettingsService Default { get; set; } = Load();

        public event EventHandler? LanguageChanged;

        #region Settings
        private Language _language = Language.English;

        public Language ActiveLanguage
        {
            get => _language;
            set
            {
                _language = value;
                LanguageChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool EnableOverlay { get; set; } = true;
        public bool StartupShortcut { get; set; } = false;
        public List<KeyBinding> KeyBindings { get; set; } = new List<KeyBinding>();
        #endregion

        #region Persistence

        private static string GetStorageFileLocation() => Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData,
            Environment.SpecialFolderOption.Create), "AppleWirelessKeyboard", "settings.xml");

        public void Save()
        {
            var path = GetStorageFileLocation();
            var serializer = new XmlSerializer(typeof(SettingsService));
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            var stream = File.OpenWrite(path);
            serializer.Serialize(stream, this);
        }

        public static SettingsService Load()
        {
            try
            {
                var path = GetStorageFileLocation();
                var serializer = new XmlSerializer(typeof(SettingsService));
                var stream = File.OpenRead(path);
                return (SettingsService) serializer.Deserialize(stream);
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"Failed to load settings ({ex})");
                return new SettingsService();
            }
        }

        #endregion
    }
}