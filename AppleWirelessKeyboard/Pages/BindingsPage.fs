namespace AppleWirelessKeyboard.Pages

open Microsoft.UI
open FUI.WinUI

type BindingsPage() as this =
    inherit Xaml.Controls.UserControl()
    
    do this.Content <-
        Grid {
            ToggleSwitch {
                Header "first toggle"
            }
            "Bindings page"
        }