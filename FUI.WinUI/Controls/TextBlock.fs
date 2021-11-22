namespace FUI.WinUI

open FUI.WinUI.Runtime
open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open Microsoft.UI.Xaml.Controls.Primitives
open Microsoft.UI.Xaml.Media
open Windows.UI.Text

type TextBlockBuilder(controlType: Type) =
    inherit FrameworkElementBuilder()
    
    member this.Run x = this.RunChildless<TextBlock> x controlType

        
    [<CustomOperation("CharacterSpacing")>]
    member _.CharacterSpacing(x, v: int) =
        dependencyProperty x (nameof TextBlock.CharacterSpacingProperty) TextBlock.CharacterSpacingProperty v
    
    [<CustomOperation("CharacterSpacing")>]
    member _.CharacterSpacing(x, v: int IObservableValue) =
        dependencyProperty x (nameof TextBlock.CharacterSpacingProperty) TextBlock.CharacterSpacingProperty v
    
        
    [<CustomOperation("FontFamily")>]
    member _.FontFamily(x, v: FontFamily) =
        dependencyProperty x (nameof TextBlock.FontFamilyProperty) TextBlock.FontFamilyProperty v
    
    [<CustomOperation("FontFamily")>]
    member _.FontFamily(x, v: FontFamily IObservableValue) =
        dependencyProperty x (nameof TextBlock.FontFamilyProperty) TextBlock.FontFamilyProperty v
    
        
    [<CustomOperation("FontSize")>]
    member _.FontSize(x, v: double) =
        dependencyProperty x (nameof TextBlock.FontSizeProperty) TextBlock.FontSizeProperty v
    
    [<CustomOperation("FontSize")>]
    member _.FontSize(x, v: double IObservableValue) =
        dependencyProperty x (nameof TextBlock.FontSizeProperty) TextBlock.FontSizeProperty v
    
        
    [<CustomOperation("FontStretch")>]
    member _.FontStretch(x, v: FontStretch) =
        dependencyProperty x (nameof TextBlock.FontStretchProperty) TextBlock.FontStretchProperty v
    
    [<CustomOperation("FontStretch")>]
    member _.FontStretch(x, v: FontStretch IObservableValue) =
        dependencyProperty x (nameof TextBlock.FontStretchProperty) TextBlock.FontStretchProperty v
    
        
    [<CustomOperation("FontStyle")>]
    member _.FontStyle(x, v: FontStyle) =
        dependencyProperty x (nameof TextBlock.FontStyleProperty) TextBlock.FontStyleProperty v
    
    [<CustomOperation("FontStyle")>]
    member _.FontStyle(x, v: FontStyle IObservableValue) =
        dependencyProperty x (nameof TextBlock.FontStyleProperty) TextBlock.FontStyleProperty v
    
        
    [<CustomOperation("FontWeight")>]
    member _.FontWeight(x, v: FontWeight) =
        dependencyProperty x (nameof TextBlock.FontWeightProperty) TextBlock.FontWeightProperty v
    
    [<CustomOperation("FontWeight")>]
    member _.FontWeight(x, v: FontWeight IObservableValue) =
        dependencyProperty x (nameof TextBlock.FontWeightProperty) TextBlock.FontWeightProperty v
    
        
    [<CustomOperation("Foreground")>]
    member _.Foreground(x, v: Brush) =
        dependencyProperty x (nameof TextBlock.ForegroundProperty) TextBlock.ForegroundProperty v
    
    [<CustomOperation("Foreground")>]
    member _.Foreground(x, v: Brush IObservableValue) =
        dependencyProperty x (nameof TextBlock.ForegroundProperty) TextBlock.ForegroundProperty v
    
        
    [<CustomOperation("HorizontalTextAlignment")>]
    member _.HorizontalTextAlignment(x, v: TextAlignment) =
        dependencyProperty x (nameof TextBlock.HorizontalTextAlignmentProperty) TextBlock.HorizontalTextAlignmentProperty v
    
    [<CustomOperation("HorizontalTextAlignment")>]
    member _.HorizontalTextAlignment(x, v: TextAlignment IObservableValue) =
        dependencyProperty x (nameof TextBlock.HorizontalTextAlignmentProperty) TextBlock.HorizontalTextAlignmentProperty v
    
        
    [<CustomOperation("IsColorFontEnabled")>]
    member _.IsColorFontEnabled(x, v: bool) =
        dependencyProperty x (nameof TextBlock.IsColorFontEnabledProperty) TextBlock.IsColorFontEnabledProperty v
    
    [<CustomOperation("IsColorFontEnabled")>]
    member _.IsColorFontEnabled(x, v: bool IObservableValue) =
        dependencyProperty x (nameof TextBlock.IsColorFontEnabledProperty) TextBlock.IsColorFontEnabledProperty v
    
        
    [<CustomOperation("IsTextScaleFactorEnabled")>]
    member _.IsTextScaleFactorEnabled(x, v: bool) =
        dependencyProperty x (nameof TextBlock.IsTextScaleFactorEnabledProperty) TextBlock.IsTextScaleFactorEnabledProperty v
    
    [<CustomOperation("IsTextScaleFactorEnabled")>]
    member _.IsTextScaleFactorEnabled(x, v: bool IObservableValue) =
        dependencyProperty x (nameof TextBlock.IsTextScaleFactorEnabledProperty) TextBlock.IsTextScaleFactorEnabledProperty v
    
        
    [<CustomOperation("IsTextSelectionEnabled")>]
    member _.IsTextSelectionEnabled(x, v: bool) =
        dependencyProperty x (nameof TextBlock.IsTextSelectionEnabledProperty) TextBlock.IsTextSelectionEnabledProperty v
    
    [<CustomOperation("IsTextSelectionEnabled")>]
    member _.IsTextSelectionEnabled(x, v: bool IObservableValue) =
        dependencyProperty x (nameof TextBlock.IsTextSelectionEnabledProperty) TextBlock.IsTextSelectionEnabledProperty v
    
        
    [<CustomOperation("IsTextTrimmed")>]
    member _.IsTextTrimmed(x, v: bool) =
        dependencyProperty x (nameof TextBlock.IsTextTrimmedProperty) TextBlock.IsTextTrimmedProperty v
    
    [<CustomOperation("IsTextTrimmed")>]
    member _.IsTextTrimmed(x, v: bool IObservableValue) =
        dependencyProperty x (nameof TextBlock.IsTextTrimmedProperty) TextBlock.IsTextTrimmedProperty v
    
        
    [<CustomOperation("LineHeight")>]
    member _.LineHeight(x, v: double) =
        dependencyProperty x (nameof TextBlock.LineHeightProperty) TextBlock.LineHeightProperty v
    
    [<CustomOperation("LineHeight")>]
    member _.LineHeight(x, v: double IObservableValue) =
        dependencyProperty x (nameof TextBlock.LineHeightProperty) TextBlock.LineHeightProperty v
    
        
    [<CustomOperation("LineStackingStrategy")>]
    member _.LineStackingStrategy(x, v: LineStackingStrategy) =
        dependencyProperty x (nameof TextBlock.LineStackingStrategyProperty) TextBlock.LineStackingStrategyProperty v
    
    [<CustomOperation("LineStackingStrategy")>]
    member _.LineStackingStrategy(x, v: LineStackingStrategy IObservableValue) =
        dependencyProperty x (nameof TextBlock.LineStackingStrategyProperty) TextBlock.LineStackingStrategyProperty v
    
        
    [<CustomOperation("MaxLines")>]
    member _.MaxLines(x, v: int) =
        dependencyProperty x (nameof TextBlock.MaxLinesProperty) TextBlock.MaxLinesProperty v
    
    [<CustomOperation("MaxLines")>]
    member _.MaxLines(x, v: int IObservableValue) =
        dependencyProperty x (nameof TextBlock.MaxLinesProperty) TextBlock.MaxLinesProperty v
    
        
    [<CustomOperation("OpticalMarginAlignment")>]
    member _.OpticalMarginAlignment(x, v: OpticalMarginAlignment) =
        dependencyProperty x (nameof TextBlock.OpticalMarginAlignmentProperty) TextBlock.OpticalMarginAlignmentProperty v
    
    [<CustomOperation("OpticalMarginAlignment")>]
    member _.OpticalMarginAlignment(x, v: OpticalMarginAlignment IObservableValue) =
        dependencyProperty x (nameof TextBlock.OpticalMarginAlignmentProperty) TextBlock.OpticalMarginAlignmentProperty v
    
        
    [<CustomOperation("Padding")>]
    member _.Padding(x, v: Thickness) =
        dependencyProperty x (nameof TextBlock.PaddingProperty) TextBlock.PaddingProperty v
    
    [<CustomOperation("Padding")>]
    member _.Padding(x, v: Thickness IObservableValue) =
        dependencyProperty x (nameof TextBlock.PaddingProperty) TextBlock.PaddingProperty v
    
        
    [<CustomOperation("SelectedText")>]
    member _.SelectedText(x, v: string) =
        dependencyProperty x (nameof TextBlock.SelectedTextProperty) TextBlock.SelectedTextProperty v
    
    [<CustomOperation("SelectedText")>]
    member _.SelectedText(x, v: string IObservableValue) =
        dependencyProperty x (nameof TextBlock.SelectedTextProperty) TextBlock.SelectedTextProperty v
    
        
    [<CustomOperation("SelectionFlyout")>]
    member _.SelectionFlyout(x, v: FlyoutBase) =
        dependencyProperty x (nameof TextBlock.SelectionFlyoutProperty) TextBlock.SelectionFlyoutProperty v
    
    [<CustomOperation("SelectionFlyout")>]
    member _.SelectionFlyout(x, v: FlyoutBase IObservableValue) =
        dependencyProperty x (nameof TextBlock.SelectionFlyoutProperty) TextBlock.SelectionFlyoutProperty v
    
        
    [<CustomOperation("SelectionHighlightColor")>]
    member _.SelectionHighlightColor(x, v: SolidColorBrush) =
        dependencyProperty x (nameof TextBlock.SelectionHighlightColorProperty) TextBlock.SelectionHighlightColorProperty v
    
    [<CustomOperation("SelectionHighlightColor")>]
    member _.SelectionHighlightColor(x, v: SolidColorBrush IObservableValue) =
        dependencyProperty x (nameof TextBlock.SelectionHighlightColorProperty) TextBlock.SelectionHighlightColorProperty v
    
        
    [<CustomOperation("TextAlignment")>]
    member _.TextAlignment(x, v: TextAlignment) =
        dependencyProperty x (nameof TextBlock.TextAlignmentProperty) TextBlock.TextAlignmentProperty v
    
    [<CustomOperation("TextAlignment")>]
    member _.TextAlignment(x, v: TextAlignment IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextAlignmentProperty) TextBlock.TextAlignmentProperty v
    
        
    [<CustomOperation("TextDecorations")>]
    member _.TextDecorations(x, v: TextDecorations) =
        dependencyProperty x (nameof TextBlock.TextDecorationsProperty) TextBlock.TextDecorationsProperty v
    
    [<CustomOperation("TextDecorations")>]
    member _.TextDecorations(x, v: TextDecorations IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextDecorationsProperty) TextBlock.TextDecorationsProperty v
    
        
    [<CustomOperation("TextLineBounds")>]
    member _.TextLineBounds(x, v: TextLineBounds) =
        dependencyProperty x (nameof TextBlock.TextLineBoundsProperty) TextBlock.TextLineBoundsProperty v
    
    [<CustomOperation("TextLineBounds")>]
    member _.TextLineBounds(x, v: TextLineBounds IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextLineBoundsProperty) TextBlock.TextLineBoundsProperty v
    
        
    [<CustomOperation("Text")>]
    member _.Text(x, v: string) =
        dependencyProperty x (nameof TextBlock.TextProperty) TextBlock.TextProperty v
    
    [<CustomOperation("Text")>]
    member _.Text(x, v: string IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextProperty) TextBlock.TextProperty v
    
        
    [<CustomOperation("TextReadingOrder")>]
    member _.TextReadingOrder(x, v: TextReadingOrder) =
        dependencyProperty x (nameof TextBlock.TextReadingOrderProperty) TextBlock.TextReadingOrderProperty v
    
    [<CustomOperation("TextReadingOrder")>]
    member _.TextReadingOrder(x, v: TextReadingOrder IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextReadingOrderProperty) TextBlock.TextReadingOrderProperty v
    
        
    [<CustomOperation("TextTrimming")>]
    member _.TextTrimming(x, v: TextTrimming) =
        dependencyProperty x (nameof TextBlock.TextTrimmingProperty) TextBlock.TextTrimmingProperty v
    
    [<CustomOperation("TextTrimming")>]
    member _.TextTrimming(x, v: TextTrimming IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextTrimmingProperty) TextBlock.TextTrimmingProperty v
    
        
    [<CustomOperation("TextWrapping")>]
    member _.TextWrapping(x, v: TextWrapping) =
            dependencyProperty x (nameof TextBlock.TextWrappingProperty) TextBlock.TextWrappingProperty v

    [<CustomOperation("TextWrapping")>]
    member _.TextWrapping(x, v: TextWrapping IObservableValue) =
        dependencyProperty x (nameof TextBlock.TextWrappingProperty) TextBlock.TextWrappingProperty v
    
    [<CustomOperation("ContextMenuOpening")>]
    member _.ContextMenuOpening(x, v) =
        event x "ContextMenuOpening" v
            (fun (c: TextBlock) -> c.add_ContextMenuOpening)
            (fun (c: TextBlock) -> c.remove_ContextMenuOpening)
            
    [<CustomOperation("IsTextTrimmedChanged")>]
    member _.IsTextTrimmedChanged(x, v) =
        event x "IsTextTrimmedChanged" v
            (fun (c: TextBlock) -> c.add_IsTextTrimmedChanged)
            (fun (c: TextBlock) -> c.remove_IsTextTrimmedChanged)
            
    [<CustomOperation("SelectionChanged")>]
    member _.SelectionChanged(x, v) =
        event x "SelectionChanged" v
            (fun (c: TextBlock) -> c.add_SelectionChanged)
            (fun (c: TextBlock) -> c.remove_SelectionChanged)
        
     