module AppleWirelessKeyboard.Pages.Preferences

open Microsoft.UI
open FUI.WinUI
open FUI.ObservableValue

let languages =
    [ "English"; "German"; "Czech" ]
type Model =
    { Language: string var
      EnableOverlay: bool var
      EnableAnalytics: bool var
      EnableStartupShortcut: bool var
      EnableStartupFMode: bool var }
    
let initialModel () =
    { Language = var "English"
      EnableOverlay = var true
      EnableAnalytics = var true
      EnableStartupShortcut = var true
      EnableStartupFMode = var true }

type PreferencesPage() as this =
    inherit Xaml.Controls.UserControl()
    
    let model = initialModel()
    
    do this.Content <-
        Grid {
            StackPanel {
                Margin (Xaml.Thickness(6.))
                Spacing 6.
                
                ComboBox {
                    HorizontalAlignment Xaml.HorizontalAlignment.Stretch
                    PlaceholderText "Language"
                    ItemsSource languages
                    SelectedItem model.Language
                    SelectionChanged (fun sender args ->
                        model.Language.Update (fun _ -> (sender :?> Xaml.Controls.ComboBox).SelectedItem :?> string))
                }

                ToggleSwitch {
                    Header "Overlay"
                    IsOn model.EnableOverlay
                    Toggled (fun sender args ->
                        model.EnableOverlay.Update (fun _ -> (sender :?> Xaml.Controls.ToggleSwitch).IsOn))
                }
                                
                ToggleSwitch {
                    Header "Analytics"
                    IsOn model.EnableAnalytics
                    Toggled (fun sender args ->
                        model.EnableAnalytics.Update (fun _ -> (sender :?> Xaml.Controls.ToggleSwitch).IsOn))
                }
                
                ToggleSwitch {
                    Header "Open automatically after you log into the computer"
                    IsOn model.EnableStartupShortcut
                    Toggled (fun sender args ->
                        model.EnableStartupShortcut.Update (fun _ -> (sender :?> Xaml.Controls.ToggleSwitch).IsOn))
                }
                
                ToggleSwitch {
                    Header "Enable F keys at startup"
                    IsOn model.EnableStartupFMode
                    Toggled (fun sender args ->
                        model.EnableStartupFMode.Update (fun _ -> (sender :?> Xaml.Controls.ToggleSwitch).IsOn))
                }
            }
        }