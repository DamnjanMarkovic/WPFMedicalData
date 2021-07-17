using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFMedicalDataGrid.Controls
{
    public interface IButton
    {
        Grid CanvasContent { get; set; }

        ContentPresenter CheckedContentPresenter { get; set; }

        ContentPresenter MouseOverContentPresenter { get; set; }

        ContentPresenter KeyboardFocusedContentPresenter { get; set; }

        object Content { get; set; }

        Brush Foreground { get; set; }

        Image ImageOnChecked { get; set; }

        Image ImageOnMouseOver { get; set; }

        Image ImageOnKeyboardFocused { get; set; }

        Geometry PathDataValue { get; set; }

        Thickness MarginImage { get; set; }

        Grid CanvasChecked { get; set; }

        Grid CanvasMouseOver { get; set; }

        Grid CanvasKeyboardFocused { get; set; }

        SolidColorBrush TextColorChecked { get; set; }

        SolidColorBrush TextColorMouseOver { get; set; }

    }
}
