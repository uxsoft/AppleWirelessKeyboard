namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml

type UIElementBuilder() =
    inherit UiBuilder()

    [<CustomOperation("AccessKey")>]
    member _.AccessKey<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyProperty) UIElement.AccessKeyProperty

    [<CustomOperation("AccessKeyScopeOwner")>]
    member _.AccessKeyScopeOwner<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyScopeOwnerProperty) UIElement.AccessKeyScopeOwnerProperty

    [<CustomOperation("AllowDrop")>]
    member _.AllowDrop<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AllowDropProperty) UIElement.AllowDropProperty

    [<CustomOperation("CacheMode")>]
    member _.CacheMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.CacheModeProperty) UIElement.CacheModeProperty

    [<CustomOperation("CanBeScrollAnchor")>]
    member _.CanBeScrollAnchor<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.CanBeScrollAnchorProperty) UIElement.CanBeScrollAnchorProperty

    [<CustomOperation("CanDrag")>]
    member _.CanDrag<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.CanDragProperty) UIElement.CanDragProperty

    [<CustomOperation("Clip")>]
    member _.Clip<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.ClipProperty) UIElement.ClipProperty

    [<CustomOperation("CompositeMode")>]
    member _.CompositeMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.CompositeModeProperty) UIElement.CompositeModeProperty

    [<CustomOperation("ContextFlyout")>]
    member _.ContextFlyout<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.ContextFlyoutProperty) UIElement.ContextFlyoutProperty

    [<CustomOperation("ExitDisplayModeOnAccessKeyInvoked")>]
    member _.ExitDisplayModeOnAccessKeyInvoked<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.ExitDisplayModeOnAccessKeyInvokedProperty) UIElement.ExitDisplayModeOnAccessKeyInvokedProperty

    [<CustomOperation("FocusState")>]
    member _.FocusState<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.FocusStateProperty) UIElement.FocusStateProperty

    [<CustomOperation("HighContrastAdjustment")>]
    member _.HighContrastAdjustment<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.HighContrastAdjustmentProperty) UIElement.HighContrastAdjustmentProperty

    [<CustomOperation("IsAccessKeyScope")>]
    member _.IsAccessKeyScope<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsAccessKeyScopeProperty) UIElement.IsAccessKeyScopeProperty

    [<CustomOperation("IsDoubleTapEnabled")>]
    member _.IsDoubleTapEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsDoubleTapEnabledProperty) UIElement.IsDoubleTapEnabledProperty

    [<CustomOperation("IsHitTestVisible")>]
    member _.IsHitTestVisible<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsHitTestVisibleProperty) UIElement.IsHitTestVisibleProperty

    [<CustomOperation("IsHoldingEnabled")>]
    member _.IsHoldingEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsHoldingEnabledProperty) UIElement.IsHoldingEnabledProperty

    [<CustomOperation("IsRightTapEnabled")>]
    member _.IsRightTapEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsRightTapEnabledProperty) UIElement.IsRightTapEnabledProperty

    [<CustomOperation("IsTabStop")>]
    member _.IsTabStop<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsTabStopProperty) UIElement.IsTabStopProperty

    [<CustomOperation("IsTapEnabled")>]
    member _.IsTapEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.IsTapEnabledProperty) UIElement.IsTapEnabledProperty

    [<CustomOperation("KeyTipHorizontalOffset")>]
    member _.KeyTipHorizontalOffset<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipHorizontalOffsetProperty) UIElement.KeyTipHorizontalOffsetProperty

    [<CustomOperation("KeyTipPlacementMode")>]
    member _.KeyTipPlacementMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipPlacementModeProperty) UIElement.KeyTipPlacementModeProperty

    [<CustomOperation("KeyTipTarget")>]
    member _.KeyTipTarget<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipTargetProperty) UIElement.KeyTipTargetProperty

    [<CustomOperation("KeyTipVerticalOffset")>]
    member _.KeyTipVerticalOffset<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.KeyTipVerticalOffsetProperty) UIElement.KeyTipVerticalOffsetProperty

    [<CustomOperation("KeyboardAcceleratorPlacementMode")>]
    member _.KeyboardAcceleratorPlacementMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.KeyboardAcceleratorPlacementModeProperty) UIElement.KeyboardAcceleratorPlacementModeProperty

    [<CustomOperation("KeyboardAcceleratorPlacementTarget")>]
    member _.KeyboardAcceleratorPlacementTarget<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.KeyboardAcceleratorPlacementTargetProperty) UIElement.KeyboardAcceleratorPlacementTargetProperty

    [<CustomOperation("Lights")>]
    member _.Lights<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.LightsProperty) UIElement.LightsProperty

    [<CustomOperation("ManipulationMode")>]
    member _.ManipulationMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.ManipulationModeProperty) UIElement.ManipulationModeProperty

    [<CustomOperation("Opacity")>]
    member _.Opacity<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.OpacityProperty) UIElement.OpacityProperty

    [<CustomOperation("PointerCaptures")>]
    member _.PointerCaptures<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.PointerCapturesProperty) UIElement.PointerCapturesProperty

    [<CustomOperation("Projection")>]
    member _.Projection<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.ProjectionProperty) UIElement.ProjectionProperty

    [<CustomOperation("RenderTransformOrigin")>]
    member _.RenderTransformOrigin<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.RenderTransformOriginProperty) UIElement.RenderTransformOriginProperty

    [<CustomOperation("RenderTransform")>]
    member _.RenderTransform<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.RenderTransformProperty) UIElement.RenderTransformProperty

    [<CustomOperation("Shadow")>]
    member _.Shadow<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.ShadowProperty) UIElement.ShadowProperty

    [<CustomOperation("TabFocusNavigation")>]
    member _.TabFocusNavigation<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.TabFocusNavigationProperty) UIElement.TabFocusNavigationProperty

    [<CustomOperation("TabIndex")>]
    member _.TabIndex<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.TabIndexProperty) UIElement.TabIndexProperty

    [<CustomOperation("Transform3D")>]
    member _.Transform3D<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.Transform3DProperty) UIElement.Transform3DProperty

    [<CustomOperation("Transitions")>]
    member _.Transitions<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.TransitionsProperty) UIElement.TransitionsProperty

    [<CustomOperation("UseLayoutRounding")>]
    member _.UseLayoutRounding<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.UseLayoutRoundingProperty) UIElement.UseLayoutRoundingProperty

    [<CustomOperation("UseSystemFocusVisuals")>]
    member _.UseSystemFocusVisuals<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.UseSystemFocusVisualsProperty) UIElement.UseSystemFocusVisualsProperty

    [<CustomOperation("Visibility")>]
    member _.Visibility<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.VisibilityProperty) UIElement.VisibilityProperty

    [<CustomOperation("XYFocusDownNavigationStrategy")>]
    member _.XYFocusDownNavigationStrategy<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusDownNavigationStrategyProperty) UIElement.XYFocusDownNavigationStrategyProperty

    [<CustomOperation("XYFocusDown")>]
    member _.XYFocusDown<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusDownProperty) UIElement.XYFocusDownProperty

    [<CustomOperation("XYFocusKeyboardNavigation")>]
    member _.XYFocusKeyboardNavigation<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusKeyboardNavigationProperty) UIElement.XYFocusKeyboardNavigationProperty

    [<CustomOperation("XYFocusLeftNavigationStrategy")>]
    member _.XYFocusLeftNavigationStrategy<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusLeftNavigationStrategyProperty) UIElement.XYFocusLeftNavigationStrategyProperty

    [<CustomOperation("XYFocusLeft")>]
    member _.XYFocusLeft<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusLeftProperty) UIElement.XYFocusLeftProperty

    [<CustomOperation("XYFocusRightNavigationStrategy")>]
    member _.XYFocusRightNavigationStrategy<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusRightNavigationStrategyProperty) UIElement.XYFocusRightNavigationStrategyProperty

    [<CustomOperation("XYFocusRight")>]
    member _.XYFocusRight<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusRightProperty) UIElement.XYFocusRightProperty

    [<CustomOperation("XYFocusUpNavigationStrategy")>]
    member _.XYFocusUpNavigationStrategy<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusUpNavigationStrategyProperty) UIElement.XYFocusUpNavigationStrategyProperty

    [<CustomOperation("XYFocusUp")>]
    member _.XYFocusUp<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.XYFocusUpProperty) UIElement.XYFocusUpProperty


