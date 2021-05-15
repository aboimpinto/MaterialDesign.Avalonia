using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace MaterialDesign.Avalonia.PackIcon
{
    public class GeometryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                var dataIndex = new Dictionary<PackIconKind, string>(PackIconDataFactory.Create());
                string? data = null;
                dataIndex.TryGetValue(PackIconKind.None, out data);
                return Geometry.Parse(data);
            }

            return Geometry.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}