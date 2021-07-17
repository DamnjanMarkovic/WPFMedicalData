using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFMedicalDataGrid.Helpers;

namespace WPFMedicalDataGrid.Controls
{
    public enum ButtonHandling
    {
        Instantiating,
        Updating
    }

    public static class IButtonValuesImplementation
    {

        private static readonly Type TTypeCustomRadioButton = typeof(CustomRadioButton);

        public static T SetButtonContent<T>(T button, object oldContent, ButtonHandling buttonHandling)
        {
            Type TType = typeof(T);

            var buttonArrived = button as IButton;

            if (TType == TTypeCustomRadioButton)
            {
                var customButton = buttonArrived as CustomRadioButton;
                return (T)Convert.ChangeType(SetValues(customButton, oldContent, buttonHandling), TTypeCustomRadioButton);
            }

            return default(T);
        }

        private static object SetValues(IButton customButton, object oldContent, ButtonHandling buttonHandling)
        {
            if (customButton.CheckedContentPresenter == null) customButton.CheckedContentPresenter = new ContentPresenter();
            if (customButton.MouseOverContentPresenter == null) customButton.MouseOverContentPresenter = new ContentPresenter();
            if (customButton.KeyboardFocusedContentPresenter == null) customButton.KeyboardFocusedContentPresenter = new ContentPresenter();


            switch (buttonHandling)
            {
                case ButtonHandling.Instantiating:

                    object content = customButton.Content;

                    //check if content is set as text

                    if (content != null && content is string)
                    {
                        SetTextValues(customButton, content);
                    }

                    //check if content is set as image

                    else if (content != null && content is Image)
                    {
                        BitmapSource source = (content as Image).Source as BitmapSource;
                        SetImageValues(customButton, source);
                    }
                    //if nor string nor the image/images is set, check if PathDataValue exists and set Geometric shapes

                    else if (customButton.PathDataValue != null)
                    {
                        var pathValue = customButton.PathDataValue;
                        SetPathValues(customButton, pathValue);
                    }

                    return customButton;

                case ButtonHandling.Updating:

                    if (oldContent != null && customButton.Content is string)
                    {
                        SetTextValues(customButton, customButton.Content);
                    }

                    else if (oldContent != null && customButton.Content is Image)
                    {
                        BitmapSource source = (customButton.Content as Image).Source as BitmapSource;

                        if (source != null)
                        {
                            customButton.ImageOnChecked = StaticProperties.ColorBitmapSourceIntoMediaColor(source, customButton.TextColorChecked.Color);
                            customButton.CheckedContentPresenter.Content = customButton.ImageOnChecked;
                            customButton.ImageOnMouseOver = StaticProperties.ColorBitmapSourceIntoMediaColor(source, customButton.TextColorMouseOver.Color);
                            customButton.MouseOverContentPresenter.Content = customButton.ImageOnMouseOver;
                            customButton.ImageOnKeyboardFocused = StaticProperties.ColorBitmapSourceIntoMediaColor(source, customButton.TextColorMouseOver.Color);
                            customButton.KeyboardFocusedContentPresenter.Content = customButton.ImageOnKeyboardFocused;
                        }
                    }

                    else if (oldContent != null && customButton.Content is Grid)
                    {
                        SetPathValues(customButton, oldContent);
                    }

                    return customButton;

                default:
                    return null;
            }

        }

        private static Path GetPathValues(IButton customButton, Geometry data)
        {
            Path path = new Path();
            path.Data = data;
            path.Fill = customButton.Foreground;
            path.Stretch = Stretch.Uniform;
            path.Margin = customButton.MarginImage;
            return path;
        }

