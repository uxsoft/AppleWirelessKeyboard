namespace FUI.WinUI

open System.Collections.Generic
open System.Windows
open System.Windows.Controls
open FUI
open FUI.ObservableValue
open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls
open System

type NavigationViewBuilder(controlType: Type) =
    inherit ContentControlBuilder(controlType)

    [<CustomOperation("AlwaysShowHeader")>]
    member _.AlwaysShowHeader(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.AlwaysShowHeaderProperty) NavigationView.AlwaysShowHeaderProperty v
    
    [<CustomOperation("AlwaysShowHeader")>]
    member _.AlwaysShowHeader(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.AlwaysShowHeaderProperty) NavigationView.AlwaysShowHeaderProperty v
    
        
    [<CustomOperation("AutoSuggestBox")>]
    member _.AutoSuggestBox(x, v: AutoSuggestBox) =
        Runtime.dependencyProperty x (nameof NavigationView.AutoSuggestBoxProperty) NavigationView.AutoSuggestBoxProperty v
    
    [<CustomOperation("AutoSuggestBox")>]
    member _.AutoSuggestBox(x, v: AutoSuggestBox IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.AutoSuggestBoxProperty) NavigationView.AutoSuggestBoxProperty v
    
        
    [<CustomOperation("CompactModeThresholdWidth")>]
    member _.CompactModeThresholdWidth(x, v: double) =
        Runtime.dependencyProperty x (nameof NavigationView.CompactModeThresholdWidthProperty) NavigationView.CompactModeThresholdWidthProperty v
    
    [<CustomOperation("CompactModeThresholdWidth")>]
    member _.CompactModeThresholdWidth(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.CompactModeThresholdWidthProperty) NavigationView.CompactModeThresholdWidthProperty v
    
        
    [<CustomOperation("CompactPaneLength")>]
    member _.CompactPaneLength(x, v: double) =
        Runtime.dependencyProperty x (nameof NavigationView.CompactPaneLengthProperty) NavigationView.CompactPaneLengthProperty v
    
    [<CustomOperation("CompactPaneLength")>]
    member _.CompactPaneLength(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.CompactPaneLengthProperty) NavigationView.CompactPaneLengthProperty v
    
        
    [<CustomOperation("DisplayMode")>]
    member _.DisplayMode(x, v: NavigationViewDisplayMode) =
        Runtime.dependencyProperty x (nameof NavigationView.DisplayModeProperty) NavigationView.DisplayModeProperty v
    
    [<CustomOperation("DisplayMode")>]
    member _.DisplayMode(x, v: NavigationViewDisplayMode IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.DisplayModeProperty) NavigationView.DisplayModeProperty v
    
        
    [<CustomOperation("ExpandedModeThresholdWidth")>]
    member _.ExpandedModeThresholdWidth(x, v: double) =
        Runtime.dependencyProperty x (nameof NavigationView.ExpandedModeThresholdWidthProperty) NavigationView.ExpandedModeThresholdWidthProperty v
    
    [<CustomOperation("ExpandedModeThresholdWidth")>]
    member _.ExpandedModeThresholdWidth(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.ExpandedModeThresholdWidthProperty) NavigationView.ExpandedModeThresholdWidthProperty v
    

