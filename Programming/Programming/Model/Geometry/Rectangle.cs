using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Класс прямогугольник определенного цвета (строка) и вещественной длины и ширины.
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Длина.
        /// </summary>
        private int height;
        /// <summary>
        /// Ширина.
        /// </summary>
        private int width;

        /// <summary>
        /// Статическое поле, подчитывающее все существующие прямоугольники.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        ///  Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Возвращает и задает длину прямоугольника.
        /// </summary>
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Expects a positive value.");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямогугольника.
        /// </summary>
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Expects a positive value.");
                }
            }
        }
        
        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает координаты x и y центра прямоугльника.
        /// </summary>
        public Point2D Center { get; }

        /// <summary>
        /// Возвращает количество всех прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount;}
        }

        /// <summary>
        /// Возвращает id прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle">.
        /// </summary>
        /// <param name="height">Длина. Только положительные вещественные числа.</param>
        /// <param name="width">Ширина. Только положительные вещественные числа.</param>
        /// <param name="color">Цвет в виде строки.</param>
        /// <param name="center">Координаты центра типа точки в двумерном пространстве.</param>
        public Rectangle(int height, int width, string color, Point2D center)
        {
            Color = color;
            Height = height;
            Width = width;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle">, без параметров.
        /// </summary>
        public Rectangle() { }
    }
}
