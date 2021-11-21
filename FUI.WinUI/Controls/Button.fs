namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open System
open System.Windows.Controls.Primitives

type ButtonBuilder(controlType: Type) =
    inherit ButtonBaseBuilder(controlType)

    [<CustomOperation("Flyout")>]
    member _.Flyout<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Button.FlyoutProperty) Button.FlyoutProperty v