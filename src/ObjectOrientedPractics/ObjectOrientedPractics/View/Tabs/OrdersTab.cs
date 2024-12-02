using System.Data;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает и задаёт список всех покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateOrders();
            }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Меняет статус выбранного заказа, в случае его изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) { return; }
            Order order = _orders[OrdersDataGridView.CurrentRow.Index];
            order.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Показывает информацию о текущем заказе при смене индекса в DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrderItemsListBox.DataSource = null;

            if (OrdersDataGridView.CurrentRow == null) return;

            var currentIndex = OrdersDataGridView.CurrentRow.Index;
            if (currentIndex < 0 || currentIndex >= _orders.Count) return;

            Order order = _orders[currentIndex];
            ShowOrderInfo(order);
        }

        /// <summary>
        /// При запуске приложения загружает данные в DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersTab_Load(object sender, EventArgs e)
        {
            UpdateOrders();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }


        /// <summary>
        /// Обновляет данные в DataGridView.
        /// </summary>
        public void UpdateOrders()
        {
            _orders.Clear();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("CustomerName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(double));
            dataTable.Columns.Add("Status", typeof(OrderStatus));

            foreach (var customer in _customers)
            {
                if (customer?.Orders != null)
                {
                    foreach (var order in customer.Orders)
                    {
                        _orders.Add(order);

                        var row = dataTable.NewRow();
                        row["ID"] = order.Id;
                        row["Date"] = order.Date;
                        row["CustomerName"] = customer.FullName;
                        row["Address"] = customer.Address?.ToString() ?? string.Empty;
                        row["Amount"] = order.Cost;
                        row["Status"] = order.Status;

                        dataTable.Rows.Add(row);
                    }
                }
            }

            OrdersDataGridView.DataSource = dataTable;
        }

        /// <summary>
        /// Показывает информацию о заказе.
        /// </summary>
        /// <param name="order">Заказ.</param>
        private void ShowOrderInfo(Order order)
        {
            IdTextBox.Text = order.Id.ToString();
            DateTextBox.Text = order.Date.ToString();
            StatusComboBox.SelectedItem = order.Status;
            OrdersAddressControl.Address = order.Address;
            OrderItemsListBox.DataSource = order.Items;
            AmountLabel.Text = order.Cost.ToString();
        }

    }
}
