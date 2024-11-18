using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Отвечает за работу со списком пользователей
    /// </summary>
    public partial class UsersTab : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента управления
        /// </summary>
        public UsersTab()
        {
            _customers = new List<Customer>();
            InitializeComponent();
            
        }

        private List<Customer> _customers;
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Возвращает и задает список пользователей
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateListBox();
            }
        }

        /// <summary>
        /// Действия выполняемые при нажатии кнопки добавить пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Address address = addressControl1.Address;
            try
            {
                Customer user = new Customer(NameTextBox.Text);
                user.Address = address;
                Customers.Add(user);
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Действия выполняемые при нажатии кнопки удалить пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                Customers.RemoveAt(index);
                UpdateListBox();
            }
        }

        /// <summary>
        /// Событие при изменения текста в поле имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = NameTextBox.Text;
                NameTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            
        }

        /// <summary>
        /// Событие при выборе индекса в списке 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                _currentCustomer = Customers[index];
                DisplayUserInfo(_currentCustomer);
            }
        }

        /// <summary>
        /// Выводит актуальный список в элемент ListBox
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear(); // Очищаем предыдущие элементы

            foreach (var user in Customers)
            {
                CustomersListBox.Items.Add(user.Fullname); // Добавляем название каждого товара
            }
        }

        /// <summary>
        /// Отображает информацию о пользователе в текстовых полях.
        /// </summary>
        /// <param name="user"></param>
        private void DisplayUserInfo(Customer user)
        {
            IdTextBox.Text = user.Id.ToString();
            NameTextBox.Text = user.Fullname;
            addressControl1.DisplayAddress(user.Address);
        }

    }
}
