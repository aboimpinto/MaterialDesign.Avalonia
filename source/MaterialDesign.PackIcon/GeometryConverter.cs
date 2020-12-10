using System;
using System.Globalization;
using Avalonia.Controls.Shapes;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace MaterialDesign.PackIcon
{
    public class GeometryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = value as Path;

            if (path == null)
            {
                throw new InvalidOperationException();
            }

            var pathData = path.Data as PathGeometry;
            if (pathData == null)
            {
                throw new InvalidOperationException();
            }

            return pathData.Figures;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}