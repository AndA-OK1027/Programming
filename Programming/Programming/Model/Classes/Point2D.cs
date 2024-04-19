using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// 
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// 
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        private void SetX(int x)
        {
            Validator.AssertValueInRange(x, -255, 255, nameof(X));
            X = x;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        private void SetY(int y)
        {
            Validator.AssertValueInRange(y, -255, 255, nameof(Y));
            Y = y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2D(int x, int y)
        {
            SetX(x);
            SetY(y);
        }
    }
}
