namespace FUI.WinUI

open FUI.UiBuilder
open FUI.ObservableValue
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open Microsoft.UI.Xaml.Media.Animation


type ContentControlBuilder(controlType: Type) =
    inherit ControlBuilder(controlType)

    member this.Run x = 
        this.RunWithChild<ContentControl> x controlType (fun control child -> 
            control.Content <- child)


    [<CustomOperation("Content")>]
    member _.Content(x, v: 'v) =
        dependencyProperty x (nameof ContentControl.ContentProperty) ContentControl.ContentProperty v
    
    [<CustomOperation("Content")>]
    member _.Content(x, v: 'v IObservableValue) =
        dependencyProperty x (nameof ContentControl.ContentProperty) ContentControl.ContentProperty v
        
    [<CustomOperation("ContentTemplate")>]
    member _.ContentTemplate(x, v: DataTemplate) =
        dependencyProperty x (nameof ContentControl.ContentTemplateProperty) ContentControl.ContentTemplateProperty v
    
    [<CustomOperation("ContentTemplate")>]
    member _.ContentTemplate(x, v: DataTemplate IObservableValue) =
        dependencyProperty x (nameof ContentControl.ContentTemplateProperty) ContentControl.ContentTemplateProperty v
        
    [<CustomOperation("ContentTemplateSelector")>]
    member _.ContentTemplateSelector(x, v: DataTemplateSelector) =
        dependencyProperty x (nameof ContentControl.ContentTemplateSelectorProperty) ContentControl.ContentTemplateSelectorProperty v
    
    [<CustomOperation("ContentTemplateSelector")>]
    member _.ContentTemplateSelector(x, v: DataTemplateSelector IObservableValue) =
        dependencyProperty x (nameof ContentControl.ContentTemplateSelectorProperty) ContentControl.ContentTemplateSelectorProperty v
        
    [<CustomOperation("ContentTransitions")>]
    member _.ContentTransitions(x, v: TransitionCollection) =
        dependencyProperty x (nameof ContentControl.ContentTransitionsProperty) ContentControl.ContentTransitionsProperty v

    [<CustomOperation("ContentTransitions")>]
    member _.ContentTransitions(x, v: TransitionCollection IObservableValue) =
        dependencyProperty x (nameof ContentControl.ContentTransitionsProperty) ContentControl.ContentTransitionsProperty v
        