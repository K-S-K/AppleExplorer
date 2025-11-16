using System.Globalization;

namespace AppleExplorer.Desktop.Converters;
public class LevelToPaddingConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        int level = value == null ? 0 : (int)value;
        return new Thickness(level * 20, 0, 0, 0); // 20 pixels indent per level
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
