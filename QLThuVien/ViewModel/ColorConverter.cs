using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace QLThuVien.ViewModel
{
    
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool error = (bool)value;
            Brush e;
            if (error)
            {
                e = Brushes.Red;
            }
            else
                e = Brushes.Black;
            return e;

        
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool error = (bool)value;
            Brush e;
            if (error)
            {
                e = Brushes.Red;
            }
            else
                e = Brushes.Black;
            return e;
        }
    }
}
