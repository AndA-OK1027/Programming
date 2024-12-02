using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
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
        /// Задает и возвраает сумму скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Задает и возвращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return Cost - DiscountAmount;
            }
        }

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
            get
            {
                _cost = 0;
                foreach (Item item in _items)
                {
                    _cost += item.Cost;
                }
                return _cost;
            }
            private set { _cost = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = new Address();
            Items = new List<Item>();
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес заказа.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="cost">Цена заказа.</param>
        public Order(Address address, List<Item> items, double discountAmount)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items;
            DiscountAmount = discountAmount;
            Status = OrderStatus.New;
        }
    }
}
