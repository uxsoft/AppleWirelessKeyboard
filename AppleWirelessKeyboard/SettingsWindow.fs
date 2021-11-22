namespace AppleWirelessKeyboard

open System.Windows
open AppleWirelessKeyboard.Pages
open FUI.ObservableValue
open FUI.WinUI

module SettingsWindow =
    
    type Page =
        | PreferencesPage = 0
        | BindingsPage = 1  
    
    type Model =
        { CurrentPage: Page var }
    
    let initialModel () =
        { CurrentPage = var Page.PreferencesPage }
    
    let onItemInvoked
        (model: Model)
        (frame: Microsoft.UI.Xaml.Controls.Frame)
        (args: Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs) =
        
        let page = args.InvokedItemContainer.Tag |> unbox<int> |> enum 
        
        model.CurrentPage.Update (fun _ -> page)

        let targetType =        
            match page with
            | Page.PreferencesPage -> typeof<PreferencesPage>
            | Page.BindingsPage -> typeof<BindingsPage>
            | _ -> typeof<BindingsPage>
            
        let options =
            Microsoft.UI.Xaml.Navigation.FrameNavigationOptions(
                TransitionInfoOverride = args.RecommendedNavigationTransitionInfo)
            
        frame.NavigateToType(targetType, null, options) |> ignore
            
    let build () =
        
        let model = initialModel()
        
        let frame = unbox<Microsoft.UI.Xaml.Controls.Frame> (Frame { () })
        
        Window {
            Title "Settings"
            
            NavigationView {
                PaneDisplayMode Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode.Top
                IsBackButtonVisible Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible.Collapsed
                IsSettingsVisible false
                MenuItemsSource [
                    NavigationViewItem { "Preferences"; Tag (int Page.PreferencesPage) } 
                    NavigationViewItem { "Bindings"; Tag (int Page.BindingsPage) } ]
                ItemInvoked (fun sender args -> onItemInvoked model frame args)
                    
                frame            
            }
        }

