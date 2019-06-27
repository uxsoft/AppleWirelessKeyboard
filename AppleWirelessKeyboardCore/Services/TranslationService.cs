using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppleWirelessKeyboardCore.Services
{
    public class TranslationService : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static TranslationService Current { get; set; } = new TranslationService();

        public string Action => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Akce",
            Language.German => "Aktion",
            _ => "Action"
        };

        public string Bindings => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Vazby",
            Language.German => "Bindungen",
            _ => "Bindings"
        };

        public string By => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "od",
            Language.German => "von",
            _ => "by"
        };

        public string CapsLock => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Caps Lock",
            Language.German => "Feststelltaste",
            _ => "Caps Lock"
        };

        public string Configuration => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Konfigurace",
            Language.German => "Einstellungen",
            _ => "Configuration"
        };

        public string Configure => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Konfigurovat",
            Language.German => "Konfigurieren",
            _ => "Configure"
        };

        public string BrightnessDecrease => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Snížit jas",
            Language.German => "Helligkeit verringern",
            _ => "Decrease Brightness"
        };

        public string BrightnessIncrease => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Zvýšit jas",
            Language.German => "Helligkeit erhöhen",
            _ => "Increase Brightness"
        };

        public string Delete => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Smazat",
            Language.German => "Löschen",
            _ => "Delete"
        };

        public string DisplayOverlay => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Zobrazit overlay",
            Language.German => "Overlay anzeigen",
            _ => "Display Overlay"
        };

        public string Eject => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Vysunout",
            Language.German => "Auswerfen",
            _ => "Eject"
        };

        public string Exit => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Odejít",
            Language.German => "Beenden",
            _ => "Exit"
        };

        public string Hibernate => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Hibernace",
            Language.German => "Ruhezustand",
            _ => "Hibernate"
        };

        public string Key => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Klávesa",
            Language.German => "Taste",
            _ => "Key"
        };

        public string NextTract => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Další stopa",
            Language.German => "Nächster Titel",
            _ => "Next Track"
        };

        public string PauseTrack => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Pozastavit/pokračovat",
            Language.German => "Anhalten/Fortsetzen",
            _ => "Pause/Resume"
        };

        public string PreviousTrack => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Předchozí stopa",
            Language.German => "Vorheriger Titel",
            _ => "Previous Track"
        };

        public string RefreshConnection => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Aktualizovat připojení",
            Language.German => "Verbindung zu aktualisieren",
            _ => "Refresh Connection"
        };

        public string Restart => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Restartovat",
            Language.German => "Neu starten",
            _ => "Restart"
        };

        public string Shutdown => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Vypnout",
            Language.German => "ausschalten",
            _ => "Shutdown"
        };
         
        public string StartupShortcut => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Spustit program při spuštění systému",
            Language.German => "",
            _ => "Start program at system start"
        };

        public string TaskManager => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Spuštění programu Správce úloh",
            Language.German => "Starten Sie den Task-Manager",
            _ => "Launch Task Manager"
        };

        public string ToggleFMode => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Přepnout FMode",
            Language.German => "Knebel FMode",
            _ => "Toggle FMode"
        };
         
        public string VolumeDecrease => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Zeslabení hlasitosti",
            Language.German => "Lautstärke verringern",
            _ => "Decrease Volume"
        };

        public string VolumeIncrease => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Zesílení hlasitosti",
            Language.German => "Lautstärke erhöhen",
            _ => "Increase Volume"
        };

        public string VolumeMute => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Ztlumit",
            Language.German => "Ton aus",
            _ => "Mute"
        };

        public string VolumeSwitchDevice => SettingsService.Current.ActiveLanguage switch
        {
            Language.Czech => "Přepnout výstup zvuku",
            Language.German => "Audioausgang umschalten",
            _ => "Switch Audio Output"
        };
    }
}
