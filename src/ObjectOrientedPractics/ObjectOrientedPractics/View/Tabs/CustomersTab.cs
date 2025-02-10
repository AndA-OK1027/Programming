using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Событие для изменения информации о товарах.
        /// </summary>
        public event EventHandler CustomersChanged;

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

            CustomersChanged?.Invoke(this, EventArgs.Empty);
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

            CustomersChanged?.Invoke(this, EventArgs.Empty);
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
            CustomersDiscountsListBox.DataSource = _currentCustomer.Discounts;

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

                CustomersChanged?.Invoke(this, EventArgs.Empty);
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

        /// <summary>
        /// Удаляет выбранную скидку на категорию товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is null || CustomersDiscountsListBox.SelectedIndex < 1) return;

            _currentCustomer.Discounts.RemoveAt(CustomersDiscountsListBox.SelectedIndex);

            CustomersDiscountsListBox.DataSource = null;
            CustomersDiscountsListBox.DataSource = _currentCustomer.Discounts;
        }

        /// <summary>
        /// Добавляет ту скиду на товары, что выберет пользователь в появляющейся форме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            ShowAddDiscountForm();
        }

        /// <summary>
        /// Выводит форму и запоминает выбор пользователя.
        /// </summary>
        public void ShowAddDiscountForm()
        {
            if (CustomersListBox.SelectedItem is null)
            {
                MessageBox.Show("Пожалуйста, выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var addDiscountForm = new AddDiscountForm();

            if (addDiscountForm.ShowDialog() == DialogResult.OK)
            {
                Category selectedCategory = addDiscountForm.SelectedCategory;

                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    if (discount is PercentDiscount percentDiscount && percentDiscount.Category == selectedCategory)
                    {
                        MessageBox.Show("Скидка для этой категории уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                PercentDiscount newDiscount = new PercentDiscount(selectedCategory);
                _currentCustomer.Discounts.Add(newDiscount);

                CustomersDiscountsListBox.DataSource = null;
                CustomersDiscountsListBox.DataSource = _currentCustomer.Discounts;
            }
        }
    }
}
