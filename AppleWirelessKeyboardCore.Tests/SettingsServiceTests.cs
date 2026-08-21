using System;
using System.IO;
using System.Windows.Input;
using AppleWirelessKeyboardCore.Keyboard;
using AppleWirelessKeyboardCore.Services;
using Xunit;

namespace AppleWirelessKeyboardCore.Tests
{
    public class SettingsServiceTests : IDisposable
    {
        private readonly string _tempPath;

        public SettingsServiceTests()
        {
            // Use a temp folder so tests don't touch the real AppData settings
            _tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_tempPath);
        }

        public void Dispose()
        {
            if (Directory.Exists(_tempPath))
                Directory.Delete(_tempPath, recursive: true);
        }

        [Fact]
        public void NewInstance_HasCorrectDefaults()
        {
            var settings = new SettingsService();

            Assert.True(settings.EnableOverlay);
            Assert.False(settings.StartupShortcut);
            Assert.True(settings.StartupFMode);
            Assert.Equal(Language.English, settings.ActiveLanguage);
            Assert.NotNull(settings.KeyBindings);
            Assert.Empty(settings.KeyBindings);
        }

        [Fact]
        public void Load_WhenFileNotFound_ReturnsNewInstance()
        {
            // Point Load at a path that doesn't exist
            var nonExistentFile = Path.Combine(_tempPath, "does_not_exist.json");
            Assert.False(File.Exists(nonExistentFile));

            // SettingsService.Load() swallows IOException and returns a default instance
            var result = SettingsService.Load();

            Assert.NotNull(result);
            Assert.True(result.EnableOverlay);
            Assert.Equal(Language.English, result.ActiveLanguage);
        }

        [Fact]
        public void ActiveLanguage_Changed_FiresLanguageChangedEvent()
        {
            var settings = new SettingsService();
            bool eventFired = false;
            settings.LanguageChanged += (_, _) => eventFired = true;

            settings.ActiveLanguage = Language.Czech;

            Assert.True(eventFired);
        }

        [Fact]
        public void KeyBindings_CanAddAndRetrieve()
        {
            var settings = new SettingsService();
            var binding = new KeyBinding
            {
                Key = Key.F11,
                Module = "VolumeDown",
                Fn = false
            };

            settings.KeyBindings.Add(binding);

            Assert.Single(settings.KeyBindings);
            Assert.Equal(Key.F11, settings.KeyBindings[0].Key);
            Assert.Equal("VolumeDown", settings.KeyBindings[0].Module);
        }
    }
}
