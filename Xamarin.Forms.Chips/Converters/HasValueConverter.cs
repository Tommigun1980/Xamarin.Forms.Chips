using System;
using System.Globalization;
using System.ComponentModel;

namespace Xamarin.Forms.Chips.Converters
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class HasValueConverter : IValueConverter
    {
        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
