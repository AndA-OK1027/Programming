using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о методах проверки пересечения геометрических объектов.
    /// </summary>
    class CollisionManager
    {
        /// <summary>
        /// Возвращает true, если два прямоуголька пересекаются, false - если нет. 
        /// </summary>
        /// <param name="rectangle1">Первый прямогольник.</param>
        /// <param name="rectangle2">Второй прямогольник.</param>
        /// <returns></returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            int dWidth = Math.Abs(rectangle1.Width + rectangle2.Width);
            int dHeight = Math.Abs(rectangle1.Height + rectangle2.Height);

            if ((dX < (dWidth / 2)) && (dY < (dHeight / 2)))
            {
                return true;
            }
            return false;
            
        }

        /// <summary>
        /// Возвращает true, если два кольца пересекаются, false - если нет. 
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns></returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            if (c < ring1.OuterRadius + ring2.OuterRadius)
            {
                return true;
            }
            return false;
        }
    }
}
