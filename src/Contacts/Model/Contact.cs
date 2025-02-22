using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    class Contact
    {
        private string _name;

        private string _mail;

        private string _phoneNumber;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get;

            set;
        }

        /// <summary>
        /// Почта контакта.
        /// </summary>
        public string Mail
        {
            get;

            set;
        }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get;

            set;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = " ";
            PhoneNumber = "+7 (999) 77 88";
            Mail = "aaaaaaaa@mail.a";
        }

        /// <summary>
        /// 
        /// </summary>
        public Contact(string name, string number, string mail)
        {
            Name = name;
            PhoneNumber = number;
            Mail = mail;
        }
    }
}
