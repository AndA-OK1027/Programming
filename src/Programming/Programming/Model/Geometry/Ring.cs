using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о кольце в прямоугольной системе координат. 
    /// </summary>
    class Ring
    {
        private Point2D center;
        private double innerRadius;
        private double outerRadius;

        /// <summary>
        /// Возвращает координаты центра кольца типа <see cref="Point2D">.
        /// </summary>
        public Point2D Center { get; }

        /// <summary>
        /// Возвращает и задает значение внутреннего радиуса, только положительные вещественные числа.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает значение внешнего радиуса, только положительные вещественные числа.
        /// </summary>
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
        /// Вычисляет и возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * outerRadius * outerRadius - Math.PI * innerRadius * innerRadius;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Ring">.
        /// </summary>
        /// <param name="center">Координаты центра типа <see cref="Point2D">.</param>
        /// <param name="innerRadius">Вещественное значение внутреннего радиуса.</param>
        /// <param name="outerRadius">Вещественное значение внешнего радиуса.</param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            this.center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        /// <summary>
        /// Создает объект класса <see cref="Ring">, без параметров.
        /// </summary>
        public Ring() { }
    }
}
