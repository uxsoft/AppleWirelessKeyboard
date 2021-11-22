namespace FUI.WinUI

open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open System

type NavigationViewItemBuilder(controlType: Type) =
    inherit NavigationViewItemBaseBuilder(controlType)

    [<CustomOperation("CompactPaneLength")>]
    member _.CompactPaneLength<'v>(x, v: double) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.CompactPaneLengthProperty) NavigationViewItem.CompactPaneLengthProperty v

    [<CustomOperation("CompactPaneLength")>]
    member _.CompactPaneLength<'v>(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.CompactPaneLengthProperty) NavigationViewItem.CompactPaneLengthProperty v


    [<CustomOperation("Icon")>]
    member _.Icon<'v>(x, v: IconElement) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IconProperty) NavigationViewItem.IconProperty v

    [<CustomOperation("Icon")>]
    member _.Icon<'v>(x, v: IconElement IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IconProperty) NavigationViewItem.IconProperty v


    [<CustomOperation("HasUnrealizedChildren")>]
    member _.HasUnrealizedChildren<'v>(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.HasUnrealizedChildrenProperty) NavigationViewItem.HasUnrealizedChildrenProperty v

    [<CustomOperation("HasUnrealizedChildren")>]
    member _.HasUnrealizedChildren<'v>(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.HasUnrealizedChildrenProperty) NavigationViewItem.HasUnrealizedChildrenProperty v


    [<CustomOperation("IsChildSelected")>]
    member _.IsChildSelected<'v>(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IsChildSelectedProperty) NavigationViewItem.IsChildSelectedProperty v

    [<CustomOperation("IsChildSelected")>]
    member _.IsChildSelected<'v>(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IsChildSelectedProperty) NavigationViewItem.IsChildSelectedProperty v


    [<CustomOperation("IsExpanded")>]
    member _.IsExpanded<'v>(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IsExpandedProperty) NavigationViewItem.IsExpandedProperty v

    [<CustomOperation("IsExpanded")>]
    member _.IsExpanded<'v>(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.IsExpandedProperty) NavigationViewItem.IsExpandedProperty v

// MenuItems is read-only, must manage items by adding/removing instead
//    [<CustomOperation("MenuItems")>]
//    member _.MenuItems<'v>(x, v: 'v) =
//        Runtime.dependencyProperty x (nameof NavigationViewItem.MenuItemsProperty) NavigationViewItem.MenuItemsProperty
//
//    [<CustomOperation("MenuItems")>]
//    member _.MenuItems<'v>(x, v: 'v) =
//        Runtime.dependencyProperty x (nameof NavigationViewItem.MenuItemsProperty) NavigationViewItem.MenuItemsProperty


    [<CustomOperation("MenuItemsSource")>]
    member _.MenuItemsSource<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.MenuItemsSourceProperty) NavigationViewItem.MenuItemsSourceProperty v

    [<CustomOperation("MenuItemsSource")>]
    member _.MenuItemsSource<'v>(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.MenuItemsSourceProperty) NavigationViewItem.MenuItemsSourceProperty v


    [<CustomOperation("SelectsOnInvoked")>]
    member _.SelectsOnInvoked<'v>(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.SelectsOnInvokedProperty) NavigationViewItem.SelectsOnInvokedProperty v

    [<CustomOperation("SelectsOnInvoked")>]
    member _.SelectsOnInvoked<'v>(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationViewItem.SelectsOnInvokedProperty) NavigationViewItem.SelectsOnInvokedProperty v

