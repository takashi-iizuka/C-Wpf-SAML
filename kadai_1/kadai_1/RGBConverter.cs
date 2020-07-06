using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace kadai_1
{
    public class RGBConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return Color.FromRgb((byte)(double)(values[0]), (byte)(double)(values[1]), (byte)(double)(values[2]));
            }
            catch (InvalidCastException ic)
            {
                return Color.FromRgb((byte)(double)(0), (byte)(double)(0), (byte)(double)(0));
          }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
