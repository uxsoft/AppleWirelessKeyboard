namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml

type UIElementBuilder() =
    inherit UiBuilder()

    [<CustomOperation("AccessKey")>]
    member _.accessKey<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyProperty) UIElement.AccessKeyProperty

    [<CustomOperation("AccessKeyScopeOwner")>]
    member _.AccessKeyScopeOwner<'t>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AccessKeyScopeOwnerProperty) UIElement.AccessKeyScopeOwnerProperty

    [<CustomOperation("AllowDrop")>]
    member _.AllowDrop<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof UIElement.AllowDropProperty) UIElement.AllowDropProperty
//

//
//        public static DependencyProperty CacheModeProperty => _IUIElementStatics.Instance.CacheModeProperty;
//
//        public static DependencyProperty CanBeScrollAnchorProperty => _IUIElementStatics.Instance.CanBeScrollAnchorProperty;
//
//        public static DependencyProperty CanDragProperty => _IUIElementStatics.Instance.CanDragProperty;
//
//        public static RoutedEvent CharacterReceivedEvent => _IUIElementStatics.Instance.CharacterReceivedEvent;
//
//        public static DependencyProperty ClipProperty => _IUIElementStatics.Instance.ClipProperty;
//
//        public static DependencyProperty CompositeModeProperty => _IUIElementStatics.Instance.CompositeModeProperty;
//
//        public static DependencyProperty ContextFlyoutProperty => _IUIElementStatics.Instance.ContextFlyoutProperty;
//
//        public static RoutedEvent ContextRequestedEvent => _IUIElementStatics.Instance.ContextRequestedEvent;
//
//        public static RoutedEvent DoubleTappedEvent => _IUIElementStatics.Instance.DoubleTappedEvent;
//
//        public static RoutedEvent DragEnterEvent => _IUIElementStatics.Instance.DragEnterEvent;
//
//        public static RoutedEvent DragLeaveEvent => _IUIElementStatics.Instance.DragLeaveEvent;
//
//        public static RoutedEvent DragOverEvent => _IUIElementStatics.Instance.DragOverEvent;
//
//        public static RoutedEvent DropEvent => _IUIElementStatics.Instance.DropEvent;
//
//        public static DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty => _IUIElementStatics.Instance.ExitDisplayModeOnAccessKeyInvokedProperty;
//
//        public static DependencyProperty FocusStateProperty => _IUIElementStatics.Instance.FocusStateProperty;
//
//        public static RoutedEvent GettingFocusEvent => _IUIElementStatics.Instance.GettingFocusEvent;
//
//        public static DependencyProperty HighContrastAdjustmentProperty => _IUIElementStatics.Instance.HighContrastAdjustmentProperty;
//
//        public static RoutedEvent HoldingEvent => _IUIElementStatics.Instance.HoldingEvent;
//
//        public static DependencyProperty IsAccessKeyScopeProperty => _IUIElementStatics.Instance.IsAccessKeyScopeProperty;
//
//        public static DependencyProperty IsDoubleTapEnabledProperty => _IUIElementStatics.Instance.IsDoubleTapEnabledProperty;
//
//        public static DependencyProperty IsHitTestVisibleProperty => _IUIElementStatics.Instance.IsHitTestVisibleProperty;
//
//        public static DependencyProperty IsHoldingEnabledProperty => _IUIElementStatics.Instance.IsHoldingEnabledProperty;
//
//        public static DependencyProperty IsRightTapEnabledProperty => _IUIElementStatics.Instance.IsRightTapEnabledProperty;
//
//        public static DependencyProperty IsTabStopProperty => _IUIElementStatics.Instance.IsTabStopProperty;
//
//        public static DependencyProperty IsTapEnabledProperty => _IUIElementStatics.Instance.IsTapEnabledProperty;
//
//        public static RoutedEvent KeyDownEvent => _IUIElementStatics.Instance.KeyDownEvent;
//
//        public static DependencyProperty KeyTipHorizontalOffsetProperty => _IUIElementStatics.Instance.KeyTipHorizontalOffsetProperty;
//
//        public static DependencyProperty KeyTipPlacementModeProperty => _IUIElementStatics.Instance.KeyTipPlacementModeProperty;
//
//        public static DependencyProperty KeyTipTargetProperty => _IUIElementStatics.Instance.KeyTipTargetProperty;
//
//        public static DependencyProperty KeyTipVerticalOffsetProperty => _IUIElementStatics.Instance.KeyTipVerticalOffsetProperty;
//
//        public static RoutedEvent KeyUpEvent => _IUIElementStatics.Instance.KeyUpEvent;
//
//        public static DependencyProperty KeyboardAcceleratorPlacementModeProperty => _IUIElementStatics.Instance.KeyboardAcceleratorPlacementModeProperty;
//
//        public static DependencyProperty KeyboardAcceleratorPlacementTargetProperty => _IUIElementStatics.Instance.KeyboardAcceleratorPlacementTargetProperty;
//
//        public static DependencyProperty LightsProperty => _IUIElementStatics.Instance.LightsProperty;
//
//        public static DependencyProperty ManipulationModeProperty => _IUIElementStatics.Instance.ManipulationModeProperty;
//
//        public static DependencyProperty OpacityProperty => _IUIElementStatics.Instance.OpacityProperty;
//
//        public static DependencyProperty PointerCapturesProperty => _IUIElementStatics.Instance.PointerCapturesProperty;
//
//        public static DependencyProperty ProjectionProperty => _IUIElementStatics.Instance.ProjectionProperty;
//
//        public static DependencyProperty RenderTransformOriginProperty => _IUIElementStatics.Instance.RenderTransformOriginProperty;
//
//        public static DependencyProperty RenderTransformProperty => _IUIElementStatics.Instance.RenderTransformProperty;
////
//        public static DependencyProperty ShadowProperty => _IUIElementStatics.Instance.ShadowProperty;
//
//        public static DependencyProperty TabFocusNavigationProperty => _IUIElementStatics.Instance.TabFocusNavigationProperty;
//
//        public static DependencyProperty TabIndexProperty => _IUIElementStatics.Instance.TabIndexProperty;
//
//        public static DependencyProperty Transform3DProperty => _IUIElementStatics.Instance.Transform3DProperty;
//
//        public static DependencyProperty TransitionsProperty => _IUIElementStatics.Instance.TransitionsProperty;
//
//        public static DependencyProperty UseLayoutRoundingProperty => _IUIElementStatics.Instance.UseLayoutRoundingProperty;
//
//        public static DependencyProperty UseSystemFocusVisualsProperty => _IUIElementStatics.Instance.UseSystemFocusVisualsProperty;
//
//        public static DependencyProperty VisibilityProperty => _IUIElementStatics.Instance.VisibilityProperty;
//
//        public static DependencyProperty XYFocusDownNavigationStrategyProperty => _IUIElementStatics.Instance.XYFocusDownNavigationStrategyProperty;
//
//        public static DependencyProperty XYFocusDownProperty => _IUIElementStatics.Instance.XYFocusDownProperty;
//
//        public static DependencyProperty XYFocusKeyboardNavigationProperty => _IUIElementStatics.Instance.XYFocusKeyboardNavigationProperty;
//
//        public static DependencyProperty XYFocusLeftNavigationStrategyProperty => _IUIElementStatics.Instance.XYFocusLeftNavigationStrategyProperty;
//
//        public static DependencyProperty XYFocusLeftProperty => _IUIElementStatics.Instance.XYFocusLeftProperty;
//
//        public static DependencyProperty XYFocusRightNavigationStrategyProperty => _IUIElementStatics.Instance.XYFocusRightNavigationStrategyProperty;
//
//        public static DependencyProperty XYFocusRightProperty => _IUIElementStatics.Instance.XYFocusRightProperty;
//
//        public static DependencyProperty XYFocusUpNavigationStrategyProperty => _IUIElementStatics.Instance.XYFocusUpNavigationStrategyProperty;
//
//        public static DependencyProperty XYFocusUpProperty => _IUIElementStatics.Instance.XYFocusUpProperty;

