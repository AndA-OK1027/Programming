using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Хранит информацию о методах валидации данных.
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Проверяет, является ли целочисленное значение положительным числом.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Название свойства, в котором осуществляется проверка.</param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{ propertyName } must be a positive value.");
            }
        }

        /// <summary>
        /// Проверяет, является ли вещественное значение положительным числом.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Название свойства, в котором осуществляется проверка.</param>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{ propertyName } must be a positive value.");
            }
        }

        /// <summary>
        /// Проверяет, находится ли целочисленное значение в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальная граница.</param>
        /// <param name="max">Максимальная граница.</param>
        /// <param name="propertyName">Название свойства, в котором осуществляется проверка.</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{ propertyName } out of range.");
            }
        }

        /// <summary>
        /// Проверяет, находится ли вещественное значение в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальная граница.</param>
        /// <param name="max">Максимальная граница.</param>
        /// <param name="propertyName">Название свойства, в котором осуществляется проверка.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{ propertyName } out of range.");
            }
        }

        public static void AssertStringLength(string value, int min, int max, string propertyName)
        {
            if (value.Length > max || value.Length < min)
            {
                throw new ArgumentException($"{ propertyName } length is unacceptable.");
            }
        }
    }
}
