namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При запуске приложения загружает <see cref="CustomerComboBox"/> и  <see cref="ItemsListBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartsTab_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// Выбирает текущего покупателя из Combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomerComboBox.SelectedItem as Customer;
            if (_currentCustomer is null) { return; }
            UpdateCartData();
        }

        /// <summary>
        /// Добавляет в корзину выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem is null || _currentCustomer is null) { return; }
            _currentCustomer.Cart.Items.Add(selectedItem);

            UpdateCartData();
        }

        /// <summary>
        /// Удаляет из корзины выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = CartListBox.SelectedItem as Item;
            if (selectedItem is null) { return; }

            _currentCustomer.Cart.Items.Remove(selectedItem);

            UpdateCartData();
        }

        /// <summary>
        /// Очищает полностью корзину от списка товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer is null) { return; }
            _currentCustomer.Cart.Items.Clear();

            UpdateCartData();
        }

        /// <summary>
        /// Создает заказ на основе списка товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0) { return; }
            Order newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items, _currentCustomer.Cart.Amount);
            _currentCustomer.Orders.Add(newOrder);

            _currentCustomer.Cart.Clear();
            UpdateCartData();
        }

        /// <summary>
        /// Загружает в список корзины данные из списка товаров. Выводит стоимость товаров в корзине.
        /// </summary>
        private void UpdateCartData()
        {
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
        }

        /// <summary>
        /// Перезаписывает данные в списках покупателя и товаров.
        /// </summary>
        public void RefreshData()
        {
            CustomerComboBox.DataSource = null;
            ItemsListBox.DataSource = null;

            CustomerComboBox.DataSource = Customers;
            ItemsListBox.DataSource = Items;
        }
    }
}
