using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        private string _email;
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string error = String.Empty;

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
                if (_name != value) 
                {
                    
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
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
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
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
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Проверяет есть ли ошибка в свойстве.
        /// </summary>
        public bool HasError
        {
            get
            {
                return !string.IsNullOrEmpty(error);
            }
        }

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
                error = null;

                switch (propertyName)
                {
                    case "Name":
                        {
                            if (string.IsNullOrWhiteSpace(Name))
                            {
                                error = "Имя не может быть пустым.";
                            }
                            else if (Name.Length > 100)
                            {
                                error = "Имя не должно превышать 100 символов.";
                            }
                            break;
                        }
                    case "Email":
                        {
                            if (string.IsNullOrWhiteSpace(Email))
                            {
                                error = "Почта не может быть пустой.";
                            }
                            else if (Email.Length > 100)
                            {
                                error = "Почта не должна превышать 100 символов.";
                            }
                            else if (!Email.Contains("@"))
                            {
                                error = "Почта должна содержать символ \"@\".";
                            }
                            break;
                        }
                    case "PhoneNumber":
                        {
                            if (string.IsNullOrWhiteSpace(PhoneNumber))
                            {
                                error = "Почта не может быть пустой.";
                            }
                            else
                            {
                                if (!PhoneNumberRegex.IsMatch(PhoneNumber))
                                {
                                    error = "Номер телефона содержит недопустимые символы.";
                                }
                                else if (PhoneNumber.Length > 100)
                                {
                                    error = "Номер телефона не должен превышать 100 символов.";
                                }
                            }
                            break;
                        }
                }
                return error;
            }
        }

        /// <summary>
        /// Возвращает сообщение об ошибке для всего объекта.
        /// </summary>
        public string Error => null;

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызов события при изменении свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
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
