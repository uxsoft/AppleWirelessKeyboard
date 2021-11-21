namespace FUI.WinUI

open FUI
open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open System

type NavigationViewBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("AlwaysShowHeader")>]
    member _.AlwaysShowHeader<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.AlwaysShowHeaderProperty) NavigationView.AlwaysShowHeaderProperty v
        
    [<CustomOperation("AutoSuggestBox")>]
    member _.AutoSuggestBox<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.AutoSuggestBoxProperty) NavigationView.AutoSuggestBoxProperty v
        
    [<CustomOperation("CompactModeThresholdWidth")>]
    member _.CompactModeThresholdWidth<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.CompactModeThresholdWidthProperty) NavigationView.CompactModeThresholdWidthProperty v
        
    [<CustomOperation("CompactPaneLength")>]
    member _.CompactPaneLength<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.CompactPaneLengthProperty) NavigationView.CompactPaneLengthProperty v
        
    [<CustomOperation("DisplayMode")>]
    member _.DisplayMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.DisplayModeProperty) NavigationView.DisplayModeProperty v
        
    [<CustomOperation("ExpandedModeThresholdWidth")>]
    member _.ExpandedModeThresholdWidth<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.ExpandedModeThresholdWidthProperty) NavigationView.ExpandedModeThresholdWidthProperty v
        
    [<CustomOperation("FooterMenuItems")>]
    member _.FooterMenuItems<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.FooterMenuItemsProperty) NavigationView.FooterMenuItemsProperty v
        
    [<CustomOperation("FooterMenuItemsSource")>]
    member _.FooterMenuItemsSource<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.FooterMenuItemsSourceProperty) NavigationView.FooterMenuItemsSourceProperty v
        
    [<CustomOperation("Header")>]
    member _.Header<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.HeaderProperty) NavigationView.HeaderProperty v
        
    [<CustomOperation("HeaderTemplate")>]
    member _.HeaderTemplate<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.HeaderTemplateProperty) NavigationView.HeaderTemplateProperty v
        
    [<CustomOperation("IsPaneOpen")>]
    member _.IsPaneOpen<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneOpenProperty) NavigationView.IsPaneOpenProperty v
        
    [<CustomOperation("IsPaneToggleButtonVisible")>]
    member _.IsPaneToggleButtonVisible<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneToggleButtonVisibleProperty) NavigationView.IsPaneToggleButtonVisibleProperty v
        
    [<CustomOperation("IsSettingsVisible")>]
    member _.IsSettingsVisible<'v>(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsSettingsVisibleProperty) NavigationView.IsSettingsVisibleProperty v
        
    [<CustomOperation("IsSettingsVisible")>]
    member _.IsSettingsVisible<'v>(x, v: bool var) =
        Runtime.dependencyProperty x (nameof NavigationView.IsSettingsVisibleProperty) NavigationView.IsSettingsVisibleProperty v
        
    [<CustomOperation("IsTitleBarAutoPaddingEnabled")>]
    member _.IsTitleBarAutoPaddingEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.IsTitleBarAutoPaddingEnabledProperty) NavigationView.IsTitleBarAutoPaddingEnabledProperty v
        
    [<CustomOperation("MenuItemContainerStyle")>]
    member _.MenuItemContainerStyle<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemContainerStyleProperty) NavigationView.MenuItemContainerStyleProperty v
        
    [<CustomOperation("MenuItemContainerStyleSelector")>]
    member _.MenuItemContainerStyleSelector<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemContainerStyleSelectorProperty) NavigationView.MenuItemContainerStyleSelectorProperty v
        
    [<CustomOperation("MenuItemTemplate")>]
    member _.MenuItemTemplate<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemTemplateProperty) NavigationView.MenuItemTemplateProperty v
        
    [<CustomOperation("MenuItemTemplateSelector")>]
    member _.MenuItemTemplateSelector<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemTemplateSelectorProperty) NavigationView.MenuItemTemplateSelectorProperty v
        
    [<CustomOperation("MenuItems")>]
    member _.MenuItems<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemsProperty) NavigationView.MenuItemsProperty v
        
    [<CustomOperation("MenuItemsSource")>]
    member _.MenuItemsSource<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemsSourceProperty) NavigationView.MenuItemsSourceProperty v
        
    [<CustomOperation("OpenPaneLength")>]
    member _.OpenPaneLength<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.OpenPaneLengthProperty) NavigationView.OpenPaneLengthProperty v
        
    [<CustomOperation("PaneFooter")>]
    member _.PaneFooter<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneFooterProperty) NavigationView.PaneFooterProperty v
        
    [<CustomOperation("PaneToggleButtonStyle")>]
    member _.PaneToggleButtonStyle<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneToggleButtonStyleProperty) NavigationView.PaneToggleButtonStyleProperty v
        
    [<CustomOperation("SelectedItem")>]
    member _.SelectedItem<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.SelectedItemProperty) NavigationView.SelectedItemProperty v
        
    [<CustomOperation("SettingsItem")>]
    member _.SettingsItem<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.SettingsItemProperty) NavigationView.SettingsItemProperty v
        
    [<CustomOperation("ContentOverlay")>]
    member _.ContentOverlay<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.ContentOverlayProperty) NavigationView.ContentOverlayProperty v
        
    [<CustomOperation("IsBackButtonVisible")>]
    member _.IsBackButtonVisible<'v>(x, v: NavigationViewBackButtonVisible) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackButtonVisibleProperty) NavigationView.IsBackButtonVisibleProperty v
        
    [<CustomOperation("IsBackButtonVisible")>]
    member _.IsBackButtonVisible<'v>(x, v: NavigationViewBackButtonVisible var) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackButtonVisibleProperty) NavigationView.IsBackButtonVisibleProperty v
    
    [<CustomOperation("IsBackEnabled")>]
    member _.IsBackEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackEnabledProperty) NavigationView.IsBackEnabledProperty v
        
    [<CustomOperation("IsPaneVisible")>]
    member _.IsPaneVisible<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneVisibleProperty) NavigationView.IsPaneVisibleProperty v
        
    [<CustomOperation("OverflowLabelMode")>]
    member _.OverflowLabelMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.OverflowLabelModeProperty) NavigationView.OverflowLabelModeProperty v
        
    [<CustomOperation("PaneCustomContent")>]
    member _.PaneCustomContent<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneCustomContentProperty) NavigationView.PaneCustomContentProperty v
        
    [<CustomOperation("PaneDisplayMode")>]
    member _.PaneDisplayMode<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneDisplayModeProperty) NavigationView.PaneDisplayModeProperty v
        
    [<CustomOperation("PaneHeader")>]
    member _.PaneHeader<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneHeaderProperty) NavigationView.PaneHeaderProperty v
        
    [<CustomOperation("PaneTitle")>]
    member _.PaneTitle<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneTitleProperty) NavigationView.PaneTitleProperty v
        
    [<CustomOperation("SelectionFollowsFocus")>]
    member _.SelectionFollowsFocus<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.SelectionFollowsFocusProperty) NavigationView.SelectionFollowsFocusProperty v
        
    [<CustomOperation("ShoulderNavigationEnabled")>]
    member _.ShoulderNavigationEnabled<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.ShoulderNavigationEnabledProperty) NavigationView.ShoulderNavigationEnabledProperty v
        
    [<CustomOperation("TemplateSettings")>]
    member _.TemplateSettings<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.TemplateSettingsProperty) NavigationView.TemplateSettingsProperty v
        
    [<CustomOperation("DisplayModeChanged")>]
    member _.DisplayModeChanged(x, v) =
        Runtime.event x "DisplayModeChanged" v
            (fun (c: NavigationView) -> c.add_DisplayModeChanged)
            (fun (c: NavigationView) -> c.remove_DisplayModeChanged)
    
    [<CustomOperation("ItemInvoked")>]
    member _.ItemInvoked(x, v) =
        Runtime.event x "ItemInvoked" v
            (fun (c: NavigationView) -> c.add_ItemInvoked)
            (fun (c: NavigationView) -> c.remove_ItemInvoked)
            
    [<CustomOperation("SelectionChanged")>]
    member _.SelectionChanged(x, v) =
        Runtime.event x "SelectionChanged" v
            (fun (c: NavigationView) -> c.add_SelectionChanged)
            (fun (c: NavigationView) -> c.remove_SelectionChanged)
            
    [<CustomOperation("BackRequested")>]
    member _.BackRequested(x, v) =
        Runtime.event x "BackRequested" v
            (fun (c: NavigationView) -> c.add_BackRequested)
            (fun (c: NavigationView) -> c.remove_BackRequested)
            
    [<CustomOperation("Collapsed")>]
    member _.Collapsed(x, v) =
        Runtime.event x "Collapsed" v
            (fun (c: NavigationView) -> c.add_Collapsed)
            (fun (c: NavigationView) -> c.remove_Collapsed)
            
    [<CustomOperation("Expanding")>]
    member _.Expanding(x, v) =
        Runtime.event x "Expanding" v
            (fun (c: NavigationView) -> c.add_Expanding)
            (fun (c: NavigationView) -> c.remove_Expanding)
            
    [<CustomOperation("PaneClosed")>]
    member _.PaneClosed(x, v) =
        Runtime.event x "PaneClosed" v
            (fun (c: NavigationView) -> c.add_PaneClosed)
            (fun (c: NavigationView) -> c.remove_PaneClosed)
            
    [<CustomOperation("PaneClosing")>]
    member _.PaneClosing(x, v) =
        Runtime.event x "PaneClosing" v
            (fun (c: NavigationView) -> c.add_PaneClosing)
            (fun (c: NavigationView) -> c.remove_PaneClosing)
            
    [<CustomOperation("PaneOpened")>]
    member _.PaneOpened(x, v) =
        Runtime.event x "PaneOpened" v
            (fun (c: NavigationView) -> c.add_PaneOpened)
            (fun (c: NavigationView) -> c.remove_PaneOpened)
            
    [<CustomOperation("PaneOpening")>]
    member _.PaneOpening(x, v) =
        Runtime.event x "PaneOpening" v
            (fun (c: NavigationView) -> c.add_PaneOpening)
            (fun (c: NavigationView) -> c.remove_PaneOpening)
    