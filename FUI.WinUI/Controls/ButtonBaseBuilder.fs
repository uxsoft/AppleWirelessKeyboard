namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open System

type ButtonBaseBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)
