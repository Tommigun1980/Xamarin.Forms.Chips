using System;
using System.Globalization;
using System.ComponentModel;

namespace Xamarin.Forms.Chips.Converters
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class HasValueConverter : IValueConverter
    {
        public bool EmptyStringIsNull { get; set; } = true;

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (this.EmptyStringIsNull)
            {
                var stringValue = value as string;
                if (stringValue != null)
                    return stringValue != string.Empty;
            }

            return value != null;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
