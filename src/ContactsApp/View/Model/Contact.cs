using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Обработка события при изменении свойства.
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
