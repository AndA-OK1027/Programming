using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Событие для изменения информации о товарах.
        /// </summary>
        public event EventHandler OrdersChanged;
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
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers {  get; set; }

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
            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;
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

            double discountAmount = 0;
            List<IDiscount> selectedDiscounts = new List<IDiscount>();

            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                var discount = _currentCustomer.Discounts[index];
                discountAmount += discount.Apply(_currentCustomer.Cart.Items);
                selectedDiscounts.Add(discount);
            }

            if (_currentCustomer.IsPriority)
            {

                PriorityOrder newOrder = new PriorityOrder(DateTime.Now.AddDays(1), PriorityOrder.DeliveryTimeRange[0],
                    _currentCustomer.Address, _currentCustomer.Cart.Items, discountAmount);

                _currentCustomer.Orders.Add(newOrder);
            }
            else
            {
                Order newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items, discountAmount);
                _currentCustomer.Orders.Add(newOrder);
            }

            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }

            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;

            _currentCustomer.Cart.Clear();
            UpdateCartData();
            OrdersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Загружает в список корзины данные из списка товаров. Выводит стоимость товаров в корзине.
        /// </summary>
        private void UpdateCartData()
        {
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();

            double currentDiscount = CalculateDiscount();
            DiscountAmountLabel.Text = currentDiscount.ToString();

            double totalPrice = _currentCustomer.Cart.Amount - currentDiscount;
            TotalPriceLabel.Text = totalPrice.ToString();

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

        /// <summary>
        /// Высчитывает размер скидки
        /// </summary>
        /// <returns>Размер скидки</returns>
        private double CalculateDiscount()
        {
            double discountAmount = 0;
            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                discountAmount += _currentCustomer.Discounts[index].Calculate(_currentCustomer.Cart.Items);
            }

            return discountAmount;
        }

        /// <summary>
        /// Сохраняет пользовательский выбор в чекбоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountsCheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateCartData();
        }
    }
}