        private static void SetPathValues(IButton customButton, object oldPathGrid)
        {
            customButton.CheckedContentPresenter = new ContentPresenter();
            customButton.MouseOverContentPresenter = new ContentPresenter();
            customButton.KeyboardFocusedContentPresenter = new ContentPresenter();

            var pathInCustomButton = StaticProperties.GetChildOfType<Path>(customButton.Content as Grid);
            var oldPathValue = StaticProperties.GetChildOfType<Path>(oldPathGrid as Grid);

            if (customButton.Content == null)
            {
                customButton.CanvasContent = new Grid();
                customButton.CanvasContent.Children.Add(GetPathValues(customButton, customButton.PathDataValue));
                customButton.Content = customButton.CanvasContent;
            }
            else if (pathInCustomButton != null && oldPathValue == null || oldPathValue != null && pathInCustomButton.Data != oldPathValue.Data)
            {
                customButton.CanvasContent = new Grid();
                customButton.CanvasContent.Children.Add(GetPathValues(customButton, pathInCustomButton.Data));
                customButton.Content = customButton.CanvasContent;
            }

            pathInCustomButton = StaticProperties.GetChildOfType<Path>(customButton.Content as Grid);

            Path pathchecked = new Path();
            pathchecked.Data = pathInCustomButton.Data;
            pathchecked.Fill = customButton.TextColorChecked;
            pathchecked.Stretch = Stretch.Uniform;
            pathchecked.Margin = customButton.MarginImage;
            if (customButton.CanvasChecked == null) customButton.CanvasChecked = new Grid();
            customButton.CanvasChecked.Children.Clear();
            customButton.CanvasChecked.Children.Add(pathchecked);
            if (customButton.TextColorChecked != null)
            {
                customButton.CanvasChecked.Effect = StaticProperties.SetDropShadowEffect(customButton.TextColorChecked.Color);
                customButton.CheckedContentPresenter.Content = customButton.CanvasChecked;
            }


            Path pathMouseOver = new Path();
            pathMouseOver.Data = pathInCustomButton.Data;
            pathMouseOver.Stretch = Stretch.Uniform;
            pathMouseOver.Margin = customButton.MarginImage;
            pathMouseOver.Fill = customButton.TextColorMouseOver;
            if (customButton.CanvasMouseOver == null) customButton.CanvasMouseOver = new Grid();
            customButton.CanvasMouseOver.Children.Clear();
            customButton.CanvasMouseOver.Children.Add(pathMouseOver);

            Path pathKeyboardFocused = new Path();
            pathKeyboardFocused.Data = pathInCustomButton.Data;
            pathKeyboardFocused.Stretch = Stretch.Uniform;
            pathKeyboardFocused.Margin = customButton.MarginImage;
            pathKeyboardFocused.Fill = customButton.TextColorMouseOver;
            if (customButton.CanvasKeyboardFocused == null) customButton.CanvasKeyboardFocused = new Grid();
            customButton.CanvasKeyboardFocused.Children.Clear();
            customButton.CanvasKeyboardFocused.Children.Add(pathKeyboardFocused);

            if (customButton.TextColorMouseOver != null)
            {
                customButton.CanvasMouseOver.Effect = StaticProperties.SetDropShadowEffect(customButton.TextColorMouseOver.Color);
                customButton.MouseOverContentPresenter.Content = customButton.CanvasMouseOver;
                customButton.CanvasKeyboardFocused.Effect = StaticProperties.SetDropShadowEffect(customButton.TextColorMouseOver.Color);
                customButton.KeyboardFocusedContentPresenter.Content = customButton.CanvasKeyboardFocused;
            }
        }

        private static void SetImageValues(IButton customButton, BitmapSource source)
        {
            if (source != null)
            {
                //if there is no image set, 
                //we will color the arrived image and use that one

                customButton.CheckedContentPresenter.Content = (customButton.ImageOnChecked != null) ?
                    customButton.ImageOnChecked :
                    StaticProperties.ColorBitmapSourceIntoMediaColor(source, customButton.TextColorChecked.Color);

                customButton.MouseOverContentPresenter.Content = (customButton.ImageOnMouseOver != null) ?
                    customButton.ImageOnMouseOver :
                    StaticProperties.ColorBitmapSourceIntoMediaColor(source, customButton.TextColorMouseOver.Color);

                customButton.KeyboardFocusedContentPresenter.Content = (customButton.ImageOnKeyboardFocused != null) ?
                    customButton.ImageOnKeyboardFocused :
                    StaticProperties.ColorBitmapSourceIntoMediaColor(source, customButton.TextColorMouseOver.Color);
            }

        }

        private static void SetTextValues(IButton customButton, object content)
        {
            var textEElement = new TextBlock();
            textEElement.Background = Brushes.Transparent;

            var textEElementChecked = new TextBlock();
            textEElementChecked.Background = Brushes.Transparent;
            textEElementChecked.Text = content as string;
            textEElementChecked.Foreground = customButton.TextColorChecked;
            customButton.CheckedContentPresenter.Content = textEElementChecked;

            var textEElementMouseOver = new TextBlock();
            textEElementMouseOver.Text = content as string;
            textEElementMouseOver.Foreground = customButton.TextColorMouseOver;

            var textElementKeyboardFocused = new TextBlock();
            textElementKeyboardFocused.Text = content as string;
            textElementKeyboardFocused.Foreground = customButton.TextColorMouseOver;


            if (customButton.TextColorMouseOver != null)
            {
                customButton.MouseOverContentPresenter.Effect = StaticProperties.SetDropShadowEffect(customButton.TextColorMouseOver.Color);
                customButton.MouseOverContentPresenter.Content = textEElementMouseOver;
                customButton.KeyboardFocusedContentPresenter.Effect = StaticProperties.SetDropShadowEffect(customButton.TextColorMouseOver.Color);
                customButton.KeyboardFocusedContentPresenter.Content = textElementKeyboardFocused;
            }
        }
    }
}
