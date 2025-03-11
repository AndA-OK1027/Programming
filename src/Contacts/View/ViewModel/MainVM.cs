using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using View.ViewModel;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для работы
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Обработчик события.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        /// <param name="prop">Название свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        /// <summary>
        /// Внутренний объект контакта.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Команда сохранения.
        /// </summary>
        public SaveCommand SaveCommand { get; }

        /// <summary>
        /// Команда загрузки.
        /// </summary>
        public LoadCommand LoadCommand { get; }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }

            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged("Name");
                }
            }

        }

        /// <summary>
        /// Возвращает и задает номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }

            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }

        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }

            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged("Email");
                }
            }

        }

        /// <summary>
        /// Возвращает и задаёт объект контакта на обработке.
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged("Contact");
                    OnPropertyChanged("Name");
                    OnPropertyChanged("Email");
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }

        /// <summary>
        /// Конструктор ViewModel, в котором инициализируются команды взаимодействия.
        /// </summary>
        public MainVM()
        {
            ContactSerializer _serializer = new ContactSerializer();
            Contact = _serializer.Load();
            SaveCommand = new SaveCommand(_serializer, this);
            LoadCommand = new LoadCommand(_serializer, this);
        }
    }
}
