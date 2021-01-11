using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication10
{
    public class convertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (bool)value;
            var data1 = (bool)value;
            if(data)
            {
                return Visibility.Visible;


            }
            else if(data1 )
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class changeborder : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (bool)value;

            if (data)
            {
                return new Thickness(0, 0, 0, 10);
            }

            else
            {
                return new Thickness(0, 0, 0, 0);
            }

        }      
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class foreground : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = (bool)value;
            if(data)
            {
                return new SolidColorBrush(Color.FromRgb(35, 213, 18));
            }
            else
            {
                return new SolidColorBrush(Color.FromRgb(35, 27, 18));
            }
          
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class textborder : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {

            var data = value as Choice;
            if(data!=null)
            {
                if(data.isNonperform)
                {
                    return  new SolidColorBrush(Colors.Red);
                }
                else if(data.issuspicious)
                {
                    return new SolidColorBrush(Colors.Plum);

                }
                else if(data.AnserCorrect)
                {
                    return new SolidColorBrush(Colors.Green);
                }
               
            }
            return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class borderthin : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value as Choice;
            if (data != null)
            {
                if (data.isNonperform)
                {
                    return new Thickness(5);
                }
                else if (data.issuspicious)
                {
                    return new Thickness(5);

                }
                else if (data.AnserCorrect)
                {
                    return new Thickness(5);
                }

            }
            return new Thickness(1);
        
    }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
