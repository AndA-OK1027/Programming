using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о точке в прямоугольной системе координат.
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Координата Y.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Осуществляет проверку координаты X на допустимые значения.
        /// </summary>
        /// <param name="x"></param>
        private void SetX(int x)
        {
            Validator.AssertValueInRange(x, -255, 255, nameof(X));
            X = x;
        }

        /// <summary>
        /// Осуществляет проверку координаты Y на допустимые значения.
        /// </summary>
        /// <param name="y"></param>
        private void SetY(int y)
        {
            Validator.AssertValueInRange(y, -255, 255, nameof(Y));
            Y = y;
        }

        /// <summary>
        /// Создает объект класса <see cref="Point2D">.
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public Point2D(int x, int y)
        {
            SetX(x);
            SetY(y);
        }
    }
}
