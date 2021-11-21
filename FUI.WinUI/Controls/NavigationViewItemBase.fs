namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open System

type NavigationViewItemBaseBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("IsSelected")>]
    member _.IsSelected<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItemBase.IsSelectedProperty) NavigationViewItemBase.IsSelectedProperty
