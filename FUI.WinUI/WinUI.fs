namespace FUI.WinUI

open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls

[<AutoOpen>]
module WinUI =
    let Button = ButtonBuilder(typeof<Button>)
    let NavigationView = NavigationViewBuilder(typeof<NavigationView>)
    let NavigationViewItem = NavigationViewItemBuilder(typeof<NavigationViewItem>)
    let Frame = FrameBuilder(typeof<Frame>)
    let Window = WindowBuilder(typeof<Window>)
