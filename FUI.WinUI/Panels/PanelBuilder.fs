namespace FUI.WinUI

open FUI.UiBuilder
open FUI.ObservableCollection
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open FUI.CollectionChange


type PanelBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    member this.Run x =
        this.RunWithChildren<Panel> x controlType (fun panel (children: IReadOnlyObservableCollection<obj>) ->

            for child in children do
                panel.Children.Add (Runtime.toUIElement child)
        
            children.OnChanged.Add(function
                | CollectionChange.Insert(index, item) ->
                    panel.Children.Insert(index, Runtime.toUIElement item)
                | CollectionChange.Remove(index, _) ->
                    panel.Children.RemoveAt(index))
        )

    [<CustomOperation("Background")>]
    member _.Background<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Panel.BackgroundProperty) Panel.BackgroundProperty v

    [<CustomOperation("ChildrenTransitions")>]
    member _.ChildrenTransitions<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Panel.ChildrenTransitionsProperty) Panel.ChildrenTransitionsProperty v

    [<CustomOperation("IsItemsHost")>]
    member _.IsItemsHost<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Panel.IsItemsHostProperty) Panel.IsItemsHostProperty v
