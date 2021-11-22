namespace FUI.WinUI

open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open System
open System.Windows.Controls.Primitives
open Microsoft.UI.Xaml.Controls.Primitives

type ButtonBuilder(controlType: Type) =
    inherit ButtonBaseBuilder(controlType)

    [<CustomOperation("Flyout")>]
    member _.Flyout(x, v: FlyoutBase) =
        Runtime.dependencyProperty x (nameof Button.FlyoutProperty) Button.FlyoutProperty v
        
    [<CustomOperation("Flyout")>]
    member _.Flyout(x, v: FlyoutBase IObservableValue) =
        Runtime.dependencyProperty x (nameof Button.FlyoutProperty) Button.FlyoutProperty v