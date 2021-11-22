namespace FUI.WinUI

open FUI.ObservableValue
open FUI.ObservableCollection
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open FUI.CollectionChange
open Microsoft.UI.Xaml.Media

type PanelBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    member this.Run x =
        this.RunWithChildren<Panel> x controlType (fun panel (children: IReadOnlyObservableCollection<obj>) ->

            for child in children do
                panel.Children.Add (toUIElement child)
        
            children.OnChanged.Add(function
                | Insert(index, item) ->
                    panel.Children.Insert(index, toUIElement item)
                | Remove(index, _) ->
                    panel.Children.RemoveAt(index))
        )

    [<CustomOperation("Background")>]
    member _.Background<'v>(x, v: Brush) =
        dependencyProperty x (nameof Panel.BackgroundProperty) Panel.BackgroundProperty v

    [<CustomOperation("Background")>]
    member _.Background<'v>(x, v: Brush IObservableValue) =
        dependencyProperty x (nameof Panel.BackgroundProperty) Panel.BackgroundProperty v


    [<CustomOperation("ChildrenTransitions")>]
    member _.ChildrenTransitions<'v>(x, v: BrushTransition) =
        dependencyProperty x (nameof Panel.ChildrenTransitionsProperty) Panel.ChildrenTransitionsProperty v

    [<CustomOperation("ChildrenTransitions")>]
    member _.ChildrenTransitions<'v>(x, v: BrushTransition IObservableValue) =
        dependencyProperty x (nameof Panel.ChildrenTransitionsProperty) Panel.ChildrenTransitionsProperty v


    [<CustomOperation("IsItemsHost")>]
    member _.IsItemsHost<'v>(x, v: bool) =
        dependencyProperty x (nameof Panel.IsItemsHostProperty) Panel.IsItemsHostProperty v

    [<CustomOperation("IsItemsHost")>]
    member _.IsItemsHost<'v>(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Panel.IsItemsHostProperty) Panel.IsItemsHostProperty v
