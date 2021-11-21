namespace FUI.WinUI

open FUI.UiBuilder
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System

type ControlBuilder(controlType: Type) =
    inherit FrameworkElementBuilder()

    member this.Run x = this.RunChildless x controlType
