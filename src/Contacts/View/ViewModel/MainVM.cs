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
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null) 
            { 
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        private Contact _contact;

        /// <summary>
        /// 
        /// </summary>
        public SaveCommand SaveCommand { get; }

        /// <summary>
        /// 
        /// </summary>
        public LoadCommand LoadCommand { get; }

        /// <summary>
        /// Свойство для работы с именем контакта.
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
        /// Свойство для работы с номером контакта.
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
        /// Свойство для работы с почтой контакта.
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
        /// 
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
        /// 
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
