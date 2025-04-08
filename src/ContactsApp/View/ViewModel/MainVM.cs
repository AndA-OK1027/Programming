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
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для работы
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Коллекция объектов контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts;
        /// <summary>
        /// Выбранный объект в списке.
        /// </summary>
        private Contact _selectedContact;
        /// <summary>
        /// Выбранный индекс в списке.
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// Объект служебного класса <see cref="ContactSerializer"/>, для сохранения и загрузки объектов.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer();

        /// <summary>
        /// Флаг, указывающий на редактирование  в данный момент контакта.
        /// </summary>
        private bool _isEditing = false;
        /// <summary>
        /// Флаг, указывающий на добавление в данный момент нового контакта.
        /// </summary>
        private bool _isAddingNew;

        /// <summary>
        /// Событие при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Получает или задаёт значение, указывающее, находится ли приложение в режиме редактирования.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                _isEditing = value;
                OnPropertyChanged(nameof(IsEditing));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(ApplyButtonVisibility));
            }
        }

        /// <summary>
        /// Устанавливает режим "только для чтения" для редактирования контакта.
        /// </summary>
        public bool IsReadOnly => !IsEditing;

        /// <summary>
        /// Возвращает видимость кнопки "Apply" при необходимости.
        /// </summary>
        public Visibility ApplyButtonVisibility => _isEditing ? Visibility.Visible : Visibility.Collapsed;

        /// <summary>
        /// Получает или задает коллекцию объектов класса "Contact".
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contacts));
            }
        }

        /// <summary>
        /// Получает или задаёт выбранный контакт из списка.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact != value)
                {
                    IsEditing = false;

                    _selectedContact = value;
                    OnPropertyChanged(nameof(SelectedContact));
                }
            }
        }

        /// <summary>
        /// Получает команду для добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Получает команду для редактирования существующего контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Получает команду для удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Получает команду для применения изменений к контакту.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает возможность редактирования и удаления для комманд.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>True, если возможно редактирование и удаление, иначе false.</returns>
        public bool CanEditOrRemoveContact(object parameter)
        {
            return SelectedContact != null;
        }

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
        /// Добавляет контакт в список.
        /// </summary>
        /// <param name="parameter"></param>
        public void AddContact(object parameter)
        {
            _isAddingNew = true;
            SelectedContact = null;
            var newContact = new Contact();
            SelectedContact = newContact;
            IsEditing = true;
        }

        /// <summary>
        /// Открывает режим редактирования контакта.
        /// </summary>
        /// <param name="parameter"></param>
        public void EditContact(object parameter)
        {
            if(SelectedContact != null)
            {
                var _selectedIndex = Contacts.IndexOf(SelectedContact);

                var _clonedContact = new Contact
                {
                    Name = SelectedContact.Name,
                    PhoneNumber = SelectedContact.PhoneNumber,
                    Email = SelectedContact.Email
                };

                SelectedContact = _clonedContact;
            }
            IsEditing = true;
        }

        /// <summary>
        /// Удаляет контакт из списка, выбранный или последний.
        /// </summary>
        /// <param name="parameter"></param>
        public void RemoveContact(object parameter)
        {
            if (SelectedContact != null)
            {
                int index = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);
                _serializer.Save(Contacts);

                if (Contacts.Count > 0)
                {
                    if (index < Contacts.Count)
                    {
                        SelectedContact = Contacts[index];
                    }

                    else
                    {
                        SelectedContact = Contacts[Contacts.Count - 1];
                    }
                }

                else
                {
                    SelectedContact = null;
                }
            }
        }

        /// <summary>
        /// Сохраняет изменения в объекте контакта.
        /// </summary>
        /// <param name="parameter"></param>
        public void Apply(object parameter)
        {
            if (_isAddingNew)
            {
                Contacts.Add(SelectedContact);
            }
            else
            {
                Contacts[_selectedIndex] = SelectedContact;

                _isEditing = false;
            }

            _isAddingNew = false;
            _isEditing = false;

            _serializer.Save(Contacts);
        }

        /// <summary>
        /// Проверка валидности всех полей.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public bool CanApply(object parameter)
        {
            return SelectedContact != null && SelectedContact.HasError == false;
        }

        /// <summary>
        /// Конструктор ViewModel, в котором инициализируются команды взаимодействия.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>(_serializer.Load());

            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanEditOrRemoveContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanEditOrRemoveContact);
            ApplyCommand = new RelayCommand(Apply, CanApply);
        }
    }
}
