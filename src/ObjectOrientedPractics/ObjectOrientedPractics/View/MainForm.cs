using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ � ���� ������ ������� � ������ �����������.
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();

            _store.Items.Add(new Item());
            _store.Items.Add(new Item());
            _store.Items.Add(new Item());

            _store.Customers.Add(new Customer());
            _store.Customers.Add(new Customer());
            _store.Customers.Add(new Customer());

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;

            OrdersTab.Customers = _store.Customers;
            PriorityOrdersTab.Items = _store.Items;

            ItemsTab.ItemsChanged += RefreshTabsData;
            CustomersTab.CustomersChanged += RefreshTabsData;
            CartsTab.OrdersChanged += RefreshTabsData;
        }

        /// <summary>
        /// ��������� ������ �� �������� "�������" � "������".
        /// </summary>
        /// <param name="sender">������, ��������� �������.</param>
        /// <param name="e">��������� �������.</param>
        void RefreshTabsData(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
