using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит информацию об адресе пользователя
    /// </summary>
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Почтовый индекс 6 цифр
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertIntValue(value, 100000, 999999, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Страна, до 50 символов
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Город, до 50 символов
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Улица, до 100 символов
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Номер дома, до 10 символов
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Номер квартиры или помещения, до 10 символов
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает объект объект класса адрес.
        /// </summary>
        /// <param name="index">Почтовый индекс 6 цифр</param>
        /// <param name="country">Страна, до 50 символов</param>
        /// <param name="city">Город, до 50 символов</param>
        /// <param name="street">Улица, до 100 символов</param>
        /// <param name="building">Номер дома, до 10 символов</param>
        /// <param name="apartment">Номер квартиры или помещения, до 10 символов</param>
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
        /// Создает объект объект класса адрес по умолчанию.
        /// </summary>
        public Address()
        {
            Index = 100001;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

    }
}
