namespace FUI.WinUI

open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Media

type FrameworkElementBuilder() =
    inherit UIElementBuilder()

    [<CustomOperation("ActualHeight")>]
    member _.ActualHeight(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.ActualHeightProperty) FrameworkElement.ActualHeightProperty v
    
    [<CustomOperation("ActualHeight")>]
    member _.ActualHeight(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.ActualHeightProperty) FrameworkElement.ActualHeightProperty v
    
        
    [<CustomOperation("ActualTheme")>]
    member _.ActualTheme(x, v: ElementTheme) =
        Runtime.dependencyProperty x (nameof FrameworkElement.ActualThemeProperty) FrameworkElement.ActualThemeProperty v
    
    [<CustomOperation("ActualTheme")>]
    member _.ActualTheme(x, v: ElementTheme IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.ActualThemeProperty) FrameworkElement.ActualThemeProperty v
        
    [<CustomOperation("AllowFocusOnInteraction")>]
    member _.AllowFocusOnInteraction(x, v: bool) =
        Runtime.dependencyProperty x (nameof FrameworkElement.AllowFocusOnInteractionProperty) FrameworkElement.AllowFocusOnInteractionProperty v
    
    [<CustomOperation("AllowFocusOnInteraction")>]
    member _.AllowFocusOnInteraction(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.AllowFocusOnInteractionProperty) FrameworkElement.AllowFocusOnInteractionProperty v
    
        
    [<CustomOperation("AllowFocusWhenDisabled")>]
    member _.AllowFocusWhenDisabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof FrameworkElement.AllowFocusWhenDisabledProperty) FrameworkElement.AllowFocusWhenDisabledProperty v
    
    [<CustomOperation("AllowFocusWhenDisabled")>]
    member _.AllowFocusWhenDisabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.AllowFocusWhenDisabledProperty) FrameworkElement.AllowFocusWhenDisabledProperty v
    
        
    [<CustomOperation("DataContext")>]
    member _.DataContext(x, v: 'v) =
        Runtime.dependencyProperty x (nameof FrameworkElement.DataContextProperty) FrameworkElement.DataContextProperty v
    
    [<CustomOperation("DataContext")>]
    member _.DataContext(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.DataContextProperty) FrameworkElement.DataContextProperty v
    
        
    [<CustomOperation("FlowDirection")>]
    member _.FlowDirection(x, v: FlowDirection) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FlowDirectionProperty) FrameworkElement.FlowDirectionProperty v
    
    [<CustomOperation("FlowDirection")>]
    member _.FlowDirection(x, v: FlowDirection IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FlowDirectionProperty) FrameworkElement.FlowDirectionProperty v
    
        
    [<CustomOperation("FocusVisualMargin")>]
    member _.FocusVisualMargin(x, v: Thickness) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualMarginProperty) FrameworkElement.FocusVisualMarginProperty v
    
    [<CustomOperation("FocusVisualMargin")>]
    member _.FocusVisualMargin(x, v: Thickness IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualMarginProperty) FrameworkElement.FocusVisualMarginProperty v
    
        
    [<CustomOperation("FocusVisualPrimaryBrush")>]
    member _.FocusVisualPrimaryBrush(x, v: Brush) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualPrimaryBrushProperty) FrameworkElement.FocusVisualPrimaryBrushProperty v
    
    [<CustomOperation("FocusVisualPrimaryBrush")>]
    member _.FocusVisualPrimaryBrush(x, v: Brush IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualPrimaryBrushProperty) FrameworkElement.FocusVisualPrimaryBrushProperty v
    
        
    [<CustomOperation("FocusVisualPrimaryThickness")>]
    member _.FocusVisualPrimaryThickness(x, v: Thickness) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualPrimaryThicknessProperty) FrameworkElement.FocusVisualPrimaryThicknessProperty v
    
    [<CustomOperation("FocusVisualPrimaryThickness")>]
    member _.FocusVisualPrimaryThickness(x, v: Thickness IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualPrimaryThicknessProperty) FrameworkElement.FocusVisualPrimaryThicknessProperty v
    
        
    [<CustomOperation("FocusVisualSecondaryBrush")>]
    member _.FocusVisualSecondaryBrush(x, v: Brush) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualSecondaryBrushProperty) FrameworkElement.FocusVisualSecondaryBrushProperty v
    
    [<CustomOperation("FocusVisualSecondaryBrush")>]
    member _.FocusVisualSecondaryBrush(x, v: Brush IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualSecondaryBrushProperty) FrameworkElement.FocusVisualSecondaryBrushProperty v
    
        
    [<CustomOperation("FocusVisualSecondaryThickness")>]
    member _.FocusVisualSecondaryThickness(x, v: Thickness) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualSecondaryThicknessProperty) FrameworkElement.FocusVisualSecondaryThicknessProperty v
    
    [<CustomOperation("FocusVisualSecondaryThickness")>]
    member _.FocusVisualSecondaryThickness(x, v: Thickness IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.FocusVisualSecondaryThicknessProperty) FrameworkElement.FocusVisualSecondaryThicknessProperty v
    
        
    [<CustomOperation("Height")>]
    member _.Height(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.HeightProperty) FrameworkElement.HeightProperty v
    
    [<CustomOperation("Height")>]
    member _.Height(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.HeightProperty) FrameworkElement.HeightProperty v
    
        
    [<CustomOperation("HorizontalAlignment")>]
    member _.HorizontalAlignment(x, v: HorizontalAlignment) =
        Runtime.dependencyProperty x (nameof FrameworkElement.HorizontalAlignmentProperty) FrameworkElement.HorizontalAlignmentProperty v
    
    [<CustomOperation("HorizontalAlignment")>]
    member _.HorizontalAlignment(x, v: HorizontalAlignment IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.HorizontalAlignmentProperty) FrameworkElement.HorizontalAlignmentProperty v
    
        
    [<CustomOperation("Language")>]
    member _.Language(x, v: string) =
        Runtime.dependencyProperty x (nameof FrameworkElement.LanguageProperty) FrameworkElement.LanguageProperty v
    
    [<CustomOperation("Language")>]
    member _.Language(x, v: string IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.LanguageProperty) FrameworkElement.LanguageProperty v
    
        
    [<CustomOperation("Margin")>]
    member _.Margin(x, v: Thickness) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MarginProperty) FrameworkElement.MarginProperty v
    
    [<CustomOperation("Margin")>]
    member _.Margin(x, v: Thickness IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MarginProperty) FrameworkElement.MarginProperty v
    
        
    [<CustomOperation("MaxHeight")>]
    member _.MaxHeight(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MaxHeightProperty) FrameworkElement.MaxHeightProperty v
    
    [<CustomOperation("MaxHeight")>]
    member _.MaxHeight(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MaxHeightProperty) FrameworkElement.MaxHeightProperty v
    
        
    [<CustomOperation("MaxWidth")>]
    member _.MaxWidth(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MaxWidthProperty) FrameworkElement.MaxWidthProperty v
    
    [<CustomOperation("MaxWidth")>]
    member _.MaxWidth(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MaxWidthProperty) FrameworkElement.MaxWidthProperty v
    
        
    [<CustomOperation("MinHeight")>]
    member _.MinHeight(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MinHeightProperty) FrameworkElement.MinHeightProperty v
    
    [<CustomOperation("MinHeight")>]
    member _.MinHeight(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MinHeightProperty) FrameworkElement.MinHeightProperty v
    
        
    [<CustomOperation("MinWidth")>]
    member _.MinWidth(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MinWidthProperty) FrameworkElement.MinWidthProperty v
    
    [<CustomOperation("MinWidth")>]
    member _.MinWidth(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.MinWidthProperty) FrameworkElement.MinWidthProperty v
    
        
    [<CustomOperation("Name")>]
    member _.Name(x, v: string) =
        Runtime.dependencyProperty x (nameof FrameworkElement.NameProperty) FrameworkElement.NameProperty v
    
    [<CustomOperation("Name")>]
    member _.Name(x, v: string IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.NameProperty) FrameworkElement.NameProperty v
    
        
    [<CustomOperation("RequestedTheme")>]
    member _.RequestedTheme(x, v: ElementTheme) =
        Runtime.dependencyProperty x (nameof FrameworkElement.RequestedThemeProperty) FrameworkElement.RequestedThemeProperty v
    
    [<CustomOperation("RequestedTheme")>]
    member _.RequestedTheme(x, v: ElementTheme IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.RequestedThemeProperty) FrameworkElement.RequestedThemeProperty v
    
        
    [<CustomOperation("Style")>]
    member _.Style(x, v: Style) =
        Runtime.dependencyProperty x (nameof FrameworkElement.StyleProperty) FrameworkElement.StyleProperty v
    
    [<CustomOperation("Style")>]
    member _.Style(x, v: Style IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.StyleProperty) FrameworkElement.StyleProperty v
    
        
    [<CustomOperation("Tag")>]
    member _.Tag(x, v: 'v) =
        Runtime.dependencyProperty x (nameof FrameworkElement.TagProperty) FrameworkElement.TagProperty v
    
    [<CustomOperation("Tag")>]
    member _.Tag(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.TagProperty) FrameworkElement.TagProperty v
    
        
    [<CustomOperation("VerticalAlignment")>]
    member _.VerticalAlignment(x, v: VerticalAlignment) =
        Runtime.dependencyProperty x (nameof FrameworkElement.VerticalAlignmentProperty) FrameworkElement.VerticalAlignmentProperty v
    
    [<CustomOperation("VerticalAlignment")>]
    member _.VerticalAlignment(x, v: VerticalAlignment IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.VerticalAlignmentProperty) FrameworkElement.VerticalAlignmentProperty v
    
        
    [<CustomOperation("Width")>]
    member _.Width(x, v: double) =
        Runtime.dependencyProperty x (nameof FrameworkElement.WidthProperty) FrameworkElement.WidthProperty v
    
    [<CustomOperation("Width")>]
    member _.Width(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof FrameworkElement.WidthProperty) FrameworkElement.WidthProperty v
    
    //Grid
    [<CustomOperation("Column")>]
    member _.Column(x, v: int) =
        Runtime.dependencyProperty x (nameof Grid.ColumnProperty) Grid.ColumnProperty v

    [<CustomOperation("Column")>]
    member _.Column(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.ColumnProperty) Grid.ColumnProperty v
        
    [<CustomOperation("ColumnSpan")>]
    member _.ColumnSpan(x, v: int) =
        Runtime.dependencyProperty x (nameof Grid.ColumnSpanProperty) Grid.ColumnSpanProperty v

    [<CustomOperation("ColumnSpan")>]
    member _.ColumnSpan(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.ColumnSpanProperty) Grid.ColumnSpanProperty v
        
    [<CustomOperation("Row")>]
    member _.Row(x, v: int) =
        Runtime.dependencyProperty x (nameof Grid.RowProperty) Grid.RowProperty v

    [<CustomOperation("Row")>]
    member _.Row(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.RowProperty) Grid.RowProperty v
        
    [<CustomOperation("RowSpan")>]
    member _.RowSpan(x, v: int) =
        Runtime.dependencyProperty x (nameof Grid.RowSpanProperty) Grid.RowSpanProperty v

    [<CustomOperation("RowSpan")>]
    member _.RowSpan(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.RowSpanProperty) Grid.RowSpanProperty v

        
    [<CustomOperation("ActualThemeChanged")>]
    member _.ActualThemeChanged(x, v) =
        Runtime.event x "ActualThemeChanged" v
            (fun (c: FrameworkElement) -> c.add_ActualThemeChanged)
            (fun (c: FrameworkElement) -> c.remove_ActualThemeChanged)
            
    [<CustomOperation("DataContextChanged")>]
    member _.DataContextChanged(x, v) =
        Runtime.event x "DataContextChanged" v
            (fun (c: FrameworkElement) -> c.add_DataContextChanged)
            (fun (c: FrameworkElement) -> c.remove_DataContextChanged)
            
    [<CustomOperation("EffectiveViewportChanged")>]
    member _.EffectiveViewportChanged(x, v) =
        Runtime.event x "EffectiveViewportChanged" v
            (fun (c: FrameworkElement) -> c.add_EffectiveViewportChanged)
            (fun (c: FrameworkElement) -> c.remove_EffectiveViewportChanged)
            
    [<CustomOperation("LayoutUpdated")>]
    member _.LayoutUpdated(x, v) =
        Runtime.event x "LayoutUpdated" v
            (fun (c: FrameworkElement) -> c.add_LayoutUpdated)
            (fun (c: FrameworkElement) -> c.remove_LayoutUpdated)
            
    [<CustomOperation("Loaded")>]
    member _.Loaded(x, v) =
        Runtime.event x "Loaded" v
            (fun (c: FrameworkElement) -> c.add_Loaded)
            (fun (c: FrameworkElement) -> c.remove_Loaded)
            
    [<CustomOperation("Loading")>]
    member _.Loading(x, v) =
        Runtime.event x "Loading" v
            (fun (c: FrameworkElement) -> c.add_Loading)
            (fun (c: FrameworkElement) -> c.remove_Loading)
            
    [<CustomOperation("SizeChanged")>]
    member _.SizeChanged(x, v) =
        Runtime.event x "SizeChanged" v
            (fun (c: FrameworkElement) -> c.add_SizeChanged)
            (fun (c: FrameworkElement) -> c.remove_SizeChanged)
            
    [<CustomOperation("Unloaded")>]
    member _.Unloaded(x, v) =
        Runtime.event x "Unloaded" v
            (fun (c: FrameworkElement) -> c.add_Unloaded)
            (fun (c: FrameworkElement) -> c.remove_Unloaded)
        