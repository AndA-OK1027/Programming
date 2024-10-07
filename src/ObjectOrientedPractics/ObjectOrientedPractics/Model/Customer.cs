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
    class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

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
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создает объект класса Пользователь.
        /// </summary>
        /// <param name="fullname">Полное имя пользователя, до 200 символов.</param>
        /// <param name="address">Адрес доставки, до 500 символов.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IDGenerator.GetNextID();
        }
    }
}
