namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open System

type ButtonBuilder(controlType: Type) =
    inherit ButtonBaseBuilder(controlType)
