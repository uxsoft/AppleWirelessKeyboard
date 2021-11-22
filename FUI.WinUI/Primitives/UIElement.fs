namespace FUI.WinUI

open System.Collections.Generic
open FUI.UiBuilder
open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls.Primitives
open Microsoft.UI.Xaml.Input
open Microsoft.UI.Xaml.Media
open Microsoft.UI.Xaml.Media.Animation
open Microsoft.UI.Xaml.Media.Media3D
open Windows.Foundation

type UIElementBuilder() =
    inherit UiBuilder()

    [<CustomOperation("AccessKey")>]
    member _.AccessKey(x, v: string) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyProperty) UIElement.AccessKeyProperty v

    [<CustomOperation("AccessKey")>]
    member _.AccessKey(x, v: string IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyProperty) UIElement.AccessKeyProperty v


    [<CustomOperation("AccessKeyScopeOwner")>]
    member _.AccessKeyScopeOwner(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyScopeOwnerProperty) UIElement.AccessKeyScopeOwnerProperty v

    [<CustomOperation("AccessKeyScopeOwner")>]
    member _.AccessKeyScopeOwner(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyScopeOwnerProperty) UIElement.AccessKeyScopeOwnerProperty v


    [<CustomOperation("AllowDrop")>]
    member _.AllowDrop(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.AllowDropProperty) UIElement.AllowDropProperty v

    [<CustomOperation("AllowDrop")>]
    member _.AllowDrop(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.AllowDropProperty) UIElement.AllowDropProperty v


    [<CustomOperation("CacheMode")>]
    member _.CacheMode(x, v: CacheMode) =
        Runtime.dependencyProperty x (nameof UIElement.CacheModeProperty) UIElement.CacheModeProperty v

    [<CustomOperation("CacheMode")>]
    member _.CacheMode(x, v: CacheMode IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.CacheModeProperty) UIElement.CacheModeProperty v


    [<CustomOperation("CanBeScrollAnchor")>]
    member _.CanBeScrollAnchor(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.CanBeScrollAnchorProperty) UIElement.CanBeScrollAnchorProperty v

    [<CustomOperation("CanBeScrollAnchor")>]
    member _.CanBeScrollAnchor(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.CanBeScrollAnchorProperty) UIElement.CanBeScrollAnchorProperty v


    [<CustomOperation("CanDrag")>]
    member _.CanDrag(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.CanDragProperty) UIElement.CanDragProperty v

    [<CustomOperation("CanDrag")>]
    member _.CanDrag(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.CanDragProperty) UIElement.CanDragProperty v


    [<CustomOperation("Clip")>]
    member _.Clip(x, v: RectangleGeometry) =
        Runtime.dependencyProperty x (nameof UIElement.ClipProperty) UIElement.ClipProperty v

    [<CustomOperation("Clip")>]
    member _.Clip(x, v: RectangleGeometry IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.ClipProperty) UIElement.ClipProperty v


    [<CustomOperation("CompositeMode")>]
    member _.CompositeMode(x, v: ElementCompositeMode) =
        Runtime.dependencyProperty x (nameof UIElement.CompositeModeProperty) UIElement.CompositeModeProperty v

    [<CustomOperation("CompositeMode")>]
    member _.CompositeMode(x, v: ElementCompositeMode IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.CompositeModeProperty) UIElement.CompositeModeProperty v


    [<CustomOperation("ContextFlyout")>]
    member _.ContextFlyout(x, v: FlyoutBase) =
        Runtime.dependencyProperty x (nameof UIElement.ContextFlyoutProperty) UIElement.ContextFlyoutProperty v

    [<CustomOperation("ContextFlyout")>]
    member _.ContextFlyout(x, v: FlyoutBase IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.ContextFlyoutProperty) UIElement.ContextFlyoutProperty v


    [<CustomOperation("ExitDisplayModeOnAccessKeyInvoked")>]
    member _.ExitDisplayModeOnAccessKeyInvoked(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.ExitDisplayModeOnAccessKeyInvokedProperty) UIElement.ExitDisplayModeOnAccessKeyInvokedProperty v

    [<CustomOperation("ExitDisplayModeOnAccessKeyInvoked")>]
    member _.ExitDisplayModeOnAccessKeyInvoked(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.ExitDisplayModeOnAccessKeyInvokedProperty) UIElement.ExitDisplayModeOnAccessKeyInvokedProperty v


    [<CustomOperation("FocusState")>]
    member _.FocusState(x, v: FocusState) =
        Runtime.dependencyProperty x (nameof UIElement.FocusStateProperty) UIElement.FocusStateProperty v

    [<CustomOperation("FocusState")>]
    member _.FocusState(x, v: FocusState IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.FocusStateProperty) UIElement.FocusStateProperty v


    [<CustomOperation("HighContrastAdjustment")>]
    member _.HighContrastAdjustment(x, v: ElementHighContrastAdjustment) =
        Runtime.dependencyProperty x (nameof UIElement.HighContrastAdjustmentProperty) UIElement.HighContrastAdjustmentProperty v

    [<CustomOperation("HighContrastAdjustment")>]
    member _.HighContrastAdjustment(x, v: ElementHighContrastAdjustment IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.HighContrastAdjustmentProperty) UIElement.HighContrastAdjustmentProperty v


    [<CustomOperation("IsAccessKeyScope")>]
    member _.IsAccessKeyScope(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsAccessKeyScopeProperty) UIElement.IsAccessKeyScopeProperty v

    [<CustomOperation("IsAccessKeyScope")>]
    member _.IsAccessKeyScope(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsAccessKeyScopeProperty) UIElement.IsAccessKeyScopeProperty v


    [<CustomOperation("IsDoubleTapEnabled")>]
    member _.IsDoubleTapEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsDoubleTapEnabledProperty) UIElement.IsDoubleTapEnabledProperty v

    [<CustomOperation("IsDoubleTapEnabled")>]
    member _.IsDoubleTapEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsDoubleTapEnabledProperty) UIElement.IsDoubleTapEnabledProperty v


    [<CustomOperation("IsHitTestVisible")>]
    member _.IsHitTestVisible(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsHitTestVisibleProperty) UIElement.IsHitTestVisibleProperty v

    [<CustomOperation("IsHitTestVisible")>]
    member _.IsHitTestVisible(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsHitTestVisibleProperty) UIElement.IsHitTestVisibleProperty v


    [<CustomOperation("IsHoldingEnabled")>]
    member _.IsHoldingEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsHoldingEnabledProperty) UIElement.IsHoldingEnabledProperty v

    [<CustomOperation("IsHoldingEnabled")>]
    member _.IsHoldingEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsHoldingEnabledProperty) UIElement.IsHoldingEnabledProperty v


    [<CustomOperation("IsRightTapEnabled")>]
    member _.IsRightTapEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsRightTapEnabledProperty) UIElement.IsRightTapEnabledProperty v

    [<CustomOperation("IsRightTapEnabled")>]
    member _.IsRightTapEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsRightTapEnabledProperty) UIElement.IsRightTapEnabledProperty v


    [<CustomOperation("IsTabStop")>]
    member _.IsTabStop(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsTabStopProperty) UIElement.IsTabStopProperty v

    [<CustomOperation("IsTabStop")>]
    member _.IsTabStop(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsTabStopProperty) UIElement.IsTabStopProperty v


    [<CustomOperation("IsTapEnabled")>]
    member _.IsTapEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.IsTapEnabledProperty) UIElement.IsTapEnabledProperty v

    [<CustomOperation("IsTapEnabled")>]
    member _.IsTapEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.IsTapEnabledProperty) UIElement.IsTapEnabledProperty v


    [<CustomOperation("KeyTipHorizontalOffset")>]
    member _.KeyTipHorizontalOffset(x, v: double) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipHorizontalOffsetProperty) UIElement.KeyTipHorizontalOffsetProperty v

    [<CustomOperation("KeyTipHorizontalOffset")>]
    member _.KeyTipHorizontalOffset(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipHorizontalOffsetProperty) UIElement.KeyTipHorizontalOffsetProperty v


    [<CustomOperation("KeyTipPlacementMode")>]
    member _.KeyTipPlacementMode(x, v: KeyTipPlacementMode) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipPlacementModeProperty) UIElement.KeyTipPlacementModeProperty v

    [<CustomOperation("KeyTipPlacementMode")>]
    member _.KeyTipPlacementMode(x, v: KeyTipPlacementMode IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipPlacementModeProperty) UIElement.KeyTipPlacementModeProperty v


    [<CustomOperation("KeyTipTarget")>]
    member _.KeyTipTarget(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipTargetProperty) UIElement.KeyTipTargetProperty v

    [<CustomOperation("KeyTipTarget")>]
    member _.KeyTipTarget(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipTargetProperty) UIElement.KeyTipTargetProperty v


    [<CustomOperation("KeyTipVerticalOffset")>]
    member _.KeyTipVerticalOffset(x, v: double) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipVerticalOffsetProperty) UIElement.KeyTipVerticalOffsetProperty v

    [<CustomOperation("KeyTipVerticalOffset")>]
    member _.KeyTipVerticalOffset(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipVerticalOffsetProperty) UIElement.KeyTipVerticalOffsetProperty v


    [<CustomOperation("KeyboardAcceleratorPlacementMode")>]
    member _.KeyboardAcceleratorPlacementMode(x, v: KeyboardAcceleratorPlacementMode) =
        Runtime.dependencyProperty x (nameof UIElement.KeyboardAcceleratorPlacementModeProperty) UIElement.KeyboardAcceleratorPlacementModeProperty v

    [<CustomOperation("KeyboardAcceleratorPlacementMode")>]
    member _.KeyboardAcceleratorPlacementMode(x, v: KeyboardAcceleratorPlacementMode IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.KeyboardAcceleratorPlacementModeProperty) UIElement.KeyboardAcceleratorPlacementModeProperty v


    [<CustomOperation("KeyboardAcceleratorPlacementTarget")>]
    member _.KeyboardAcceleratorPlacementTarget(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.KeyboardAcceleratorPlacementTargetProperty) UIElement.KeyboardAcceleratorPlacementTargetProperty v

    [<CustomOperation("KeyboardAcceleratorPlacementTarget")>]
    member _.KeyboardAcceleratorPlacementTarget(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.KeyboardAcceleratorPlacementTargetProperty) UIElement.KeyboardAcceleratorPlacementTargetProperty v


    [<CustomOperation("Lights")>]
    member _.Lights(x, v: IList<XamlLight>) =
        Runtime.dependencyProperty x (nameof UIElement.LightsProperty) UIElement.LightsProperty v

    [<CustomOperation("Lights")>]
    member _.Lights(x, v: IList<XamlLight> IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.LightsProperty) UIElement.LightsProperty v


    [<CustomOperation("ManipulationMode")>]
    member _.ManipulationMode(x, v: ManipulationModes) =
        Runtime.dependencyProperty x (nameof UIElement.ManipulationModeProperty) UIElement.ManipulationModeProperty v

    [<CustomOperation("ManipulationMode")>]
    member _.ManipulationMode(x, v: ManipulationModes IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.ManipulationModeProperty) UIElement.ManipulationModeProperty v


    [<CustomOperation("Opacity")>]
    member _.Opacity(x, v: double) =
        Runtime.dependencyProperty x (nameof UIElement.OpacityProperty) UIElement.OpacityProperty v

    [<CustomOperation("Opacity")>]
    member _.Opacity(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.OpacityProperty) UIElement.OpacityProperty v


    [<CustomOperation("PointerCaptures")>]
    member _.PointerCaptures(x, v: IReadOnlyList<Pointer>) =
        Runtime.dependencyProperty x (nameof UIElement.PointerCapturesProperty) UIElement.PointerCapturesProperty v

    [<CustomOperation("PointerCaptures")>]
    member _.PointerCaptures(x, v: IReadOnlyList<Pointer> IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.PointerCapturesProperty) UIElement.PointerCapturesProperty v


    [<CustomOperation("Projection")>]
    member _.Projection(x, v: Projection) =
        Runtime.dependencyProperty x (nameof UIElement.ProjectionProperty) UIElement.ProjectionProperty v

    [<CustomOperation("Projection")>]
    member _.Projection(x, v: Projection IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.ProjectionProperty) UIElement.ProjectionProperty v


    [<CustomOperation("RenderTransformOrigin")>]
    member _.RenderTransformOrigin(x, v: Point) =
        Runtime.dependencyProperty x (nameof UIElement.RenderTransformOriginProperty) UIElement.RenderTransformOriginProperty v

    [<CustomOperation("RenderTransformOrigin")>]
    member _.RenderTransformOrigin(x, v: Point IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.RenderTransformOriginProperty) UIElement.RenderTransformOriginProperty v


    [<CustomOperation("RenderTransform")>]
    member _.RenderTransform(x, v: Transform) =
        Runtime.dependencyProperty x (nameof UIElement.RenderTransformProperty) UIElement.RenderTransformProperty v

    [<CustomOperation("RenderTransform")>]
    member _.RenderTransform(x, v: Transform IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.RenderTransformProperty) UIElement.RenderTransformProperty v


    [<CustomOperation("Shadow")>]
    member _.Shadow(x, v: Shadow) =
        Runtime.dependencyProperty x (nameof UIElement.ShadowProperty) UIElement.ShadowProperty v

    [<CustomOperation("Shadow")>]
    member _.Shadow(x, v: Shadow IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.ShadowProperty) UIElement.ShadowProperty v


    [<CustomOperation("TabFocusNavigation")>]
    member _.TabFocusNavigation(x, v: KeyboardNavigationMode) =
        Runtime.dependencyProperty x (nameof UIElement.TabFocusNavigationProperty) UIElement.TabFocusNavigationProperty v

    [<CustomOperation("TabFocusNavigation")>]
    member _.TabFocusNavigation(x, v: KeyboardNavigationMode IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.TabFocusNavigationProperty) UIElement.TabFocusNavigationProperty v


    [<CustomOperation("TabIndex")>]
    member _.TabIndex(x, v: int) =
        Runtime.dependencyProperty x (nameof UIElement.TabIndexProperty) UIElement.TabIndexProperty v

    [<CustomOperation("TabIndex")>]
    member _.TabIndex(x, v: int IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.TabIndexProperty) UIElement.TabIndexProperty v


    [<CustomOperation("Transform3D")>]
    member _.Transform3D(x, v: Transform3D) =
        Runtime.dependencyProperty x (nameof UIElement.Transform3DProperty) UIElement.Transform3DProperty v

    [<CustomOperation("Transform3D")>]
    member _.Transform3D(x, v: Transform3D IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.Transform3DProperty) UIElement.Transform3DProperty v


    [<CustomOperation("Transitions")>]
    member _.Transitions(x, v: TransitionCollection) =
        Runtime.dependencyProperty x (nameof UIElement.TransitionsProperty) UIElement.TransitionsProperty v

    [<CustomOperation("Transitions")>]
    member _.Transitions(x, v: TransitionCollection IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.TransitionsProperty) UIElement.TransitionsProperty v


    [<CustomOperation("UseLayoutRounding")>]
    member _.UseLayoutRounding(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.UseLayoutRoundingProperty) UIElement.UseLayoutRoundingProperty v

    [<CustomOperation("UseLayoutRounding")>]
    member _.UseLayoutRounding(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.UseLayoutRoundingProperty) UIElement.UseLayoutRoundingProperty v


    [<CustomOperation("UseSystemFocusVisuals")>]
    member _.UseSystemFocusVisuals(x, v: bool) =
        Runtime.dependencyProperty x (nameof UIElement.UseSystemFocusVisualsProperty) UIElement.UseSystemFocusVisualsProperty v

    [<CustomOperation("UseSystemFocusVisuals")>]
    member _.UseSystemFocusVisuals(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.UseSystemFocusVisualsProperty) UIElement.UseSystemFocusVisualsProperty v


    [<CustomOperation("Visibility")>]
    member _.Visibility(x, v: Visibility) =
        Runtime.dependencyProperty x (nameof UIElement.VisibilityProperty) UIElement.VisibilityProperty v

    [<CustomOperation("Visibility")>]
    member _.Visibility(x, v: Visibility IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.VisibilityProperty) UIElement.VisibilityProperty v


    [<CustomOperation("XYFocusDownNavigationStrategy")>]
    member _.XYFocusDownNavigationStrategy(x, v: XYFocusNavigationStrategy) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusDownNavigationStrategyProperty) UIElement.XYFocusDownNavigationStrategyProperty v

    [<CustomOperation("XYFocusDownNavigationStrategy")>]
    member _.XYFocusDownNavigationStrategy(x, v: XYFocusNavigationStrategy IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusDownNavigationStrategyProperty) UIElement.XYFocusDownNavigationStrategyProperty v


    [<CustomOperation("XYFocusDown")>]
    member _.XYFocusDown(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusDownProperty) UIElement.XYFocusDownProperty v

    [<CustomOperation("XYFocusDown")>]
    member _.XYFocusDown(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusDownProperty) UIElement.XYFocusDownProperty v


    [<CustomOperation("XYFocusKeyboardNavigation")>]
    member _.XYFocusKeyboardNavigation(x, v: XYFocusKeyboardNavigationMode) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusKeyboardNavigationProperty) UIElement.XYFocusKeyboardNavigationProperty v

    [<CustomOperation("XYFocusKeyboardNavigation")>]
    member _.XYFocusKeyboardNavigation(x, v: XYFocusKeyboardNavigationMode IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusKeyboardNavigationProperty) UIElement.XYFocusKeyboardNavigationProperty v


    [<CustomOperation("XYFocusLeftNavigationStrategy")>]
    member _.XYFocusLeftNavigationStrategy(x, v: XYFocusNavigationStrategy) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusLeftNavigationStrategyProperty) UIElement.XYFocusLeftNavigationStrategyProperty v

    [<CustomOperation("XYFocusLeftNavigationStrategy")>]
    member _.XYFocusLeftNavigationStrategy(x, v: XYFocusNavigationStrategy IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusLeftNavigationStrategyProperty) UIElement.XYFocusLeftNavigationStrategyProperty v


    [<CustomOperation("XYFocusLeft")>]
    member _.XYFocusLeft(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusLeftProperty) UIElement.XYFocusLeftProperty v

    [<CustomOperation("XYFocusLeft")>]
    member _.XYFocusLeft(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusLeftProperty) UIElement.XYFocusLeftProperty v


    [<CustomOperation("XYFocusRightNavigationStrategy")>]
    member _.XYFocusRightNavigationStrategy(x, v: XYFocusNavigationStrategy) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusRightNavigationStrategyProperty) UIElement.XYFocusRightNavigationStrategyProperty v

    [<CustomOperation("XYFocusRightNavigationStrategy")>]
    member _.XYFocusRightNavigationStrategy(x, v: XYFocusNavigationStrategy IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusRightNavigationStrategyProperty) UIElement.XYFocusRightNavigationStrategyProperty v


    [<CustomOperation("XYFocusRight")>]
    member _.XYFocusRight(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusRightProperty) UIElement.XYFocusRightProperty v

    [<CustomOperation("XYFocusRight")>]
    member _.XYFocusRight(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusRightProperty) UIElement.XYFocusRightProperty v


    [<CustomOperation("XYFocusUpNavigationStrategy")>]
    member _.XYFocusUpNavigationStrategy(x, v: XYFocusNavigationStrategy) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusUpNavigationStrategyProperty) UIElement.XYFocusUpNavigationStrategyProperty v

    [<CustomOperation("XYFocusUpNavigationStrategy")>]
    member _.XYFocusUpNavigationStrategy(x, v: XYFocusNavigationStrategy IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusUpNavigationStrategyProperty) UIElement.XYFocusUpNavigationStrategyProperty v


    [<CustomOperation("XYFocusUp")>]
    member _.XYFocusUp(x, v: DependencyObject) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusUpProperty) UIElement.XYFocusUpProperty v

    [<CustomOperation("XYFocusUp")>]
    member _.XYFocusUp(x, v: DependencyObject IObservableValue) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusUpProperty) UIElement.XYFocusUpProperty v

    [<CustomOperation("BringIntoViewRequested")>]
    member _.BringIntoViewRequested(x, v) =
        Runtime.routedEvent x (nameof UIElement.BringIntoViewRequestedEvent) UIElement.BringIntoViewRequestedEvent v
        
    [<CustomOperation("Tapped")>]
    member _.Tapped(x, v) =
        Runtime.routedEvent x (nameof UIElement.TappedEvent) UIElement.TappedEvent v
        
    [<CustomOperation("RightTapped")>]
    member _.RightTapped(x, v) =
        Runtime.routedEvent x (nameof UIElement.RightTappedEvent) UIElement.RightTappedEvent v
        
    [<CustomOperation("PointerEntered")>]
    member _.PointerEntered(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerEnteredEvent) UIElement.PointerEnteredEvent v
        
    [<CustomOperation("PointerExited")>]
    member _.PointerExited(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerExitedEvent) UIElement.PointerExitedEvent v
        
    [<CustomOperation("PointerMoved")>]
    member _.PointerMoved(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerMovedEvent) UIElement.PointerMovedEvent v
        
    [<CustomOperation("PointerPressed")>]
    member _.PointerPressed(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerPressedEvent) UIElement.PointerPressedEvent v
        
    [<CustomOperation("PointerReleased")>]
    member _.PointerReleased(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerReleasedEvent) UIElement.PointerReleasedEvent v
        
    [<CustomOperation("PointerWheelChanged")>]
    member _.PointerWheelChanged(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerWheelChangedEvent) UIElement.PointerWheelChangedEvent v
        
    [<CustomOperation("PreviewKeyDown")>]
    member _.PreviewKeyDown(x, v) =
        Runtime.routedEvent x (nameof UIElement.PreviewKeyDownEvent) UIElement.PreviewKeyDownEvent v
        
    [<CustomOperation("PreviewKeyUp")>]
    member _.PreviewKeyUp(x, v) =
        Runtime.routedEvent x (nameof UIElement.PreviewKeyUpEvent) UIElement.PreviewKeyUpEvent v
        
    [<CustomOperation("PointerCanceled")>]
    member _.PointerCanceled(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerCanceledEvent) UIElement.PointerCanceledEvent v
        
    [<CustomOperation("PointerCaptureLost")>]
    member _.PointerCaptureLost(x, v) =
        Runtime.routedEvent x (nameof UIElement.PointerCaptureLostEvent) UIElement.PointerCaptureLostEvent v
        
    [<CustomOperation("ManipulationStarted")>]
    member _.ManipulationStarted(x, v) =
        Runtime.routedEvent x (nameof UIElement.ManipulationStartedEvent) UIElement.ManipulationStartedEvent v
        
    [<CustomOperation("ManipulationStarting")>]
    member _.ManipulationStarting(x, v) =
        Runtime.routedEvent x (nameof UIElement.ManipulationStartingEvent) UIElement.ManipulationStartingEvent v
        
    [<CustomOperation("NoFocusCandidateFound")>]
    member _.NoFocusCandidateFound(x, v) =
        Runtime.routedEvent x (nameof UIElement.NoFocusCandidateFoundEvent) UIElement.NoFocusCandidateFoundEvent v
        
    [<CustomOperation("LosingFocus")>]
    member _.LosingFocus(x, v) =
        Runtime.routedEvent x (nameof UIElement.LosingFocusEvent) UIElement.LosingFocusEvent v
        
    [<CustomOperation("ManipulationCompleted")>]
    member _.ManipulationCompleted(x, v) =
        Runtime.routedEvent x (nameof UIElement.ManipulationCompletedEvent) UIElement.ManipulationCompletedEvent v
        
    [<CustomOperation("ManipulationDelta")>]
    member _.ManipulationDelta(x, v) =
        Runtime.routedEvent x (nameof UIElement.ManipulationDeltaEvent) UIElement.ManipulationDeltaEvent v
        
    [<CustomOperation("ManipulationInertiaStarting")>]
    member _.ManipulationInertiaStarting(x, v) =
        Runtime.routedEvent x (nameof UIElement.ManipulationInertiaStartingEvent) UIElement.ManipulationInertiaStartingEvent v
        
    [<CustomOperation("KeyUp")>]
    member _.KeyUp(x, v) =
        Runtime.routedEvent x (nameof UIElement.KeyUpEvent) UIElement.KeyUpEvent v
        
    [<CustomOperation("Holding")>]
    member _.Holding(x, v) =
        Runtime.routedEvent x (nameof UIElement.HoldingEvent) UIElement.HoldingEvent v
        
    [<CustomOperation("CharacterReceived")>]
    member _.CharacterReceived(x, v) =
        Runtime.routedEvent x (nameof UIElement.CharacterReceivedEvent) UIElement.CharacterReceivedEvent v
        
    [<CustomOperation("KeyDown")>]
    member _.KeyDown(x, v) =
        Runtime.routedEvent x (nameof UIElement.KeyDownEvent) UIElement.KeyDownEvent v
        
    [<CustomOperation("GettingFocus")>]
    member _.GettingFocus(x, v) =
        Runtime.routedEvent x (nameof UIElement.GettingFocusEvent) UIElement.GettingFocusEvent v
        
    [<CustomOperation("ContextRequested")>]
    member _.ContextRequested(x, v) =
        Runtime.routedEvent x (nameof UIElement.ContextRequestedEvent) UIElement.ContextRequestedEvent v
        
    [<CustomOperation("DoubleTapped")>]
    member _.DoubleTapped(x, v) =
        Runtime.routedEvent x (nameof UIElement.DoubleTappedEvent) UIElement.DoubleTappedEvent v
        
    [<CustomOperation("DragEnter")>]
    member _.DragEnter(x, v) =
        Runtime.routedEvent x (nameof UIElement.DragEnterEvent) UIElement.DragEnterEvent v
        
    [<CustomOperation("DragLeave")>]
    member _.DragLeave(x, v) =
        Runtime.routedEvent x (nameof UIElement.DragLeaveEvent) UIElement.DragLeaveEvent v
        
    [<CustomOperation("DragOver")>]
    member _.DragOver(x, v) =
        Runtime.routedEvent x (nameof UIElement.DragOverEvent) UIElement.DragOverEvent v
        
    [<CustomOperation("Drop")>]
    member _.Drop(x, v) =
        Runtime.routedEvent x (nameof UIElement.DropEvent) UIElement.DropEvent v
        