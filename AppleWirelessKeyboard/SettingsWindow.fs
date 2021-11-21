namespace AppleWirelessKeyboard

open FUI.WinUI

type A<'t when 't :> Microsoft.UI.Xaml.FrameworkElement> () =
    class end


module SettingsWindow =
    let build () =
        let a : Microsoft.UI.Xaml.FrameworkElement = new Microsoft.UI.Xaml.Controls.Button()
        let b = A<Microsoft.UI.Xaml.Controls.Button>()

        
        Window {
            Title "Settings"

            NavigationView {
                ()
            }
        }

