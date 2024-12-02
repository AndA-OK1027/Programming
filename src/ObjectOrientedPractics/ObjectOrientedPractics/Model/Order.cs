namespace ObjectOrientedPractics
{
    /// <summary>
    /// Содержит информацию о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Время создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Адрес, куда должен быть доставлен заказ.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Цена заказа.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Статус готовности заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Возвращает и задает статус готовности заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает и задает id заказа.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime Date { get { return _date; } }

        /// <summary>
        /// Возвращает и задает адрес, куда должен быть доставлен заказ.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задает список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задает стоимость заказа.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="address">Адрес заказа.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="cost">Цена заказа.</param>
        public Order(Address address, List<Item> items, double cost)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items;
            Cost = cost;
            Status = OrderStatus.New;
        }
    }
}
