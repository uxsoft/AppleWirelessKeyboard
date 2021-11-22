namespace FUI.WinUI

open FUI.UiBuilder
open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open System

type NavigationViewItemBaseBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("IsSelected")>]
    member _.IsSelected<'v>(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationViewItemBase.IsSelectedProperty) NavigationViewItemBase.IsSelectedProperty v

    [<CustomOperation("IsSelected")>]
    member _.IsSelected<'v>(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItemBase.IsSelectedProperty) NavigationViewItemBase.IsSelectedProperty v
