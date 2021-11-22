namespace AppleWirelessKeyboard.Pages

open Microsoft.UI.Xaml.Controls
open FUI.WinUI

type PreferencesPage() as this =
    inherit UserControl()
    
    do this.Content <-
        Button { "Preferences page" }