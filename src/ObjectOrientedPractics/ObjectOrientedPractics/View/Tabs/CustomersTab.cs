﻿using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// True, если данные в полях корректны, иначе false.
        /// </summary>
        bool _isDataValid = true;

        /// <summary>
        /// Список, хранящий всех покупателей и информацию о них.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список класса <see cref="Customer"/>.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(Customers)} не должно быть null.");
                }
                _customers = value;
            }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При запуске приложения загружает в ListBox <see cref="CustomersListBox"/> список типа <see cref="Customer"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersTab_Load(object sender, EventArgs e)
        {
            CustomersListBox.DataSource = _customers;
        }

        /// <summary>
        /// Добавляет в список экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            _customers.Add(customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = _customers.Count - 1;

            ValueValidator.CheckDataForClear(_customers, SelectedCustomerPanel, DeliveryAddressPanel);
        }

        /// <summary>
        /// Удаляет из списка экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = _customers.Count - 1;

            ValueValidator.CheckDataForClear(_customers, SelectedCustomerPanel, DeliveryAddressPanel);
        }

        /// <summary>
        /// Меняет отображение списка при добавлении/удалении элемента. Также загружает в Textboxes данные из полей текущего элемента списка.
        /// Если данные некорректны, невозможно покинуть текущий элемент списка, пока данные не станут корректными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;

            if (!_isDataValid || !CustomerAddressControl.CheckIfAddressDataValid())
            {
                CustomersListBox.SelectedItem = _currentCustomer;
                return;
            }

            _currentCustomer = CustomersListBox.SelectedItem as Customer;
            CustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            CustomerFullNameTextBox.Text = _currentCustomer.FullName.ToString();

            CustomerAddressControl.Address = _currentCustomer.Address;
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;

            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        /// <summary>
        /// Меняет состояние свойства FullName через валидацию вводимых данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _isDataValid = true;
            CustomerFullNameTextBox.BackColor = Color.White;

            if (String.IsNullOrEmpty(CustomerFullNameTextBox.Text))
            {
                _isDataValid = false;
                CustomerFullNameTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _currentCustomer.FullName = CustomerFullNameTextBox.Text;
            }
            catch (Exception ex)
            {
                _isDataValid = false;
                CustomerFullNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Передает информацию, является ли покупатель приоритетным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = PriorityCheckBox.Checked;
        }
    }
}
