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
            InitializeComponent();
        }

        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("3аполните все поля корректно.");
                return;
            }
            Customer customer = new Customer(NameTextBox.Text, AddressTextBox.Text);
            _customers.Add(customer);
            CustomersListBox.Items.Add($"{customer.Fullname}");
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                var deleted = _customers[index];
                _customers.Remove(deleted);
                CustomersListBox.Items.Remove(CustomersListBox.SelectedItem);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                _customers.RemoveAt(index);
                _customers.Insert(index, _currentCustomer);
                CustomersListBox.Items.RemoveAt(index);
                CustomersListBox.Items.Insert(index, $"{_currentCustomer.Fullname}");
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

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentCustomer.Address = AddressTextBox.Text;
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
                DisplayItemInfo(_currentCustomer);
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            IdTextBox.Text = String.Empty;
            AddressTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
        }

        private void DisplayItemInfo(Customer user)
        {
            IdTextBox.Text = user.Id.ToString();
            NameTextBox.Text = user.Fullname;
            AddressTextBox.Text = user.Address;
        }
    }
}