//        public static RoutedEvent BringIntoViewRequestedEvent => _IUIElementStatics.Instance.BringIntoViewRequestedEvent;
//        public static RoutedEvent TappedEvent => _IUIElementStatics.Instance.TappedEvent;
//        public static RoutedEvent RightTappedEvent => _IUIElementStatics.Instance.RightTappedEvent;
//        public static RoutedEvent PointerEnteredEvent => _IUIElementStatics.Instance.PointerEnteredEvent;
//
//        public static RoutedEvent PointerExitedEvent => _IUIElementStatics.Instance.PointerExitedEvent;
//
//        public static RoutedEvent PointerMovedEvent => _IUIElementStatics.Instance.PointerMovedEvent;
//      
//        public static RoutedEvent PointerPressedEvent => _IUIElementStatics.Instance.PointerPressedEvent;
//
//        public static RoutedEvent PointerReleasedEvent => _IUIElementStatics.Instance.PointerReleasedEvent;
//
//        public static RoutedEvent PointerWheelChangedEvent => _IUIElementStatics.Instance.PointerWheelChangedEvent;
//
//        public static RoutedEvent PreviewKeyDownEvent => _IUIElementStatics.Instance.PreviewKeyDownEvent;
//
//        public static RoutedEvent PreviewKeyUpEvent => _IUIElementStatics.Instance.PreviewKeyUpEvent
//        public static RoutedEvent PointerCanceledEvent => _IUIElementStatics.Instance.PointerCanceledEvent;
//
//        public static RoutedEvent PointerCaptureLostEvent => _IUIElementStatics.Instance.PointerCaptureLostEvent
//        public static RoutedEvent ManipulationStartedEvent => _IUIElementStatics.Instance.ManipulationStartedEvent;
//
//        public static RoutedEvent ManipulationStartingEvent => _IUIElementStatics.Instance.ManipulationStartingEvent;
//
//        public static RoutedEvent NoFocusCandidateFoundEvent => _IUIElementStatics.Instance.NoFocusCandidateFoundEvent
//        public static RoutedEvent LosingFocusEvent => _IUIElementStatics.Instance.LosingFocusEvent;
//
//        public static RoutedEvent ManipulationCompletedEvent => _IUIElementStatics.Instance.ManipulationCompletedEvent;
//
//        public static RoutedEvent ManipulationDeltaEvent => _IUIElementStatics.Instance.ManipulationDeltaEvent;
//
//        public static RoutedEvent ManipulationInertiaStartingEvent => _IUIElementStatics.Instance.ManipulationInertiaStartingEvent;