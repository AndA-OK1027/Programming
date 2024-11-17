using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Xранит информацию о методаx валидации данныx
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки и выбросывает исключение при несовпадение.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Максимальная длина</param>
        /// <param name="propertyName">Название свойства</param>
        public static void AssertStringLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength || value.Length < 0)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength} symbols. ");
            }
        }

        /// <summary>
        /// Проверяет значение вещественного числа и выбросывает исключение при недопустимом.
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <param name="min">Минимальная граница</param>
        /// <param name="max">Максимальная граница</param>
        /// <param name="propertyName">Название свойства</param>
        public static void AssertDoubleValue(double value, double min, double max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{propertyName} out of range.");
            }
        }

        /// <summary>
        /// Проверяет значение вещественного числа и выбросывает исключение при недопустимом.
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <param name="min">Минимальная граница</param>
        /// <param name="max">Максимальная граница</param>
        /// <param name="propertyName">Название свойства</param>
        public static void AssertIntValue(int value, int min, int max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{propertyName} out of range.");
            }
        }
    }
}
