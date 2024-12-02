namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Заказ покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает значение поля id.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Определяет, является ли покупатель приоритетным.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        ///  Возвращает и задает ФИО покупателя. Не должно быть больше 200 символов или пустым.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                ValueValidator.CheckWordOnDigit(value, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            private set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задает заказ покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            FullName = "FullName";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">ФИО покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Переопределяет метод <see cref="ToString()"/>.
        /// </summary>
        /// <returns>Возвращает <see cref="FullName"/>.</returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
