using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        private string name;

        private string surName;

        /// <summary>
        /// Имя, может состоять только из букв
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                name = value;
            }
        }

        /// <summary>
        /// Фамилия, может состоять только из букв
        /// </summary>
        public string Surname
        {
            get { return surName; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                surName = value; 
            }
        }

        /// <summary>
        /// Номер, может состоять только из цифр
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set 
            {
                AssertStringContainsOnlyNumbers(value, nameof(PhoneNumber));
                phoneNumber = value;
            }

        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя, может состоять только из букв</param>
        /// <param name="surName">Фамилия, может состоять только из букв</param>
        /// <param name="phoneNumber">Номер телефона. Должен состоять только из цифр.</param>
        public Contact(string surName, string name, string phoneNumber)
        {
            Name = name;
            Surname = surName;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/> без параметров.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Проверяет, стостоит ли строка только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <returns>Возвращает true, если строка состоит из букв.
        ///И false, если есть хотя бы одна не буква.</returns>
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contain letters only");
                }
            }
        }

        /// <summary>
        /// Проверяет, стостоит ли строка только из цифр.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        private void AssertStringContainsOnlyNumbers(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contain numbers only");
                }
            }
        }
    }
}
