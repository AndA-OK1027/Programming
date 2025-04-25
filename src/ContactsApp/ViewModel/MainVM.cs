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
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsApplyButtonVisible))]
        [NotifyPropertyChangedFor(nameof(IsReadOnly))]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private bool _isEditing = false;

        /// <summary>
        /// Флаг, указывающий на добавление в данный момент нового контакта.
        /// </summary>
        private bool _isAddingNew;

        /// <summary>
        /// Устанавливает режим "только для чтения" для редактирования контакта.
        /// </summary>
        public bool IsReadOnly => !IsEditing;

        /// <summary>
        /// Возвращает видимость кнопки "Apply" при необходимости.
        /// </summary>
        public bool IsApplyButtonVisible => IsEditing;

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
                    if (_selectedContact != null)
                    {
                        _selectedContact.PropertyChanged -= OnSelectedContactPropertyChanged;
                    }

                    IsEditing = false;

                    _selectedContact = value;
                    if (_selectedContact != null)
                    {
                        _selectedContact.PropertyChanged += OnSelectedContactPropertyChanged;
                    }

                    OnPropertyChanged(nameof(SelectedContact));
                    RemoveContactCommand.NotifyCanExecuteChanged();
                    EditContactCommand.NotifyCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Событие при изменении выбранного контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedContactPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            ApplyCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Возвращает возможность редактирования и удаления для комманд.
        /// </summary>
        /// <returns>True, если возможно редактирование и удаление, иначе false.</returns>
        public bool CanEditOrRemoveContact()
        {
            return SelectedContact != null;
        }

        /// <summary>
        /// Добавляет контакт в список.
        /// </summary>
        [RelayCommand]
        private void AddContact()
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
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        private void EditContact()
        {
            if (SelectedContact != null)
            {
                _selectedIndex = Contacts.IndexOf(SelectedContact);

                var _clonedContact = new Contact
                {
                    Name = SelectedContact.Name,
                    PhoneNumber = SelectedContact.PhoneNumber,
                    Email = SelectedContact.Email
                };

                SelectedContact = _clonedContact;
            }
            IsEditing = true;
            RemoveContactCommand.NotifyCanExecuteChanged();
            ApplyCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Удаляет контакт из списка, выбранный или последний.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        private void RemoveContact()
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
        [RelayCommand(CanExecute = nameof(CanApply))]
        private void Apply()
        {
            if (_isAddingNew)
            {
                Contacts.Add(SelectedContact);
            }
            else if (IsEditing)
            {
                Contacts[_selectedIndex] = SelectedContact;

                IsEditing = false;
            }

            _isAddingNew = false;
            IsEditing = false;

            _serializer.Save(Contacts);
        }

        /// <summary>
        /// Проверка валидности всех полей.
        /// </summary>
        /// <returns>True, если возможно сохранение изменений, иначе false.</returns>
        public bool CanApply()
        {
            return SelectedContact != null && !SelectedContact.HasError;
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
