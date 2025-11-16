using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace AppleExplorer.Desktop.Converters;

public class VisibilityTextConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isVisible)
            return isVisible ? "Visible" : "Hidden";
        return "Hidden";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
