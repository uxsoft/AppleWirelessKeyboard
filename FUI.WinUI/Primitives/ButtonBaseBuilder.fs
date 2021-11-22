namespace FUI.WinUI

open System.Windows.Input
open FUI.ObservableValue
open System
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml.Controls.Primitives

type ButtonBaseBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("ClickMode")>]
    member _.ClickMode(x, v: ClickMode) =
        Runtime.dependencyProperty x (nameof ButtonBase.ClickModeProperty) ButtonBase.ClickModeProperty v
    
    [<CustomOperation("ClickMode")>]
    member _.ClickMode(x, v: ClickMode IObservableValue) =
        Runtime.dependencyProperty x (nameof ButtonBase.ClickModeProperty) ButtonBase.ClickModeProperty v
    
    
    [<CustomOperation("CommandParameter")>]
    member _.CommandParameter(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ButtonBase.CommandParameterProperty) ButtonBase.CommandParameterProperty v
    
    [<CustomOperation("CommandParameter")>]
    member _.CommandParameter(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof ButtonBase.CommandParameterProperty) ButtonBase.CommandParameterProperty v
    
    
    [<CustomOperation("Command")>]
    member _.Command(x, v: ICommand) =
        Runtime.dependencyProperty x (nameof ButtonBase.CommandProperty) ButtonBase.CommandProperty v
    
    [<CustomOperation("Command")>]
    member _.Command(x, v: ICommand IObservableValue) =
        Runtime.dependencyProperty x (nameof ButtonBase.CommandProperty) ButtonBase.CommandProperty v
    
    
    [<CustomOperation("IsPointerOver")>]
    member _.IsPointerOver(x, v: bool) =
        Runtime.dependencyProperty x (nameof ButtonBase.IsPointerOverProperty) ButtonBase.IsPointerOverProperty v
    
    [<CustomOperation("IsPointerOver")>]
    member _.IsPointerOver(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof ButtonBase.IsPointerOverProperty) ButtonBase.IsPointerOverProperty v
    
    
    [<CustomOperation("IsPressed")>]
    member _.IsPressed(x, v: bool) =
        Runtime.dependencyProperty x (nameof ButtonBase.IsPressedProperty) ButtonBase.IsPressedProperty v
    
    [<CustomOperation("IsPressed")>]
    member _.IsPressed(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof ButtonBase.IsPressedProperty) ButtonBase.IsPressedProperty v