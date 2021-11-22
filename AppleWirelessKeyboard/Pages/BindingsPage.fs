namespace AppleWirelessKeyboard.Pages

open Microsoft.UI.Xaml.Controls
open FUI.WinUI

type BindingsPage() as this =
    inherit UserControl()
    
    do this.Content <-
        Button { "Bindings page" }