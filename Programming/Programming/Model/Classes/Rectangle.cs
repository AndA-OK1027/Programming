using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Класс прямогугольник определенного цвета (строка) и вещественной длины и ширины
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Длина.
        /// </summary>
        private double length;
        /// <summary>
        /// Ширина
        /// </summary>
        private double width;

        /// <summary>
        /// Возвращает и задает длину прямоугольника.
        /// </summary>
        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Длина должна быть больше нуля");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямогугольника.
        /// </summary>
        public double Width
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
                    throw new ArgumentException("Ширина должна быть больше нуля");
                }
            }
        }
        
        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">Длина. Только положительные вещественные числа.</param>
        /// <param name="width">Ширина. Только положительные вещественные числа.</param>
        /// <param name="color">Цвет в виде строки.</param>
        public Rectangle(double length, double width, string color)
        {
            Color = color;
            Length = length;
            Width = width;
        }

        public Rectangle() { }
    }
}
