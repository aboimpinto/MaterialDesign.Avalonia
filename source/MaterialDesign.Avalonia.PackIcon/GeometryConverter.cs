using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace MaterialDesign.Avalonia.PackIcon
{
    public class GeometryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Geometry.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}