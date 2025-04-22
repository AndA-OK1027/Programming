using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    /// <summary>
    /// Содержит методы преобразования типа Boolean в тип Visibility и обратно.
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Преобразует значение Boolean в Visibility
        /// </summary>
        /// <param name="value">Значение Boolean, которое нужно преобразовать.</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        /// <summary>
        /// Преобразует значение Visibility обратно в Boolean.
        /// </summary>
        /// <param name="value">Значение Visibility, которое нужно преобразовать.</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility visibilityValue) 
            {
                return visibilityValue == Visibility.Visible;
            }
            return false;
        }
    }
}
