using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
        }

        private List<Item> _items = new List<Item>();
        private Item _currentItem;

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = new Item("f", "f", 1);
            _items.Add(item);
            ItemsListBox.Items.Add($"{item.Name}/ {item.Info}/ {item.Cost}");
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;
            if(index != 1)
            {
                var deleted = _items[index];
                ItemsListBox.Items.Remove(ItemsListBox.SelectedItem);
                _items.Remove(deleted);
            }
        }

        private void ClearTextBoxes()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            InfoTextBox.Text = "";
        }

        private void DisplayItemInfo()
        {
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            InfoTextBox.Text = _currentItem.Info;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;
            if (index != 1)
            {
                _currentItem = _items[index];
                DisplayItemInfo();
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentItem.Name = NameTextBox.Text;
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentItem.Info = InfoTextBox.Text;
        }


    }
}
