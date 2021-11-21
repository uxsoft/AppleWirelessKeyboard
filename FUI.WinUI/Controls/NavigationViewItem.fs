namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open System

type NavigationViewItemBuilder(controlType: Type) =
    inherit NavigationViewItemBaseBuilder(controlType)

    [<CustomOperation("CompactPaneLength")>]
    member _.CompactPaneLength<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.CompactPaneLengthProperty) NavigationViewItem.CompactPaneLengthProperty

    [<CustomOperation("Icon")>]
    member _.Icon<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IconProperty) NavigationViewItem.IconProperty

    [<CustomOperation("HasUnrealizedChildren")>]
    member _.HasUnrealizedChildren<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.HasUnrealizedChildrenProperty) NavigationViewItem.HasUnrealizedChildrenProperty

    [<CustomOperation("IsChildSelected")>]
    member _.IsChildSelected<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IsChildSelectedProperty) NavigationViewItem.IsChildSelectedProperty

    [<CustomOperation("IsExpanded")>]
    member _.IsExpanded<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IsExpandedProperty) NavigationViewItem.IsExpandedProperty

    [<CustomOperation("MenuItems")>]
    member _.MenuItems<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.MenuItemsProperty) NavigationViewItem.MenuItemsProperty

    [<CustomOperation("MenuItemsSource")>]
    member _.MenuItemsSource<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.MenuItemsSourceProperty) NavigationViewItem.MenuItemsSourceProperty

    [<CustomOperation("SelectsOnInvoked")>]
    member _.SelectsOnInvoked<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.SelectsOnInvokedProperty) NavigationViewItem.SelectsOnInvokedProperty
