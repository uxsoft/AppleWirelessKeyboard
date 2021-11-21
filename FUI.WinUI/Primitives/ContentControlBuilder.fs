namespace FUI.WinUI

open FUI.UiBuilder
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System


type ContentControlBuilder(controlType: Type) =
    inherit ControlBuilder(controlType)

    member this.Run x = 
        this.RunWithChild<ContentControl> x controlType (fun control child -> 
            control.Content <- child)
