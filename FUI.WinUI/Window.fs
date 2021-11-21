namespace FUI.WinUI

open FUI.UiBuilder
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml

type WindowBuilder<'t when 't : equality>() =
    inherit UiBuilder()

    member inline this.Run x =            
        this.RunWithChild<'t> x (fun window child -> (window :?> Window).Content <- child :?> UIElement)

    [<CustomOperation("Title")>]
    member _.Title<'t, 'v>(x, v: string) =
        let setter (a: Window, v') = a.Title <- unbox<string> v'
        let factory () = box ""
        Runtime.property x ("Title") v setter factory