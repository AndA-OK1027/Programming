using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Xранит информацию о покупателе.
    /// </summary>
    public class Customer
    {
        private static int usersCount = 0;
        private readonly int _id;
        private string _fullname;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает Название товара.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Название товара.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Создает объект класса Пользователь.
        /// </summary>
        /// <param name="fullname">Полное имя пользователя, до 200 символов.</param>
        /// <param name="address">Адрес доставки, до 500 символов.</param>
        public Customer(string fullname, Address address)
        {
            ++usersCount;
            Fullname = fullname;
            Address = address;
            _id = usersCount;
        }

        public Customer() 
        {
            Fullname = " ";
            Address = new Address();
        }

    }
}
