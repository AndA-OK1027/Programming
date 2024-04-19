using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Ring
    {
        private Point2D center;
        private double innerRadius;
        private double outerRadius;

        public Point2D Center { get; }

        public double InnerRadius
        {
            get { return innerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (value >= outerRadius)
                {
                    throw new ArgumentException("Неправильное значение внутреннего радиуса");
                }
                innerRadius = value;
            }
        }

        public double OuterRadius
        {
            get { return outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (value <= innerRadius)
                {
                    throw new ArgumentException("Неправильное значение внешнего радиуса");
                }
                outerRadius = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * outerRadius * outerRadius - Math.PI * innerRadius * innerRadius;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="center"></param>
        /// <param name="innerRadius"></param>
        /// <param name="outerRadius"></param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            this.center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        public Ring() { }
    }
}
