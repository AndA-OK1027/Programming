using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о контакте в телефонной книге: номер, имя и фамилию
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Телефонный номер.
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set 
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) || value.Length == 11)
                    {
                        phoneNumber = value;
                    }
                    else
                    {
                        throw new ArgumentException("Ввод номера некорректный");
                    }
                }
            }

        }
        /// <summary>
        /// Создает экземпляр класса Контакт
        /// </summary>
        /// <param name="firstName">Имя ...</param>
        /// <param name="lastName">Фамилия ...</param>
        /// <param name="phoneNumber">Номер телефона. Должен состоять только из цифр и быть длиной 11 символов.</param>
        public Contact(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public Contact() { }
    }
}
