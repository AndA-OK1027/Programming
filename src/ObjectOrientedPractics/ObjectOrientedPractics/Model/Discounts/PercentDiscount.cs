using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о процентах на скидку.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Скидка в процентах.
        /// </summary>
        private double _percent;

        /// <summary>
        /// Количество денег потраченных покупателем на товары одной категории.
        /// </summary>
        private double _categoryAmount;

        /// <summary>
        /// Возвращает и задает скидку в процентах на заказ.
        /// </summary>
        public double Percent
        {
            get { return _percent; }
            private set
            {
                if (value > 10 || value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(Percent) + "должна быть от 1% до 10%.");
                }
                _percent = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает потраченную сумму денег покупателем на товары одной категории.
        /// </summary>
        public double CategoryAmount
        {
            get { return _categoryAmount; }
            set { _categoryAmount = value; }
        }

        /// <summary>
        /// Возвращает описание скидки на категорию товаров.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {Percent}%";
            }
        }

        /// <summary>
        /// Высчитывает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double categoryCost = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                    categoryCost += item.Cost;
            }
            double discountAmount = categoryCost * (Percent / 100);
            return discountAmount;
        }

        /// <summary>
        /// Применяет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Percent = 1;
            CategoryAmount = 0;
            return discount;
        }

        /// <summary>
        /// Вычисляет процент скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == Category)
                    CategoryAmount += item.Cost;
            }

            if (CategoryAmount / 1000 > 10)
            {
                Percent = 10;
            }

            else
            {
                if ((int)CategoryAmount / 1000 == 0)
                {
                    Percent = 1;
                }
                else
                {
                    Percent = (int)CategoryAmount / 1000;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория.</param>
        public PercentDiscount(Category category)
        {
            Percent = 1;
            Category = category;
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