//        public static RoutedEvent BringIntoViewRequestedEvent => _IUIElementStatics.Instance.BringIntoViewRequestedEvent;
//        public static RoutedEvent TappedEvent => _IUIElementStatics.Instance.TappedEvent;
//        public static RoutedEvent RightTappedEvent => _IUIElementStatics.Instance.RightTappedEvent;
//        public static RoutedEvent PointerEnteredEvent => _IUIElementStatics.Instance.PointerEnteredEvent;
//        public static RoutedEvent PointerExitedEvent => _IUIElementStatics.Instance.PointerExitedEvent;
//        public static RoutedEvent PointerMovedEvent => _IUIElementStatics.Instance.PointerMovedEvent;
//        public static RoutedEvent PointerPressedEvent => _IUIElementStatics.Instance.PointerPressedEvent;
//        public static RoutedEvent PointerReleasedEvent => _IUIElementStatics.Instance.PointerReleasedEvent;
//        public static RoutedEvent PointerWheelChangedEvent => _IUIElementStatics.Instance.PointerWheelChangedEvent;
//        public static RoutedEvent PreviewKeyDownEvent => _IUIElementStatics.Instance.PreviewKeyDownEvent;
//        public static RoutedEvent PreviewKeyUpEvent => _IUIElementStatics.Instance.PreviewKeyUpEvent
//        public static RoutedEvent PointerCanceledEvent => _IUIElementStatics.Instance.PointerCanceledEvent;
//        public static RoutedEvent PointerCaptureLostEvent => _IUIElementStatics.Instance.PointerCaptureLostEvent
//        public static RoutedEvent ManipulationStartedEvent => _IUIElementStatics.Instance.ManipulationStartedEvent;
//        public static RoutedEvent ManipulationStartingEvent => _IUIElementStatics.Instance.ManipulationStartingEvent;
//        public static RoutedEvent NoFocusCandidateFoundEvent => _IUIElementStatics.Instance.NoFocusCandidateFoundEvent
//        public static RoutedEvent LosingFocusEvent => _IUIElementStatics.Instance.LosingFocusEvent;
//        public static RoutedEvent ManipulationCompletedEvent => _IUIElementStatics.Instance.ManipulationCompletedEvent;
//        public static RoutedEvent ManipulationDeltaEvent => _IUIElementStatics.Instance.ManipulationDeltaEvent;
//        public static RoutedEvent ManipulationInertiaStartingEvent => _IUIElementStatics.Instance.ManipulationInertiaStartingEvent;
//        public static RoutedEvent KeyUpEvent => _IUIElementStatics.Instance.KeyUpEvent;
//        public static RoutedEvent HoldingEvent => _IUIElementStatics.Instance.HoldingEvent;
//        public static RoutedEvent CharacterReceivedEvent => _IUIElementStatics.Instance.CharacterReceivedEvent;
//        public static RoutedEvent KeyDownEvent => _IUIElementStatics.Instance.KeyDownEvent;
//        public static RoutedEvent GettingFocusEvent => _IUIElementStatics.Instance.GettingFocusEvent;
//        public static RoutedEvent ContextRequestedEvent => _IUIElementStatics.Instance.ContextRequestedEvent;
//        public static RoutedEvent DoubleTappedEvent => _IUIElementStatics.Instance.DoubleTappedEvent;
//        public static RoutedEvent DragEnterEvent => _IUIElementStatics.Instance.DragEnterEvent;
//        public static RoutedEvent DragLeaveEvent => _IUIElementStatics.Instance.DragLeaveEvent;
//        public static RoutedEvent DragOverEvent => _IUIElementStatics.Instance.DragOverEvent;
//        public static RoutedEvent DropEvent => _IUIElementStatics.Instance.DropEvent;