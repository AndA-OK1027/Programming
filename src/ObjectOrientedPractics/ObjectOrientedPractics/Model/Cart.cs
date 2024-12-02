namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит информацию о корзине товаров.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Возвращает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (value == null) return;
                _items = value;
            }
        }

        /// <summary>
        /// Считает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double totalCost = 0.0;

                if (_items == null || _items.Count == 0)
                {
                    return totalCost;
                }

                foreach (var item in _items)
                {
                    totalCost += item.Cost;
                }
                return totalCost;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }

        /// <summary>
        /// Очищает список товаров.
        /// </summary>
        public void Clear()
        {
            _items = new List<Item>();
        }
    }
}