// read only, must do add/remove        
//    [<CustomOperation("FooterMenuItems")>]
//    member _.FooterMenuItems(x, v: IList) =
//        Runtime.dependencyProperty x (nameof NavigationView.FooterMenuItemsProperty) NavigationView.FooterMenuItemsProperty v
//    
//    [<CustomOperation("FooterMenuItems")>]
//    member _.FooterMenuItems(x, v: IList IObservableValue) =
//        Runtime.dependencyProperty x (nameof NavigationView.FooterMenuItemsProperty) NavigationView.FooterMenuItemsProperty v
    
        
    [<CustomOperation("FooterMenuItemsSource")>]
    member _.FooterMenuItemsSource(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.FooterMenuItemsSourceProperty) NavigationView.FooterMenuItemsSourceProperty v
    
    [<CustomOperation("FooterMenuItemsSource")>]
    member _.FooterMenuItemsSource(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.FooterMenuItemsSourceProperty) NavigationView.FooterMenuItemsSourceProperty v
    
        
    [<CustomOperation("Header")>]
    member _.Header(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.HeaderProperty) NavigationView.HeaderProperty v
    
    [<CustomOperation("Header")>]
    member _.Header(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.HeaderProperty) NavigationView.HeaderProperty v
    
        
    [<CustomOperation("HeaderTemplate")>]
    member _.HeaderTemplate(x, v: DataTemplate) =
        Runtime.dependencyProperty x (nameof NavigationView.HeaderTemplateProperty) NavigationView.HeaderTemplateProperty v
    
    [<CustomOperation("HeaderTemplate")>]
    member _.HeaderTemplate(x, v: DataTemplate IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.HeaderTemplateProperty) NavigationView.HeaderTemplateProperty v
    
        
    [<CustomOperation("IsPaneOpen")>]
    member _.IsPaneOpen(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneOpenProperty) NavigationView.IsPaneOpenProperty v
    
    [<CustomOperation("IsPaneOpen")>]
    member _.IsPaneOpen(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneOpenProperty) NavigationView.IsPaneOpenProperty v
    
        
    [<CustomOperation("IsPaneToggleButtonVisible")>]
    member _.IsPaneToggleButtonVisible(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneToggleButtonVisibleProperty) NavigationView.IsPaneToggleButtonVisibleProperty v
    
    [<CustomOperation("IsPaneToggleButtonVisible")>]
    member _.IsPaneToggleButtonVisible(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneToggleButtonVisibleProperty) NavigationView.IsPaneToggleButtonVisibleProperty v
    
        
    [<CustomOperation("IsSettingsVisible")>]
    member _.IsSettingsVisible(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsSettingsVisibleProperty) NavigationView.IsSettingsVisibleProperty v
    
    [<CustomOperation("IsSettingsVisible")>]
    member _.IsSettingsVisible(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsSettingsVisibleProperty) NavigationView.IsSettingsVisibleProperty v
    
        
    [<CustomOperation("IsTitleBarAutoPaddingEnabled")>]
    member _.IsTitleBarAutoPaddingEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsTitleBarAutoPaddingEnabledProperty) NavigationView.IsTitleBarAutoPaddingEnabledProperty v
    
    [<CustomOperation("IsTitleBarAutoPaddingEnabled")>]
    member _.IsTitleBarAutoPaddingEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsTitleBarAutoPaddingEnabledProperty) NavigationView.IsTitleBarAutoPaddingEnabledProperty v
    
        
    [<CustomOperation("MenuItemContainerStyle")>]
    member _.MenuItemContainerStyle(x, v: Style) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemContainerStyleProperty) NavigationView.MenuItemContainerStyleProperty v
    
    [<CustomOperation("MenuItemContainerStyle")>]
    member _.MenuItemContainerStyle(x, v: Style IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemContainerStyleProperty) NavigationView.MenuItemContainerStyleProperty v
    
        
    [<CustomOperation("MenuItemContainerStyleSelector")>]
    member _.MenuItemContainerStyleSelector(x, v: StyleSelector) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemContainerStyleSelectorProperty) NavigationView.MenuItemContainerStyleSelectorProperty v
    
    [<CustomOperation("MenuItemContainerStyleSelector")>]
    member _.MenuItemContainerStyleSelector(x, v: StyleSelector IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemContainerStyleSelectorProperty) NavigationView.MenuItemContainerStyleSelectorProperty v
    
        
    [<CustomOperation("MenuItemTemplate")>]
    member _.MenuItemTemplate(x, v: DataTemplate) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemTemplateProperty) NavigationView.MenuItemTemplateProperty v
    
    [<CustomOperation("MenuItemTemplate")>]
    member _.MenuItemTemplate(x, v: DataTemplate IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemTemplateProperty) NavigationView.MenuItemTemplateProperty v
    
        
    [<CustomOperation("MenuItemTemplateSelector")>]
    member _.MenuItemTemplateSelector(x, v: DataTemplateSelector) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemTemplateSelectorProperty) NavigationView.MenuItemTemplateSelectorProperty v
    
    [<CustomOperation("MenuItemTemplateSelector")>]
    member _.MenuItemTemplateSelector(x, v: DataTemplateSelector IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemTemplateSelectorProperty) NavigationView.MenuItemTemplateSelectorProperty v
    
        
