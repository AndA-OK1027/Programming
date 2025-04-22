using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using Model;
using Model.Services;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для работы
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Коллекция объектов контактов.
        /// </summary>
        [ObservableProperty]
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
        /// Устанавливает режим "только для чтения" для редактирования контакта.
        /// </summary>
        public bool IsReadOnly => !_isEditing;

        /// <summary>
        /// Возвращает видимость кнопки "Apply" при необходимости.
        /// </summary>
        public Visibility ApplyButtonVisibility => _isEditing ? Visibility.Visible : Visibility.Collapsed;

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
                    _isEditing = false;

                    _selectedContact = value;
                    OnPropertyChanged(nameof(SelectedContact));
                }
            }
        }

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
        /// Добавляет контакт в список.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand]
        public void AddContact(object parameter)
        {
            _isAddingNew = true;
            SelectedContact = null;
            var newContact = new Contact();
            SelectedContact = newContact;
            _isEditing = true;
        }

        /// <summary>
        /// Открывает режим редактирования контакта.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        public void EditContact(object parameter)
        {
            if (SelectedContact != null)
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
            _isEditing = true;
        }

        /// <summary>
        /// Удаляет контакт из списка, выбранный или последний.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
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
        [RelayCommand(CanExecute = nameof(CanApply))]
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
        }
    }
}
