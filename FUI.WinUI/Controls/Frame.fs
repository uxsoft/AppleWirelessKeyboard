namespace FUI.WinUI

open System.Collections.Generic
open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open Microsoft.UI.Xaml.Navigation

type FrameBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("BackStackDepth")>]
    member _.BackStackDepth(x, v: int) =
        Runtime.dependencyProperty x (nameof Frame.BackStackDepthProperty) Frame.BackStackDepthProperty v

    [<CustomOperation("BackStackDepth")>]
    member _.BackStackDepth(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.BackStackDepthProperty) Frame.BackStackDepthProperty v

    [<CustomOperation("BackStack")>]
    member _.BackStack(x, v: IList<PageStackEntry>) =
        Runtime.dependencyProperty x (nameof Frame.BackStackProperty) Frame.BackStackProperty v

    [<CustomOperation("BackStack")>]
    member _.BackStack(x, v: IList<PageStackEntry> IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.BackStackProperty) Frame.BackStackProperty v

    [<CustomOperation("CacheSize")>]
    member _.CacheSize(x, v: int) =
        Runtime.dependencyProperty x (nameof Frame.CacheSizeProperty) Frame.CacheSizeProperty v

    [<CustomOperation("CacheSize")>]
    member _.CacheSize(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.CacheSizeProperty) Frame.CacheSizeProperty v

    [<CustomOperation("CanGoBack")>]
    member _.CanGoBack(x, v: bool) =
        Runtime.dependencyProperty x (nameof Frame.CanGoBackProperty) Frame.CanGoBackProperty v

    [<CustomOperation("CanGoBack")>]
    member _.CanGoBack(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.CanGoBackProperty) Frame.CanGoBackProperty v

    [<CustomOperation("CanGoForward")>]
    member _.CanGoForward(x, v: bool) =
        Runtime.dependencyProperty x (nameof Frame.CanGoForwardProperty) Frame.CanGoForwardProperty v

    [<CustomOperation("CanGoForward")>]
    member _.CanGoForward(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.CanGoForwardProperty) Frame.CanGoForwardProperty v

    [<CustomOperation("CurrentSourcePageType")>]
    member _.CurrentSourcePageType(x, v: Type) =
        Runtime.dependencyProperty x (nameof Frame.CurrentSourcePageTypeProperty) Frame.CurrentSourcePageTypeProperty v

    [<CustomOperation("CurrentSourcePageType")>]
    member _.CurrentSourcePageType(x, v: Type IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.CurrentSourcePageTypeProperty) Frame.CurrentSourcePageTypeProperty v

    [<CustomOperation("ForwardStack")>]
    member _.ForwardStack(x, v: IList<PageStackEntry>) =
        Runtime.dependencyProperty x (nameof Frame.ForwardStackProperty) Frame.ForwardStackProperty v

    [<CustomOperation("ForwardStack")>]
    member _.ForwardStack(x, v: IList<PageStackEntry> IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.ForwardStackProperty) Frame.ForwardStackProperty v

    [<CustomOperation("IsNavigationStackEnabled")>]
    member _.IsNavigationStackEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof Frame.IsNavigationStackEnabledProperty) Frame.IsNavigationStackEnabledProperty v

    [<CustomOperation("IsNavigationStackEnabled")>]
    member _.IsNavigationStackEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.IsNavigationStackEnabledProperty) Frame.IsNavigationStackEnabledProperty v

    [<CustomOperation("SourcePageType")>]
    member _.SourcePageType(x, v: Type) =
        Runtime.dependencyProperty x (nameof Frame.SourcePageTypeProperty) Frame.SourcePageTypeProperty v
    
    [<CustomOperation("SourcePageType")>]
    member _.SourcePageType(x, v: Type IObservableValue) =
        Runtime.dependencyProperty x (nameof Frame.SourcePageTypeProperty) Frame.SourcePageTypeProperty v
        
        
    [<CustomOperation("Navigated")>]
    member _.Navigated(x, v) =
        Runtime.event x "Navigated" v
            (fun (c: Frame) -> c.add_Navigated)
            (fun (c: Frame) -> c.remove_Navigated)
    
    [<CustomOperation("Navigating")>]
    member _.Navigating(x, v) =
        Runtime.event x "Navigating" v
            (fun (c: Frame) -> c.add_Navigating)
            (fun (c: Frame) -> c.remove_Navigating)
    
    [<CustomOperation("NavigationFailed")>]
    member _.NavigationFailed(x, v) =
        Runtime.event x "NavigationFailed" v
            (fun (c: Frame) -> c.add_NavigationFailed)
            (fun (c: Frame) -> c.remove_NavigationFailed)
    
    [<CustomOperation("NavigationStopped")>]
    member _.NavigationStopped(x, v) =
        Runtime.event x "NavigationStopped" v
            (fun (c: Frame) -> c.add_NavigationStopped)
            (fun (c: Frame) -> c.remove_NavigationStopped)
        
