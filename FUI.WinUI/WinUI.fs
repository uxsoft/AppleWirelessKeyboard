namespace FUI.WinUI

open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls

[<AutoOpen>]
module WinUI =
    let Button = ButtonBuilder(typeof<Button>)
    let NavigationView = NavigationViewBuilder(typeof<NavigationView>)
    let Window = WindowBuilder<Window>()
