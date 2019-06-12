using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace QLThuVien.ViewModel
{

    public class MVCBackground : IMultiValueConverter
    {
        public object Convert(object[] values ,
            Type targetType ,
            object parameter , 
            CultureInfo culture )
        {
            throw new NotImplementedException();
            Brush unError = Brushes.Black;
            Brush error = Brushes.Red;

           
          
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


}
