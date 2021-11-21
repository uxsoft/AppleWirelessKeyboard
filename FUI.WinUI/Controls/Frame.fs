namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System

type FrameBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("AccessKey")>]
    member _.AccessKey<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyProperty) UIElement.AccessKeyProperty v

    [<CustomOperation("BackStackDepth")>]
    member _.BackStackDepth<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.BackStackDepthProperty) Frame.BackStackDepthProperty v

    [<CustomOperation("BackStack")>]
    member _.BackStack<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.BackStackProperty) Frame.BackStackProperty v

    [<CustomOperation("CacheSize")>]
    member _.CacheSize<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.CacheSizeProperty) Frame.CacheSizeProperty v

    [<CustomOperation("CanGoBack")>]
    member _.CanGoBack<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.CanGoBackProperty) Frame.CanGoBackProperty v

    [<CustomOperation("CanGoForward")>]
    member _.CanGoForward<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.CanGoForwardProperty) Frame.CanGoForwardProperty v

    [<CustomOperation("CurrentSourcePageType")>]
    member _.CurrentSourcePageType<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.CurrentSourcePageTypeProperty) Frame.CurrentSourcePageTypeProperty v

    [<CustomOperation("ForwardStack")>]
    member _.ForwardStack<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.ForwardStackProperty) Frame.ForwardStackProperty v

    [<CustomOperation("IsNavigationStackEnabled")>]
    member _.IsNavigationStackEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.IsNavigationStackEnabledProperty) Frame.IsNavigationStackEnabledProperty v

    [<CustomOperation("SourcePageType")>]
    member _.SourcePageType<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Frame.SourcePageTypeProperty) Frame.SourcePageTypeProperty v
