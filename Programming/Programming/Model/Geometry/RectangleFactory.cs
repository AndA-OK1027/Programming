using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о методе 
    /// </summary>
    static class RectangleFactory
    {

        public static Rectangle Randomize(int minWidth, int maxWidth, int minHeight, int maxHeight, int minX, int maxX, int minY, int maxY)
        {
            Random rand = new Random();
            Point2D center = new Point2D(rand.Next(minX, maxX), rand.Next(minY, maxY));
            Rectangle rectangle = new Rectangle(rand.Next(minHeight, maxHeight), rand.Next(minWidth, maxWidth), "color", center);
            return rectangle;
        }

        public static Rectangle Randomize()
        {
            Random rand = new Random();
            Point2D center = new Point2D(rand.Next(1, 255), rand.Next(1, 255));
            Rectangle rectangle = new Rectangle(rand.Next(2, 100), rand.Next(2, 100), "color", center);
            return rectangle;
        }
    }
}
