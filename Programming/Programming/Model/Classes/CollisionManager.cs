using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class CollisionManager
    {
        bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double dWidth = Math.Abs(rectangle1.Width - rectangle2.Width);
            double dLength = Math.Abs(rectangle1.Length - rectangle2.Length);

            if ((dX < (dWidth / 2)) && (dY < (dLength / 2)))
            {
                return true;
            }
            else return false;

        }

        bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            if (c < ring1.OuterRadius + ring2.OuterRadius)
            {
                return true;
            }
            else return false;
        }
    }
}
