namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит информацию о товарах и покупателях.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список всех покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список всех товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задает список покупателей. Не должно быть null.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (_customers == null)
                {
                    throw new ArgumentException($"{nameof(Customers)} не должно быть null.");
                }
                _customers = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров. Не должно быть null.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (_items == null)
                {
                    throw new ArgumentException($"{nameof(Items)} не должно быть null.");
                }
                _items = value;
            }
        }

        /// <summary>
        /// Создает списки классов <see cref="Item"/> и <see cref="Customer"/>.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
