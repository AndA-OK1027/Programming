using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента управления
        /// </summary>
        public CustomersTab()
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
            Address address = CustomerAddressControl.Address;
            try
            {
                Customer user = new Customer(CustomerFullNameTextBox.Text, address);
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
                _currentCustomer.FullName = CustomerFullNameTextBox.Text;
                CustomerFullNameTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                CustomerFullNameTextBox.BackColor = System.Drawing.Color.LightPink;
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
                CustomersListBox.Items.Add(user.FullName); // Добавляем название каждого товара
            }
        }

        /// <summary>
        /// Отображает информацию о пользователе в текстовых полях.
        /// </summary>
        /// <param name="user"></param>
        private void DisplayUserInfo(Customer user)
        {
            CustomerIdTextBox.Text = user.Id.ToString();
            CustomerFullNameTextBox.Text = user.FullName;
            CustomerAddressControl.DisplayAddress(user.Address);
        }


    }
}
