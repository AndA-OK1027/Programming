using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string _error = string.Empty;

        /// <summary>
        /// Проверяет есть ли ошибка в свойстве.
        /// </summary>
        public bool HasError => !string.IsNullOrEmpty(_error);

        /// <summary>
        /// Возвращает ошибки для всего объекта.
        /// </summary>
        public string Error => _error;

        /// <summary>
        /// Регулярное выражение для маски ввода номера телефона.
        /// </summary>
        public static Regex PhoneNumberRegex = new Regex(@"^[0-9+() -]*$");

        /// <summary>
        /// Возвращает сообщение об ошибке у свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public string this[string propertyName]
        {
            get
            {
                _error = null;

                switch (propertyName)
                {
                    case "Name":
                        {
                            if (string.IsNullOrWhiteSpace(Name))
                            {
                                _error = "Имя не может быть пустым.";
                            }
                            else if (Name.Length > 100)
                            {
                                _error = "Имя не должно превышать 100 символов.";
                            }
                            break;
                        }
                    case "Email":
                        {
                            if (string.IsNullOrWhiteSpace(Email))
                            {
                                _error = "Почта не может быть пустой.";
                            }
                            else if (Email.Length > 100)
                            {
                                _error = "Почта не должна превышать 100 символов.";
                            }
                            else if (!Email.Contains("@"))
                            {
                                _error = "Почта должна содержать символ \"@\".";
                            }
                            break;
                        }
                    case "PhoneNumber":
                        {
                            if (string.IsNullOrWhiteSpace(PhoneNumber))
                            {
                                _error = "Почта не может быть пустой.";
                            }
                            else
                            {
                                if (!PhoneNumberRegex.IsMatch(PhoneNumber))
                                {
                                    _error = "Номер телефона содержит недопустимые символы.";
                                }
                                else if (PhoneNumber.Length > 100)
                                {
                                    _error = "Номер телефона не должен превышать 100 символов.";
                                }
                            }
                            break;
                        }
                }

                OnPropertyChanged();
                return _error;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = "no name";
            PhoneNumber = "+7 (999) 77 88";
            Email = "nomail@mail.com";
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="mail"> Почта. </param>
        /// <param name="name"> Имя.</param>
        /// <param name="number"> Номер телефона.</param>
        public Contact(string name, string number, string mail)
        {
            Name = name;
            PhoneNumber = number;
            Email = mail;
        }
    }
}
