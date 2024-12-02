using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ’ранит в себе список товаров и список покупателей.
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
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainTabControl.SelectedIndex)
            {
                case 2:
                    CartsTab.RefreshData();
                    break;
                case 3:
                    OrdersTab.UpdateOrders();
                    break;
            }
        }
    }
}
