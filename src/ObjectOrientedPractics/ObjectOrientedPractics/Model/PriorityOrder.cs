namespace ObjectOrientedPractics
{
    /// <summary>
    /// Класс хранит информацию об приоритетном заказе.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Хранит список диапазонов времени прибытия заказа.
        /// </summary>
        private static List<string> _deliveryTimeRange = new List<string>
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };
        
        /// <summary>
        /// Хрант дату прибытия заказа.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Хранит время прибытия заказа.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Возвращает и задает список диапазонов времени прибытия заказа.
        /// </summary>
        public static List<string> DeliveryTimeRange { get { return _deliveryTimeRange; } }

        /// <summary>
        /// Возвращает и задает дату прибытия заказа.
        /// </summary>
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException($"{nameof(DeliveryDate)} должно быть больше либо равно нынешней дате.");
                }

                _deliveryDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время прибытия заказа.
        /// </summary>
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set
            {
                if (!_deliveryTimeRange.Contains(value))
                {
                    throw new ArgumentException($"{nameof(DeliveryTime)} не принадлежит заданным дапазонам.");
                }
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now.AddDays(1);
            DeliveryTime = _deliveryTimeRange[0];
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="deliveryDate">Дата прибытия заказа.</param>
        /// <param name="deliveryTime">Время прибытия заказа.</param>
        /// <param name="address">Адрес покупателя.</param>
        /// <param name="items">Товары в заказе.</param>
        /// <param name="cost">Цена заказа.</param>
        public PriorityOrder(DateTime deliveryDate, string deliveryTime, Address address, List<Item> items, double cost) : base(address, items, cost)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
