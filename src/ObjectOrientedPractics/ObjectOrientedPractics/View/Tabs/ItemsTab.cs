using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            _items = new List<Item>();
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(ItemCategory));
            UpdateListBox();
        }

        private List<Item> _items;

        Item _currentItem = new Item();

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value ?? new List<Item>();
                UpdateListBox();
            }
        }

        /// <summary>
        /// Добавляет объект в список..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(InfoTextBox.Text) ||
                !double.TryParse(CostTextBox.Text, out double cost))
            {
                MessageBox.Show("3аполните все поля корректно.");
                return;
            }
            Item item = new Item(NameTextBox.Text, InfoTextBox.Text, cost, (ItemCategory)CategoryComboBox.SelectedItem);
            Items.Add(item);
            UpdateListBox();
            //ItemsListBox.Items.Add(item.Name);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                Items.Remove((Item)ItemsListBox.SelectedItem);
                ItemsListBox.Items.Remove(ItemsListBox.SelectedItem);
                ClearTextBoxes();
            }
        }

        
        private void ClearTextBoxes()
        {
            IdTextBox.Text = String.Empty;
            CostTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            InfoTextBox.Text = String.Empty;
        }

        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear(); // Очищаем предыдущие элементы

            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item.Name); // Добавляем название каждого товара
            }
        }

        private void DisplayItemInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
            CategoryComboBox.SelectedItem = item.Category;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                _currentItem = _items[index];
                DisplayItemInfo(_currentItem);
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
                    CostTextBox.BackColor = System.Drawing.Color.White;
                }
                catch(Exception ex)
                {
                    CostTextBox.BackColor = System.Drawing.Color.LightPink;
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(CostTextBox, ex.Message);
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentItem.Name = NameTextBox.Text;
                    NameTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    NameTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }

        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentItem.Info = InfoTextBox.Text;
                    InfoTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    InfoTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }

        }

        void EditItem()
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Items[ItemsListBox.SelectedIndex] = _currentItem;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = _currentItem.Name;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1)
            {
                try
                {
                    _currentItem.Category = (ItemCategory)CategoryComboBox.SelectedItem;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }

        private void CategoryComboBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }

        private void InfoTextBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }
    }
}
