namespace FUI.WinUI

open FUI.ObservableValue
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System
open Microsoft.UI.Xaml.Media

type GridBuilder(controlType: Type) =
    inherit PanelBuilder(controlType)

    [<CustomOperation("BackgroundSizing")>]
    member _.BackgroundSizing(x, v: BackgroundSizing) =
        Runtime.dependencyProperty x (nameof Grid.BackgroundSizingProperty) Grid.BackgroundSizingProperty v

    [<CustomOperation("BackgroundSizing")>]
    member _.BackgroundSizing(x, v: BackgroundSizing IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.BackgroundSizingProperty) Grid.BackgroundSizingProperty v


    [<CustomOperation("BorderBrush")>]
    member _.BorderBrush(x, v: Brush) =
        Runtime.dependencyProperty x (nameof Grid.BorderBrushProperty) Grid.BorderBrushProperty v

    [<CustomOperation("BorderBrush")>]
    member _.BorderBrush(x, v: Brush IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.BorderBrushProperty) Grid.BorderBrushProperty v


    [<CustomOperation("BorderThickness")>]
    member _.BorderThickness(x, v: Thickness) =
        Runtime.dependencyProperty x (nameof Grid.BorderThicknessProperty) Grid.BorderThicknessProperty v

    [<CustomOperation("BorderThickness")>]
    member _.BorderThickness(x, v: Thickness IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.BorderThicknessProperty) Grid.BorderThicknessProperty v


    [<CustomOperation("ColumnSpacing")>]
    member _.ColumnSpacing(x, v: double) =
        Runtime.dependencyProperty x (nameof Grid.ColumnSpacingProperty) Grid.ColumnSpacingProperty v

    [<CustomOperation("ColumnSpacing")>]
    member _.ColumnSpacing(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.ColumnSpacingProperty) Grid.ColumnSpacingProperty v


    [<CustomOperation("CornerRadius")>]
    member _.CornerRadius(x, v: CornerRadius) =
        Runtime.dependencyProperty x (nameof Grid.CornerRadiusProperty) Grid.CornerRadiusProperty v

    [<CustomOperation("CornerRadius")>]
    member _.CornerRadius(x, v: CornerRadius IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.CornerRadiusProperty) Grid.CornerRadiusProperty v


    [<CustomOperation("Padding")>]
    member _.Padding(x, v: Thickness) =
        Runtime.dependencyProperty x (nameof Grid.PaddingProperty) Grid.PaddingProperty v

    [<CustomOperation("Padding")>]
    member _.Padding(x, v: Thickness IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.PaddingProperty) Grid.PaddingProperty v


    [<CustomOperation("RowSpacing")>]
    member _.RowSpacing(x, v: double) =
        Runtime.dependencyProperty x (nameof Grid.RowSpacingProperty) Grid.RowSpacingProperty v

    [<CustomOperation("RowSpacing")>]
    member _.RowSpacing(x, v: double IObservableValue) =
        Runtime.dependencyProperty x (nameof Grid.RowSpacingProperty) Grid.RowSpacingProperty v
