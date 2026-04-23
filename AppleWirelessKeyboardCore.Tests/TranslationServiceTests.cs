using System;
using AppleWirelessKeyboardCore.Services;
using Xunit;

namespace AppleWirelessKeyboardCore.Tests
{
    public class TranslationServiceTests
    {
        private static SettingsService CreateSettings(Language language)
        {
            return new SettingsService { ActiveLanguage = language };
        }

        [Fact]
        public void Get_ReturnsCorrectPropertyValue()
        {
            SettingsService.Default = CreateSettings(Language.English);
            var sut = new TranslationService();
            TranslationService.Default = sut;

            var result = sut.Get(nameof(TranslationService.Action));

            Assert.Equal("Action", result);
        }

        [Fact]
        public void Get_UnknownProperty_ReturnsNull()
        {
            SettingsService.Default = CreateSettings(Language.English);
            var sut = new TranslationService();
            TranslationService.Default = sut;

            var result = sut.Get("NonExistentProperty");

            Assert.Null(result);
        }

        [Theory]
        [InlineData(Language.English, "Action")]
        [InlineData(Language.Czech, "Akce")]
        [InlineData(Language.German, "Aktion")]
        public void Action_ReturnsCorrectTranslation(Language language, string expected)
        {
            SettingsService.Default = CreateSettings(language);
            var sut = new TranslationService();
            TranslationService.Default = sut;

            Assert.Equal(expected, sut.Action);
        }

        [Theory]
        [InlineData(Language.English, "Bindings")]
        [InlineData(Language.Czech, "Vazby")]
        [InlineData(Language.German, "Bindungen")]
        public void Bindings_ReturnsCorrectTranslation(Language language, string expected)
        {
            SettingsService.Default = CreateSettings(language);
            var sut = new TranslationService();
            TranslationService.Default = sut;

            Assert.Equal(expected, sut.Bindings);
        }

        [Theory]
        [InlineData(Language.English, "Eject")]
        [InlineData(Language.Czech, "Vysunout")]
        [InlineData(Language.German, "Auswerfen")]
        public void Eject_ReturnsCorrectTranslation(Language language, string expected)
        {
            SettingsService.Default = CreateSettings(language);
            var sut = new TranslationService();
            TranslationService.Default = sut;

            Assert.Equal(expected, sut.Eject);
        }

        [Theory]
        [InlineData(Language.English, "Toggle FMode")]
        [InlineData(Language.Czech, "Přepnout FMode")]
        [InlineData(Language.German, "Knebel FMode")]
        public void ToggleFMode_ReturnsCorrectTranslation(Language language, string expected)
        {
            SettingsService.Default = CreateSettings(language);
            var sut = new TranslationService();
            TranslationService.Default = sut;

            Assert.Equal(expected, sut.ToggleFMode);
        }

        [Fact]
        public void AllProperties_ReturnsNonNullString_ForEveryLanguage()
        {
            foreach (Language language in Enum.GetValues(typeof(Language)))
            {
                SettingsService.Default = CreateSettings(language);
                var sut = new TranslationService();
                TranslationService.Default = sut;

                foreach (var prop in typeof(TranslationService).GetProperties())
                {
                    if (prop.PropertyType != typeof(string)) continue;

                    var value = prop.GetValue(sut) as string;
                    Assert.False(string.IsNullOrWhiteSpace(value),
                        $"Property '{prop.Name}' returned null/empty for language '{language}'");
                }
            }
        }
    }
}
