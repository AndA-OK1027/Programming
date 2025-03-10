using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        private string _name;

        private string _email;

        private string _phoneNumber;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Почта контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = " ";
            PhoneNumber = "+7 (999) 77 88";
            Email = "aaaaaaaa@mail.a";
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Contact(string name, string number, string mail)
        {
            Name = name;
            PhoneNumber = number;
            Email = mail;
        }
    }
}
