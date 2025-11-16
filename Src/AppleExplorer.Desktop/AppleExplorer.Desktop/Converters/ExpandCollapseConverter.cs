using System;
using System.Globalization;
using Microsoft.Maui.Controls;

using AppleExplorer.Desktop.ViewModeles;

namespace AppleExplorer.Desktop.Converters;
public class ExpandCollapseConverter : IMultiValueConverter
{
    public object? Convert(object[] values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values.Length == 2 && values[0] is bool isExpanded && values[1] is NodeViewModel node)
        {
            return !node.Children.Any() ? "" : isExpanded ? "−" : "+";
        }
        return "?";
    }

    public object[] ConvertBack(object? value, Type[] targetTypes, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

