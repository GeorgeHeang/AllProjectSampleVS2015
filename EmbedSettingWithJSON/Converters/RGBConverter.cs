using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace EmbedSettingWithJSON.Converters
{
    class RGBConverter : DependencyObject,IMultiValueConverter
    {


        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Status.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register("Status", typeof(string), typeof(RGBConverter), new PropertyMetadata(""));



        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color color=new Color();
            if (values[0] is string & values[1] is string & values[2] is string)
            {
                string r = (string)values[0];
                string g = (string)values[1];
                string b = (string)values[2];
                bool rp = byte.TryParse(r, out byte rpt);
                bool gp = byte.TryParse(g, out byte gpt);
                bool bp = byte.TryParse(b, out byte bpt);
                if (rp & gp & bp)
                {
                    color = (Color)Color.FromRgb(rpt,gpt,bpt);
                }
                else
                {
                    if(r.Length>0 && g.Length>0 && b.Length>0)
                    if (r.Length<=2 || g.Length<=2 || b.Length<=2)
                    {
                            try
                            {
                                color = (Color)ColorConverter.ConvertFromString($"#{r}{g}{b}");
                            }
                            catch (Exception)
                            {
                                return 0;
                            }
                    }
                }
                Status = string.Format("#{0}{1}{2}", color.R, color.G, color.B);
            }
            return new BrushConverter().ConvertFrom(color.ToString());
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
