module FUI.WinUI.Runtime

open System
open System.Threading
open FUI
open FUI.ObservableValue
open FUI.UiBuilder
open FUI.ObservableCollection
open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls
    
[<CustomEquality; NoComparison>]
type Attribute =
    { Name: string
      Set: obj -> unit
      Clear: obj -> unit }
    
    interface IAttribute
    
    override this.Equals (other: obj) : bool =
        this.Name.Equals other
            
    override this.GetHashCode () =
        this.Name.GetHashCode()
    
let dependencyProperty (x: Node) (name: string) (dp: DependencyProperty) v =
    let set (o: obj) =
        try 
            match box v with
            | :? IObservableValue as ov ->
                ov |> Ov.iter' (fun v -> (o :?> DependencyObject).SetValue(dp, v))
            | _ -> (o :?> DependencyObject).SetValue(dp, v)
        with ex ->
            failwith $"Failed to set dependency property {name} with value {v}"
        
    let clear (o: obj) =
        // TODO clear Ov.iter'
        (o :?> DependencyObject).ClearValue(dp)
    
    let prop = 
        { Name = name
          Set = set
          Clear = clear }
    
    attr prop x
   
let property (x: Node) (name: string) (value: obj) (setter: 't * obj -> unit) (factory: unit -> obj) =
    let set (o: obj) =
        match box value with
        | :? IObservableValue as ov ->
            ov |> Ov.iter' (fun v -> setter ((o :?> 't), v))
        | _ ->  setter ((o :?> 't), value)
        
    let clear (o: obj) =
        // TODO clear Ov.iter'
        setter ((o :?> 't), factory())
    
    let prop = 
        { Name = name
          Set = set
          Clear = clear }
    
    attr prop x

let routedEvent<'t, 'e when 't : equality and 't :> UIElement and 'e :> RoutedEventArgs> (x: Node) (name: string) (routedEvent: RoutedEvent) (handler: 'e -> unit) =
    let mutable cts = new CancellationTokenSource()
        
    let set (o: obj) =
        match o with
        | :? UIElement as el ->
            el.AddHandler(routedEvent, handler, false)
        | _ -> ()
            
    let clear (o: obj) =
        match o with 
        | :? UIElement as el -> 
            el.RemoveHandler(routedEvent, handler)
        | _ -> ()
    
    let prop = 
        { Name = name
          Set = set
          Clear = clear }
    
    attr prop x
    
let dependencyPropertyEvent<'t, 'a when 't : equality and 't :> DependencyObject> (x: Node) (name: string) (dp: DependencyProperty) (handler: DependencyObject -> DependencyProperty -> unit) =
    let mutable handlerId = 0L
        
    let set (o: obj) =
        match o with
        | :? DependencyObject as d ->
            handlerId <- d.RegisterPropertyChangedCallback(dp, DependencyPropertyChangedCallback(handler))
        | _ -> ()
        
    let clear (o: obj) =
        match o with
        | :? DependencyObject as d ->
            d.UnregisterPropertyChangedCallback(dp, handlerId)
        | _ -> ()

    let prop = 
        { Name = name
          Set = set
          Clear = clear }
    
    attr prop x
    
let event<'control, 'handler>
    x
    (name: string)
    (handler: 'handler)
    (addHandler: 'control -> 'handler -> unit)
    (removeHandler: 'control -> 'handler -> unit) =
                
    let set (o: obj) =
        addHandler (o :?> 'control) handler
        
    let clear (o: obj) =
        removeHandler (o :?> 'control) handler
    
    let prop = 
        { Name = name
          Set = set
          Clear = clear }
    
    attr prop x

let addAttribute<'t when 't : equality> (control: obj) (attribute: IAttribute) =
    (attribute :?> Attribute).Set control
    
let removeAttribute<'t when 't : equality> (control: obj) (attribute: IAttribute) =
    (attribute :?> Attribute).Clear control

let toUIElement item =
    match box item with
    | :? UIElement as control -> control
    | _ -> Microsoft.UI.Xaml.Controls.ContentPresenter(Content = item) :> UIElement


type UiBuilder with
    member _.RunWithChildren<'t when 't : equality> (x: Node) (controlType: Type) (setChildren: 't -> IReadOnlyObservableCollection<obj> -> unit) =
        try
            let control = Activator.CreateInstance(controlType) :?> 't

            let attributes = x.Attributes |> Builder.build
            let children = x.Children |> Builder.build
             
            attributes
            |> Oc.iter (addAttribute control) (removeAttribute control)
                
            setChildren control children
                 
            control 
        with e ->
            printfn $"{e}"
            reraise()
            
    member this.RunWithChild<'t when 't : equality> (x: Node) (controlType: Type) (setChild: 't -> obj -> unit) =
        let setChild (control: 't) (children: IReadOnlyObservableCollection<obj>) =
            //TODO Oc.head 
            let set () = 
                children
                |> Seq.tryHead
                |> Option.iter (fun child ->
                    match child with
                    | :? IObservableValue as ov ->
                        Ov.iter' (setChild control) ov
                    | _ -> setChild control child)
            
            set()
            children.OnChanged.Add (fun _ -> set())
            
        this.RunWithChildren<'t> x controlType setChild
        
    member this.RunChildless<'t when 't : equality> (x: Node) (controlType: Type) =
        this.RunWithChildren<'t> x controlType (fun _ _ -> ())