//    [<CustomOperation("MenuItems")>]
//    member _.MenuItems(x, v: 'v) =
//        Runtime.dependencyProperty x (nameof NavigationView.MenuItemsProperty) NavigationView.MenuItemsProperty v
//    
//    [<CustomOperation("MenuItems")>]
//    member _.MenuItems(x, v: 'v) =
//        Runtime.dependencyProperty x (nameof NavigationView.MenuItemsProperty) NavigationView.MenuItemsProperty v
    
        
    [<CustomOperation("MenuItemsSource")>]
    member _.MenuItemsSource(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemsSourceProperty) NavigationView.MenuItemsSourceProperty v
    
    [<CustomOperation("MenuItemsSource")>]
    member _.MenuItemsSource(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.MenuItemsSourceProperty) NavigationView.MenuItemsSourceProperty v
    
        
    [<CustomOperation("OpenPaneLength")>]
    member _.OpenPaneLength(x, v: double) =
        Runtime.dependencyProperty x (nameof NavigationView.OpenPaneLengthProperty) NavigationView.OpenPaneLengthProperty v
    
    [<CustomOperation("OpenPaneLength")>]
    member _.OpenPaneLength(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.OpenPaneLengthProperty) NavigationView.OpenPaneLengthProperty v
    
        
    [<CustomOperation("PaneFooter")>]
    member _.PaneFooter(x, v: UIElement) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneFooterProperty) NavigationView.PaneFooterProperty v
    
    [<CustomOperation("PaneFooter")>]
    member _.PaneFooter(x, v: UIElement IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneFooterProperty) NavigationView.PaneFooterProperty v
    
        
    [<CustomOperation("PaneToggleButtonStyle")>]
    member _.PaneToggleButtonStyle(x, v: Style) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneToggleButtonStyleProperty) NavigationView.PaneToggleButtonStyleProperty v
    
    [<CustomOperation("PaneToggleButtonStyle")>]
    member _.PaneToggleButtonStyle(x, v: Style IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneToggleButtonStyleProperty) NavigationView.PaneToggleButtonStyleProperty v
    
        
    [<CustomOperation("SelectedItem")>]
    member _.SelectedItem(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.SelectedItemProperty) NavigationView.SelectedItemProperty v
    
    [<CustomOperation("SelectedItem")>]
    member _.SelectedItem(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.SelectedItemProperty) NavigationView.SelectedItemProperty v
    
        
    [<CustomOperation("SettingsItem")>]
    member _.SettingsItem(x, v: 'v) =
        Runtime.dependencyProperty x (nameof NavigationView.SettingsItemProperty) NavigationView.SettingsItemProperty v
    
    [<CustomOperation("SettingsItem")>]
    member _.SettingsItem(x, v: 'v IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.SettingsItemProperty) NavigationView.SettingsItemProperty v
    
        
    [<CustomOperation("ContentOverlay")>]
    member _.ContentOverlay(x, v: UIElement) =
        Runtime.dependencyProperty x (nameof NavigationView.ContentOverlayProperty) NavigationView.ContentOverlayProperty v
    
    [<CustomOperation("ContentOverlay")>]
    member _.ContentOverlay(x, v: UIElement IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.ContentOverlayProperty) NavigationView.ContentOverlayProperty v
    
        
    [<CustomOperation("IsBackButtonVisible")>]
    member _.IsBackButtonVisible(x, v: NavigationViewBackButtonVisible) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackButtonVisibleProperty) NavigationView.IsBackButtonVisibleProperty v
    
    [<CustomOperation("IsBackButtonVisible")>]
    member _.IsBackButtonVisible(x, v: NavigationViewBackButtonVisible IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackButtonVisibleProperty) NavigationView.IsBackButtonVisibleProperty v
    
    
    [<CustomOperation("IsBackEnabled")>]
    member _.IsBackEnabled(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackEnabledProperty) NavigationView.IsBackEnabledProperty v
    
    [<CustomOperation("IsBackEnabled")>]
    member _.IsBackEnabled(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsBackEnabledProperty) NavigationView.IsBackEnabledProperty v
    
        
    [<CustomOperation("IsPaneVisible")>]
    member _.IsPaneVisible(x, v: bool) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneVisibleProperty) NavigationView.IsPaneVisibleProperty v
    
    [<CustomOperation("IsPaneVisible")>]
    member _.IsPaneVisible(x, v: bool IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.IsPaneVisibleProperty) NavigationView.IsPaneVisibleProperty v
    
        
    [<CustomOperation("OverflowLabelMode")>]
    member _.OverflowLabelMode(x, v: NavigationViewOverflowLabelMode) =
        Runtime.dependencyProperty x (nameof NavigationView.OverflowLabelModeProperty) NavigationView.OverflowLabelModeProperty v
    
    [<CustomOperation("OverflowLabelMode")>]
    member _.OverflowLabelMode(x, v: NavigationViewOverflowLabelMode IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.OverflowLabelModeProperty) NavigationView.OverflowLabelModeProperty v
    
        
    [<CustomOperation("PaneCustomContent")>]
    member _.PaneCustomContent(x, v: UIElement) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneCustomContentProperty) NavigationView.PaneCustomContentProperty v
    
    [<CustomOperation("PaneCustomContent")>]
    member _.PaneCustomContent(x, v: UIElement IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneCustomContentProperty) NavigationView.PaneCustomContentProperty v
    
        
    [<CustomOperation("PaneDisplayMode")>]
    member _.PaneDisplayMode(x, v: NavigationViewPaneDisplayMode) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneDisplayModeProperty) NavigationView.PaneDisplayModeProperty v
    
    [<CustomOperation("PaneDisplayMode")>]
    member _.PaneDisplayMode(x, v: NavigationViewPaneDisplayMode IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneDisplayModeProperty) NavigationView.PaneDisplayModeProperty v
    
        
    [<CustomOperation("PaneHeader")>]
    member _.PaneHeader(x, v: UIElement) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneHeaderProperty) NavigationView.PaneHeaderProperty v
    
    [<CustomOperation("PaneHeader")>]
    member _.PaneHeader(x, v: UIElement IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneHeaderProperty) NavigationView.PaneHeaderProperty v
    
        
    [<CustomOperation("PaneTitle")>]
    member _.PaneTitle(x, v: string) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneTitleProperty) NavigationView.PaneTitleProperty v
    
    [<CustomOperation("PaneTitle")>]
    member _.PaneTitle(x, v: string IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.PaneTitleProperty) NavigationView.PaneTitleProperty v
    
        
    [<CustomOperation("SelectionFollowsFocus")>]
    member _.SelectionFollowsFocus(x, v: NavigationViewSelectionFollowsFocus) =
        Runtime.dependencyProperty x (nameof NavigationView.SelectionFollowsFocusProperty) NavigationView.SelectionFollowsFocusProperty v
    
    [<CustomOperation("SelectionFollowsFocus")>]
    member _.SelectionFollowsFocus(x, v: NavigationViewSelectionFollowsFocus IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.SelectionFollowsFocusProperty) NavigationView.SelectionFollowsFocusProperty v
    
        
    [<CustomOperation("ShoulderNavigationEnabled")>]
    member _.ShoulderNavigationEnabled(x, v: NavigationViewShoulderNavigationEnabled) =
        Runtime.dependencyProperty x (nameof NavigationView.ShoulderNavigationEnabledProperty) NavigationView.ShoulderNavigationEnabledProperty v
    
    [<CustomOperation("ShoulderNavigationEnabled")>]
    member _.ShoulderNavigationEnabled(x, v: NavigationViewShoulderNavigationEnabled IObservableValue) =
        Runtime.dependencyProperty x (nameof NavigationView.ShoulderNavigationEnabledProperty) NavigationView.ShoulderNavigationEnabledProperty v
    
        
    [<CustomOperation("TemplateSettings")>]
    member _.TemplateSettings(x, v: NavigationViewTemplateSettings) =
        Runtime.dependencyProperty x (nameof NavigationView.TemplateSettingsProperty) NavigationView.TemplateSettingsProperty v
    
    [<CustomOperation("TemplateSettings")>]
    member _.TemplateSettings(x, v: NavigationViewTemplateSettings IObservableValue) =
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
    