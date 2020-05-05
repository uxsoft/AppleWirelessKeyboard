using System.ComponentModel;

namespace AppleWirelessKeyboardCore.Services
{
    public class TranslationService : INotifyPropertyChanged
    {
        public TranslationService()
        {
            SettingsService.Default.LanguageChanged += (sender, args) =>
            {
                foreach (var property in typeof(TranslationService).GetProperties())
                {
                    Default.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.Name));
                }
            };
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        public static TranslationService Default { get; set; } = new TranslationService();

        public string? Get(string translation)
        {
            return typeof(TranslationService).GetProperty(translation)?.GetValue(Default)?.ToString();
        }
        
        #region Translated Items
        public string Action => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Akce",
            Language.German => "Aktion",
            _ => "Action"
        };

        public string Bindings => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Vazby",
            Language.German => "Bindungen",
            _ => "Bindings"
        };

        public string By => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "od",
            Language.German => "von",
            _ => "by"
        };

        public string CapsLock => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Caps Lock",
            Language.German => "Feststelltaste",
            _ => "Caps Lock"
        };

        public string Configuration => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Konfigurace",
            Language.German => "Einstellungen",
            _ => "Configuration"
        };

        public string Configure => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Konfigurovat",
            Language.German => "Konfigurieren",
            _ => "Configure"
        };

        public string BrightnessDecrease => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Snížit jas",
            Language.German => "Helligkeit verringern",
            _ => "Decrease Brightness"
        };

        public string BrightnessIncrease => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Zvýšit jas",
            Language.German => "Helligkeit erhöhen",
            _ => "Increase Brightness"
        };

        public string Delete => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Smazat",
            Language.German => "Löschen",
            _ => "Delete"
        };

        public string DisplayOverlay => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Zobrazit overlay",
            Language.German => "Overlay anzeigen",
            _ => "Display Overlay"
        };

        public string Eject => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Vysunout",
            Language.German => "Auswerfen",
            _ => "Eject"
        };

        public string Exit => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Odejít",
            Language.German => "Beenden",
            _ => "Exit"
        };

        public string Hibernate => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Hibernace",
            Language.German => "Ruhezustand",
            _ => "Hibernate"
        };

        public string Key => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Klávesa",
            Language.German => "Taste",
            _ => "Key"
        };

        public string NextTract => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Další stopa",
            Language.German => "Nächster Titel",
            _ => "Next Track"
        };

        public string PauseTrack => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Pozastavit/pokračovat",
            Language.German => "Anhalten/Fortsetzen",
            _ => "Pause/Resume"
        };

        public string PreviousTrack => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Předchozí stopa",
            Language.German => "Vorheriger Titel",
            _ => "Previous Track"
        };

        public string RefreshConnection => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Aktualizovat připojení",
            Language.German => "Verbindung zu aktualisieren",
            _ => "Refresh Connection"
        };

        public string Restart => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Restartovat",
            Language.German => "Neu starten",
            _ => "Restart"
        };

        public string Shutdown => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Vypnout",
            Language.German => "ausschalten",
            _ => "Shutdown"
        };
         
        public string StartupShortcut => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Spustit program při spuštění systému",
            Language.German => "",
            _ => "Start program at system start"
        };

        public string TaskManager => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Spuštění programu Správce úloh",
            Language.German => "Starten Sie den Task-Manager",
            _ => "Launch Task Manager"
        };

        public string ToggleFMode => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Přepnout FMode",
            Language.German => "Knebel FMode",
            _ => "Toggle FMode"
        };
         
        public string VolumeDecrease => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Zeslabení hlasitosti",
            Language.German => "Lautstärke verringern",
            _ => "Decrease Volume"
        };

        public string VolumeIncrease => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Zesílení hlasitosti",
            Language.German => "Lautstärke erhöhen",
            _ => "Increase Volume"
        };

        public string VolumeMute => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Ztlumit",
            Language.German => "Ton aus",
            _ => "Mute"
        };

        public string VolumeSwitchDevice => SettingsService.Default.ActiveLanguage switch
        {
            Language.Czech => "Přepnout výstup zvuku",
            Language.German => "Audioausgang umschalten",
            _ => "Switch Audio Output"
        };
        #endregion
    }
}
