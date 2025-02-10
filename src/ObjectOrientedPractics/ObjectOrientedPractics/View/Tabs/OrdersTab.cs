using System.Data;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

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
                RefreshData();
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
            OrdersDataGridView.CurrentRow.Cells[5].Value = order.Status;
        }

        /// <summary>
        /// Показывает информацию о текущем заказе при смене индекса в DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrderItemsListBox.DataSource = null;
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IdTextBox.Text = string.Empty;
                DateTextBox.Text = string.Empty;
                StatusComboBox.Text = string.Empty;
                addressControl1.Address = new Address();
                AmountLabel.Text = string.Empty;
            }
            else
            {
                Order order = _orders[OrdersDataGridView.CurrentRow.Index];
                if (order is PriorityOrder priorityOrder)
                {
                    PriorityOptionsPanel.Visible = true;
                    DeliveryTimeComboBox.SelectedItem = priorityOrder.DeliveryTime;
                }
                else
                {
                    PriorityOptionsPanel.Visible = false;
                }
                ShowOrderInfo(order);
            }
        }

        /// <summary>
        /// При запуске приложения загружает данные в DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersTab_Load(object sender, EventArgs e)
        {
            RefreshData();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimeRange;
        }


        /// <summary>
        /// Обновляет данные в DataGridView.
        /// </summary>
        public void RefreshData()
        {
            _orders.Clear();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("CustomerName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(double));
            dataTable.Columns.Add("Status", typeof(OrderStatus));
            dataTable.Columns.Add("Total", typeof(double));

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
                        row["Total"] = order.Total;

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
            addressControl1.Address = order.Address;
            OrderItemsListBox.DataSource = order.Items;
            AmountLabel.Text = order.Total.ToString();
        }

        /// <summary>
        /// Хранит информацию о времени прибытия приоритетного заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) { return; }

            if (_orders[OrdersDataGridView.CurrentRow.Index] is PriorityOrder priority)
            {
                priority.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
            }
        }
    }
}
