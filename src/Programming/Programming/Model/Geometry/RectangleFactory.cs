using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о методах создания объектов класса прямоугольников.
    /// </summary>
    static class RectangleFactory
    {
        /// <summary>
        /// Создает объект класса прямоугольник со случайными параметрами, в заданном пользователем диапазоне.
        /// </summary>
        /// <param name="minWidth">Минимально допустимая ширина.</param>
        /// <param name="maxWidth">Максимально допустимая ширина.</param>
        /// <param name="minHeight">Минимально допустимая высота.</param>
        /// <param name="maxHeight">Максимально допустимая высота.</param>
        /// <param name="minX">Минимально допустимое значение координаты X.</param>
        /// <param name="maxX">Максимально допустимое значение координаты X.</param>
        /// <param name="minY">Минимально допустимое значение координаты Y.</param>
        /// <param name="maxY">Максимально допустимое значение координаты Y.</param>
        /// <returns>Возвращает объект прямоугольник</returns>
        public static Rectangle Randomize(int minWidth, int maxWidth, int minHeight, int maxHeight, int minX, int maxX, int minY, int maxY)
        {
            Random rand = new Random();
            Point2D center = new Point2D(rand.Next(minX, maxX), rand.Next(minY, maxY));
            Rectangle rectangle = new Rectangle(rand.Next(minHeight, maxHeight), rand.Next(minWidth, maxWidth), "color", center);
            return rectangle;
        }

        /// <summary>
        /// Создает объект класса прямоугольник со случайными параметрами в стандартном диапазоне.
        /// </summary>
        /// <returns>Возвращает объект прямоугольник</returns>
        public static Rectangle Randomize()
        {
            Random rand = new Random();
            Point2D center = new Point2D(rand.Next(1, 255), rand.Next(1, 255));
            Rectangle rectangle = new Rectangle(rand.Next(2, 100), rand.Next(2, 100), "color", center);
            return rectangle;
        }
    }
}
