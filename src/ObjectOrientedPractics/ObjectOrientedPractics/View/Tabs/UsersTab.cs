using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class UsersTab : UserControl
    {
        public UsersTab()
        {
            _customers = new List<Customer>();
            InitializeComponent();
        }

        private List<Customer> _customers;
        private Customer _currentCustomer = new Customer();

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

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            //{
            //    MessageBox.Show("3аполните все поля корректно.");
            //    return;
            //}
            //Customer customer = new Customer(NameTextBox.Text, addressControl1.Address);
            //_customers.Add(customer);
            //CustomersListBox.Items.Add($"{customer.Fullname}");
            try
            {
                Customer user = new Customer(
                    NameTextBox.Text,
                    addressControl1.CurrentAddress);

                Customers.Add(user);
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                var deleted = _customers[index];
                Customers.Remove(deleted);
                CustomersListBox.Items.Remove(CustomersListBox.SelectedItem);
            }
        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
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
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                _currentCustomer = _customers[index];
                DisplayUserInfo(_currentCustomer);
            }
            else
            {
                IdTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
            }
        }

        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear(); // Очищаем предыдущие элементы

            foreach (var user in Customers)
            {
                CustomersListBox.Items.Add(user.Fullname); // Добавляем название каждого товара
            }
        }


        private void DisplayUserInfo(Customer user)
        {
            IdTextBox.Text = user.Id.ToString();
            NameTextBox.Text = user.Fullname;
            addressControl1.DisplayAddress(user.Address);
        }

        private void EditUser()
        {
            if (CustomersListBox.SelectedIndex != -1) 
            {
                Customers[CustomersListBox.SelectedIndex] = _currentCustomer;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer.Fullname;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            EditUser();
        }
    }
}
