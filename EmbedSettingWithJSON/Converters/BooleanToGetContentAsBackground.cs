using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace EmbedSettingWithJSON.Converters
{
    class BooleanToGetContentAsBackground : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool b = false;
            string s = string.Empty;
            if (values[0] is bool && values[1] is string)
            {
                b = (bool)values[0];
                s = (string)values[1];
                if (b)
                    return new BrushConverter().ConvertFrom(s);
            }

            return Brushes.Transparent;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
