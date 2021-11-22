namespace FUI.WinUI

open System.Collections.Generic
open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open Microsoft.UI.Xaml.Navigation

type ToggleSwitchBuilder(controlType: Type) =
    inherit ControlBuilder(controlType)
        
    [<CustomOperation("Header")>]
    member _.Header(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.HeaderProperty) ToggleSwitch.HeaderProperty v
    
    [<CustomOperation("Header")>]
    member _.Header(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.HeaderProperty) ToggleSwitch.HeaderProperty v
    
        
    [<CustomOperation("HeaderTemplate")>]
    member _.HeaderTemplate(x, v: DataTemplate) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.HeaderTemplateProperty) ToggleSwitch.HeaderTemplateProperty v
    
    [<CustomOperation("HeaderTemplate")>]
    member _.HeaderTemplate(x, v: DataTemplate IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.HeaderTemplateProperty) ToggleSwitch.HeaderTemplateProperty v
    
        
    [<CustomOperation("IsOn")>]
    member _.IsOn(x, v: bool) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.IsOnProperty) ToggleSwitch.IsOnProperty v
    
    [<CustomOperation("IsOn")>]
    member _.IsOn(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.IsOnProperty) ToggleSwitch.IsOnProperty v
    
        
    [<CustomOperation("OffContent")>]
    member _.OffContent(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OffContentProperty) ToggleSwitch.OffContentProperty v
    
    [<CustomOperation("OffContent")>]
    member _.OffContent(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OffContentProperty) ToggleSwitch.OffContentProperty v
    
        
    [<CustomOperation("OffContentTemplate")>]
    member _.OffContentTemplate(x, v: DataTemplate) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OffContentTemplateProperty) ToggleSwitch.OffContentTemplateProperty v
    
    [<CustomOperation("OffContentTemplate")>]
    member _.OffContentTemplate(x, v: DataTemplate IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OffContentTemplateProperty) ToggleSwitch.OffContentTemplateProperty v
    
        
    [<CustomOperation("OnContent")>]
    member _.OnContent(x, v: 'v) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OnContentProperty) ToggleSwitch.OnContentProperty v
    
    [<CustomOperation("OnContent")>]
    member _.OnContent(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OnContentProperty) ToggleSwitch.OnContentProperty v
    
        
    [<CustomOperation("OnContentTemplate")>]
    member _.OnContentTemplate(x, v: DataTemplate) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OnContentTemplateProperty) ToggleSwitch.OnContentTemplateProperty v
    
    [<CustomOperation("OnContentTemplate")>]
    member _.OnContentTemplate(x, v: DataTemplate IObservableValue) =
        Runtime.dependencyProperty x (nameof ToggleSwitch.OnContentTemplateProperty) ToggleSwitch.OnContentTemplateProperty v
     
    [<CustomOperation("Toggled")>]
    member _.Toggled(x, v) =
        Runtime.event x "Toggled" v
            (fun (c: ToggleSwitch) -> c.add_Toggled)
            (fun (c: ToggleSwitch) -> c.remove_Toggled)