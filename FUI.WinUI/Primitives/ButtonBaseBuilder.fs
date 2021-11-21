namespace FUI.WinUI

open FUI.UiBuilder
open System
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml.Controls.Primitives

type ButtonBaseBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("ClickMode")>]
    member _.ClickMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ButtonBase.ClickModeProperty) ButtonBase.ClickModeProperty v
    
    [<CustomOperation("CommandParameter")>]
    member _.CommandParameter<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ButtonBase.CommandParameterProperty) ButtonBase.CommandParameterProperty v
    
    [<CustomOperation("Command")>]
    member _.Command<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ButtonBase.CommandProperty) ButtonBase.CommandProperty v
    
    [<CustomOperation("IsPointerOver")>]
    member _.IsPointerOver<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ButtonBase.IsPointerOverProperty) ButtonBase.IsPointerOverProperty v
    
    [<CustomOperation("IsPressed")>]
    member _.IsPressed<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ButtonBase.IsPressedProperty) ButtonBase.IsPressedProperty v