using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApplication10
{
   
    public class color : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var data = value as Choice;
            BitmapImage Cor = new BitmapImage();
            Cor.BeginInit();
            Cor.UriSource = new Uri("Check.png", UriKind.Relative);
            Cor.EndInit();

            BitmapImage ron = new BitmapImage();
            ron.BeginInit();
            ron.UriSource = new Uri("Wrong.png", UriKind.Relative);
            ron.EndInit();
            if (data != null)
            {
                if (data.AnserCorrect)
                {
                    return Cor;

                }
                else
                {
                    return ron;
                }


            }
            return ron;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
