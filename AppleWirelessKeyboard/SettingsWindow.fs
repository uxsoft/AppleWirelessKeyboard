namespace AppleWirelessKeyboard

open AppleWirelessKeyboard.Pages
open FUI
open FUI.ObservableValue
open FUI.WinUI
open Microsoft.UI

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
        (args: Xaml.Controls.NavigationViewItemInvokedEventArgs) =
        
        let page = args.InvokedItemContainer.Tag |> unbox<int> |> enum 
        model.CurrentPage.Update (fun _ -> page)

    let page (model: Model) (page: Page) (content: Xaml.UIElement) =
        let vis =
            model.CurrentPage
            |> Ov.map (fun p -> if p = page then Xaml.Visibility.Visible else Microsoft.UI.Xaml.Visibility.Collapsed)
            
        Grid {
            Visibility vis
            content
        }
    
    let build () =
        
        let model = initialModel()
                
        Window {
            Title "Settings"
            
            NavigationView {
                PaneDisplayMode Xaml.Controls.NavigationViewPaneDisplayMode.Top
                IsBackButtonVisible Xaml.Controls.NavigationViewBackButtonVisible.Collapsed
                IsSettingsVisible false
                MenuItemsSource [
                    NavigationViewItem { "Preferences"; Tag (int Page.PreferencesPage) } 
                    NavigationViewItem { "Bindings"; Tag (int Page.BindingsPage) } ]
                ItemInvoked (fun sender args -> onItemInvoked model args)
                    
                Grid {
                    page model Page.PreferencesPage (PreferencesPage())
                    page model Page.BindingsPage (BindingsPage())
                }            
            }
        }

