namespace FUI.WinUI

open FUI.UiBuilder
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml
open System

type WindowBuilder(controlType: Type) =
    inherit UiBuilder()

    member this.Run x =            
        this.RunWithChild<Window> x controlType (fun window child -> window.Content <- Runtime.toUIElement child)

    [<CustomOperation("Title")>]
    member _.Title<'t, 'v>(x, v: string) =
        let setter (a: Window, v') = a.Title <- unbox<string> v'
        let factory () = box ""
        Runtime.property x ("Title") v setter factory