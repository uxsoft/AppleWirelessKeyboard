namespace FUI.WinUI

open FUI.UiBuilder
open Microsoft.UI.Xaml.Controls
open Microsoft.UI.Xaml
open System

type GridBuilder(controlType: Type) =
    inherit PanelBuilder(controlType)

    [<CustomOperation("BackgroundSizing")>]
    member _.BackgroundSizing<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.BackgroundSizingProperty) Grid.BackgroundSizingProperty

    [<CustomOperation("BorderBrush")>]
    member _.BorderBrush<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.BorderBrushProperty) Grid.BorderBrushProperty

    [<CustomOperation("BorderThickness")>]
    member _.BorderThickness<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.BorderThicknessProperty) Grid.BorderThicknessProperty

    [<CustomOperation("Column")>]
    member _.Column<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.ColumnProperty) Grid.ColumnProperty

    [<CustomOperation("ColumnSpacing")>]
    member _.ColumnSpacing<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.ColumnSpacingProperty) Grid.ColumnSpacingProperty

    [<CustomOperation("ColumnSpan")>]
    member _.ColumnSpan<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.ColumnSpanProperty) Grid.ColumnSpanProperty

    [<CustomOperation("CornerRadius")>]
    member _.CornerRadius<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.CornerRadiusProperty) Grid.CornerRadiusProperty

    [<CustomOperation("Padding")>]
    member _.Padding<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.PaddingProperty) Grid.PaddingProperty

    [<CustomOperation("Row")>]
    member _.Row<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.RowProperty) Grid.RowProperty

    [<CustomOperation("RowSpacing")>]
    member _.RowSpacing<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.RowSpacingProperty) Grid.RowSpacingProperty

    [<CustomOperation("RowSpan")>]
    member _.RowSpan<'v>(x, v: 'v) =
        Runtime.dependencyProperty x (nameof Grid.RowSpanProperty) Grid.RowSpanProperty
