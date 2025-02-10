using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;
namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит список заказов.
        /// </summary>
        private PriorityOrder _order = new PriorityOrder();

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает в элементы странички данные при загрузки приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            _order.Address = new Address(643111, "Russia", "Tomsk", "Lenina", "50", "111");
            UpdateOrderInfo();
        }

        /// <summary>
        /// Добавляет в заказ товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddRandomItem();
            UpdateOrderItemsInfo();
        }

        /// <summary>
        /// Удаляет из заказа выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedItem == null) { return; }
            _order.Items.Remove(OrderItemsListBox.SelectedItem as Item);
            UpdateOrderItemsInfo();
        }

        /// <summary>
        /// Сохраняет информацию о выборе пользователя в комбобоксе прибытия товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
            UpdateOrderItemsInfo();
        }

        /// <summary>
        /// Сохраняет информацию о выборе пользователя в комбобоксе статуса готовности товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Status = (OrderStatus)StatusComboBox.SelectedItem;
            UpdateOrderItemsInfo();
        }

        /// <summary>
        /// Удаляет заказ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearOrder_Click(object sender, EventArgs e)
        {
            _order = new PriorityOrder();
            UpdateOrderInfo();
        }

        /// <summary>
        /// Обновляет информацию в списке товаров заказа и ценнике.
        /// </summary>
        private void UpdateOrderItemsInfo()
        {
            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DataSource = _order.Items;
            AmountTextBox.Text = _order.Cost.ToString();
        }

        /// <summary>
        /// Добавляет в заказ случайный товар.
        /// </summary>
        private void AddRandomItem()
        {
            if (_items != null && _items.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, _items.Count);
                _order.Items.Add(_items[randomIndex]);
            }
            else
            {
                MessageBox.Show("Список товаров пуст!");
            }
        }

        /// <summary>
        /// Обновляет информацию во всех объектах странички при изменении состояния.
        /// </summary>
        public void UpdateOrderInfo()
        {
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimeRange;

            UpdateOrderItemsInfo();
            IdTextBox.Text = _order.Id.ToString();
            DateTextBox.Text = _order.Date.ToString();
            StatusComboBox.SelectedItem = _order.Status;
            DeliveryTimeComboBox.SelectedItem = _order.DeliveryTime;
            addressControl.Address = _order.Address;
        }
    }
}
