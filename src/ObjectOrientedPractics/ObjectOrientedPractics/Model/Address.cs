namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит информацию об адрессе покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает Почтовый индекс. Должно быть целым шестизначным числом.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.CheckNumberInRange(value, 100000, 999999, nameof(Index));
                ValueValidator.CheckNumberOnLetter(value, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Страну/регион. Не должно превышать 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                ValueValidator.CheckWordOnDigit(value, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Город (населенный пункт). Не должно превышать 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                ValueValidator.CheckWordOnDigit(value, nameof(Country));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Улицу. Не должно превышать 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Номер дома. Не должно превышать 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Номер квартиры/помещения. Не должно превышать 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "Russia";
            City = "Tomsk";
            Street = "Lenina";
            Building = "59";
            Apartment = "3";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна/регион.</param>
        /// <param name="city">Город (населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Переопределяет метод <see cref="ToString()"/>.
        /// </summary>
        /// <returns>Возвращает <see cref="Name"/>.</returns>
        public override string ToString()
        {
            return $"{Index} {Country} {City} {Street} {Building} {Apartment}";
        }
    }
}
