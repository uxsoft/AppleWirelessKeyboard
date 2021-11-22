namespace FUI.WinUI

open FUI.ObservableValue
open FUI.WinUI.Runtime
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open Microsoft.UI.Xaml.Input
open Microsoft.UI.Xaml.Media
open Windows.UI.Text

type ControlBuilder(controlType: Type) =
    inherit FrameworkElementBuilder()

    member this.Run x = this.RunChildless<Control> x controlType

    [<CustomOperation("Background")>]
    member _.Background(x, v: Brush) =
        dependencyProperty x (nameof Control.BackgroundProperty) Control.BackgroundProperty v
    
    [<CustomOperation("Background")>]
    member _.Background(x, v: Brush IObservableValue) =
        dependencyProperty x (nameof Control.BackgroundProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("BackgroundSizing")>]
    member _.BackgroundSizing(x, v: BackgroundSizing) =
        dependencyProperty x (nameof Control.BackgroundSizingProperty) Control.BackgroundProperty v
    
    [<CustomOperation("BackgroundSizing")>]
    member _.BackgroundSizing(x, v: BackgroundSizing IObservableValue) =
        dependencyProperty x (nameof Control.BackgroundSizingProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("BorderBrush")>]
    member _.BorderBrush(x, v: Brush) =
        dependencyProperty x (nameof Control.BorderBrushProperty) Control.BackgroundProperty v
    
    [<CustomOperation("BorderBrush")>]
    member _.BorderBrush(x, v: Brush IObservableValue) =
        dependencyProperty x (nameof Control.BorderBrushProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("BorderThickness")>]
    member _.BorderThickness(x, v: Thickness) =
        dependencyProperty x (nameof Control.BorderThicknessProperty) Control.BackgroundProperty v
    
    [<CustomOperation("BorderThickness")>]
    member _.BorderThickness(x, v: Thickness IObservableValue) =
        dependencyProperty x (nameof Control.BorderThicknessProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("CharacterSpacing")>]
    member _.CharacterSpacing(x, v: int) =
        dependencyProperty x (nameof Control.CharacterSpacingProperty) Control.BackgroundProperty v
    
    [<CustomOperation("CharacterSpacing")>]
    member _.CharacterSpacing(x, v: int IObservableValue) =
        dependencyProperty x (nameof Control.CharacterSpacingProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("CornerRadius")>]
    member _.CornerRadius(x, v: CornerRadius) =
        dependencyProperty x (nameof Control.CornerRadiusProperty) Control.BackgroundProperty v
    
    [<CustomOperation("CornerRadius")>]
    member _.CornerRadius(x, v: CornerRadius IObservableValue) =
        dependencyProperty x (nameof Control.CornerRadiusProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("DefaultStyleKey")>]
    member _.DefaultStyleKey(x, v: 'v) =
        dependencyProperty x (nameof Control.DefaultStyleKeyProperty) Control.BackgroundProperty v
    
    [<CustomOperation("DefaultStyleKey")>]
    member _.DefaultStyleKey(x, v: 'v IObservableValue) =
        dependencyProperty x (nameof Control.DefaultStyleKeyProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("DefaultStyleResourceUri")>]
    member _.DefaultStyleResourceUri(x, v: Uri) =
        dependencyProperty x (nameof Control.DefaultStyleResourceUriProperty) Control.BackgroundProperty v
    
    [<CustomOperation("DefaultStyleResourceUri")>]
    member _.DefaultStyleResourceUri(x, v: Uri IObservableValue) =
        dependencyProperty x (nameof Control.DefaultStyleResourceUriProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("ElementSoundMode")>]
    member _.ElementSoundMode(x, v: ElementSoundMode) =
        dependencyProperty x (nameof Control.ElementSoundModeProperty) Control.BackgroundProperty v
    
    [<CustomOperation("ElementSoundMode")>]
    member _.ElementSoundMode(x, v: ElementSoundMode IObservableValue) =
        dependencyProperty x (nameof Control.ElementSoundModeProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("FontFamily")>]
    member _.FontFamily(x, v: FontFamily) =
        dependencyProperty x (nameof Control.FontFamilyProperty) Control.BackgroundProperty v
    
    [<CustomOperation("FontFamily")>]
    member _.FontFamily(x, v: FontFamily IObservableValue) =
        dependencyProperty x (nameof Control.FontFamilyProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("FontSize")>]
    member _.FontSize(x, v: double) =
        dependencyProperty x (nameof Control.FontSizeProperty) Control.BackgroundProperty v
    
    [<CustomOperation("FontSize")>]
    member _.FontSize(x, v: double IObservableValue) =
        dependencyProperty x (nameof Control.FontSizeProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("FontStretch")>]
    member _.FontStretch(x, v: FontStretch) =
        dependencyProperty x (nameof Control.FontStretchProperty) Control.BackgroundProperty v
    
    [<CustomOperation("FontStretch")>]
    member _.FontStretch(x, v: FontStretch IObservableValue) =
        dependencyProperty x (nameof Control.FontStretchProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("FontStyle")>]
    member _.FontStyle(x, v: FontStyle) =
        dependencyProperty x (nameof Control.FontStyleProperty) Control.BackgroundProperty v
    
    [<CustomOperation("FontStyle")>]
    member _.FontStyle(x, v: FontStyle IObservableValue) =
        dependencyProperty x (nameof Control.FontStyleProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("FontWeight")>]
    member _.FontWeight(x, v: FontWeight) =
        dependencyProperty x (nameof Control.FontWeightProperty) Control.BackgroundProperty v
    
    [<CustomOperation("FontWeight")>]
    member _.FontWeight(x, v: FontWeight IObservableValue) =
        dependencyProperty x (nameof Control.FontWeightProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("Foreground")>]
    member _.Foreground(x, v: Brush) =
        dependencyProperty x (nameof Control.ForegroundProperty) Control.BackgroundProperty v
    
    [<CustomOperation("Foreground")>]
    member _.Foreground(x, v: Brush IObservableValue) =
        dependencyProperty x (nameof Control.ForegroundProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("HorizontalContentAlignment")>]
    member _.HorizontalContentAlignment(x, v: HorizontalAlignment) =
        dependencyProperty x (nameof Control.HorizontalContentAlignmentProperty) Control.BackgroundProperty v
    
    [<CustomOperation("HorizontalContentAlignment")>]
    member _.HorizontalContentAlignment(x, v: HorizontalAlignment IObservableValue) =
        dependencyProperty x (nameof Control.HorizontalContentAlignmentProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("IsEnabled")>]
    member _.IsEnabled(x, v: bool) =
        dependencyProperty x (nameof Control.IsEnabledProperty) Control.BackgroundProperty v
    
    [<CustomOperation("IsEnabled")>]
    member _.IsEnabled(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Control.IsEnabledProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("IsFocusEngaged")>]
    member _.IsFocusEngaged(x, v: bool) =
        dependencyProperty x (nameof Control.IsFocusEngagedProperty) Control.BackgroundProperty v
    
    [<CustomOperation("IsFocusEngaged")>]
    member _.IsFocusEngaged(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Control.IsFocusEngagedProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("IsFocusEngagementEnabled")>]
    member _.IsFocusEngagementEnabled(x, v: bool) =
        dependencyProperty x (nameof Control.IsFocusEngagementEnabledProperty) Control.BackgroundProperty v
    
    [<CustomOperation("IsFocusEngagementEnabled")>]
    member _.IsFocusEngagementEnabled(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Control.IsFocusEngagementEnabledProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("IsTemplateFocusTarget")>]
    member _.IsTemplateFocusTarget(x, v: bool) =
        dependencyProperty x (nameof Control.IsTemplateFocusTargetProperty) Control.BackgroundProperty v
    
    [<CustomOperation("IsTemplateFocusTarget")>]
    member _.IsTemplateFocusTarget(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Control.IsTemplateFocusTargetProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("IsTemplateKeyTipTarget")>]
    member _.IsTemplateKeyTipTarget(x, v: bool) =
        dependencyProperty x (nameof Control.IsTemplateKeyTipTargetProperty) Control.BackgroundProperty v
    
    [<CustomOperation("IsTemplateKeyTipTarget")>]
    member _.IsTemplateKeyTipTarget(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Control.IsTemplateKeyTipTargetProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("IsTextScaleFactorEnabled")>]
    member _.IsTextScaleFactorEnabled(x, v: bool) =
        dependencyProperty x (nameof Control.IsTextScaleFactorEnabledProperty) Control.BackgroundProperty v
    
    [<CustomOperation("IsTextScaleFactorEnabled")>]
    member _.IsTextScaleFactorEnabled(x, v: bool IObservableValue) =
        dependencyProperty x (nameof Control.IsTextScaleFactorEnabledProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("Padding")>]
    member _.Padding(x, v: Thickness) =
        dependencyProperty x (nameof Control.PaddingProperty) Control.BackgroundProperty v
    
    [<CustomOperation("Padding")>]
    member _.Padding(x, v: Thickness IObservableValue) =
        dependencyProperty x (nameof Control.PaddingProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("RequiresPointer")>]
    member _.RequiresPointer(x, v: RequiresPointer) =
        dependencyProperty x (nameof Control.RequiresPointerProperty) Control.BackgroundProperty v
    
    [<CustomOperation("RequiresPointer")>]
    member _.RequiresPointer(x, v: RequiresPointer IObservableValue) =
        dependencyProperty x (nameof Control.RequiresPointerProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("TabNavigation")>]
    member _.TabNavigation(x, v: KeyboardNavigationMode) =
        dependencyProperty x (nameof Control.TabNavigationProperty) Control.BackgroundProperty v
    
    [<CustomOperation("TabNavigation")>]
    member _.TabNavigation(x, v: KeyboardNavigationMode IObservableValue) =
        dependencyProperty x (nameof Control.TabNavigationProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("Template")>]
    member _.Template(x, v: ControlTemplate) =
        dependencyProperty x (nameof Control.TemplateProperty) Control.BackgroundProperty v
    
    [<CustomOperation("Template")>]
    member _.Template(x, v: ControlTemplate IObservableValue) =
        dependencyProperty x (nameof Control.TemplateProperty) Control.BackgroundProperty v
    
        
    [<CustomOperation("VerticalContentAlignment")>]
    member _.VerticalContentAlignment(x, v: VerticalAlignment) =
        dependencyProperty x (nameof Control.VerticalContentAlignmentProperty) Control.BackgroundProperty v
    
    [<CustomOperation("VerticalContentAlignment")>]
    member _.VerticalContentAlignment(x, v: VerticalAlignment IObservableValue) =
        dependencyProperty x (nameof Control.VerticalContentAlignmentProperty) Control.BackgroundProperty v
    
    [<CustomOperation("FocusDisengaged")>]
    member _.FocusDisengaged(x, v) =
        event x "FocusDisengaged" v
            (fun (c: Control) -> c.add_FocusDisengaged)
            (fun (c: Control) -> c.remove_FocusDisengaged)
    
    [<CustomOperation("FocusEngaged")>]
    member _.FocusEngaged(x, v) =
        event x "FocusEngaged" v
            (fun (c: Control) -> c.add_FocusEngaged)
            (fun (c: Control) -> c.remove_FocusEngaged)
            
    [<CustomOperation("IsEnabledChanged")>]
    member _.IsEnabledChanged(x, v) =
        event x "IsEnabledChanged" v
            (fun (c: Control) -> c.add_IsEnabledChanged)
            (fun (c: Control) -> c.remove_IsEnabledChanged)

