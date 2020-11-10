using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AppleWirelessKeyboardCore.Keyboard;

namespace AppleWirelessKeyboardCore.Services
{
    public class SettingsService
    {
        public static SettingsService Default { get; set; } = Load().Result;

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
        public ObservableCollection<KeyBinding> KeyBindings { get; set; } = new();
        #endregion

        #region Persistence


        private static string GetStorageFolderLocation() =>
            Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData,
                Environment.SpecialFolderOption.Create), "AppleWirelessKeyboard");

        private static string GetStorageFileLocation() =>
            Path.Combine(GetStorageFolderLocation(), "settings.xml");

        public async Task SaveAsync()
        {
            Directory.CreateDirectory(GetStorageFolderLocation());
            var stream = File.OpenWrite(GetStorageFileLocation());
            await JsonSerializer.SerializeAsync(stream, this);
        }

        public static async Task<SettingsService> Load()
        {
            try
            {
                var path = GetStorageFileLocation();
                var text = await File.ReadAllTextAsync(path);
                return JsonSerializer.Deserialize<SettingsService>(text) ?? new SettingsService();
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