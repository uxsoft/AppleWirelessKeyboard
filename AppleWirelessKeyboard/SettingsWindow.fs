namespace AppleWirelessKeyboard

open System.Windows
open FUI.ObservableValue
open FUI.WinUI


module SettingsWindow =
    let build () =
        
        Window {
            Title "Settings"

            //Button {
            //    IsPressed true
            //    "Welcome from FUI"
            //}

            NavigationView {
                PaneDisplayMode Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode.Top
                IsBackButtonVisible Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible.Collapsed
                IsSettingsVisible false
                
                ItemInvoked (fun sender args -> MessageBox.Show("Wohooo") |> ignore)

                MenuItemsSource [
                    NavigationViewItem { "Preferences" } 
                    NavigationViewItem { "Bindings" } 
                ]
                
                Frame {
                    ()
                }
            }
        }

