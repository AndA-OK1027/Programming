
namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о скидочных балах.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает количество баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Points) + "дожен быть положительным.");
                }
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает описание количества накопительных балов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {Points} баллов";
            }
        }

        /// <summary>
        /// Вычисляет размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = 0;

            foreach (Item item in items)
            {
                totalCost += item.Cost;
            }

            double maxDiscount = totalCost * 0.3;

            if (Points > maxDiscount) { return maxDiscount; }
            return Points;
        }

        /// <summary>
        /// Применяет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            if (Points - discount < 0)
            {
                Points = 0;
            }
            else
            {
                Points = (int)(Points - discount);
            }

            return discount;
        }

        /// <summary>
        /// Вычисляет баллы скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double totalCost = 0;
            foreach (Item item in items)
            {
                totalCost += item.Cost;
            }  
            int result = (int)Math.Ceiling(totalCost * 0.1);
            Points += result;
        }

        /// <summary>
        /// Переопределяет метод <see cref="ToString()"/>.
        /// </summary>
        /// <returns>Возвращает <see cref="Info"/>.</returns>
        public override string ToString()
        {
            return Info;
        }
    }
}
