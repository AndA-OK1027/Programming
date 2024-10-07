using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
        }

        private List<Item> _items = new List<Item>();
        private Item _currentItem;

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
            Item item = new Item(NameTextBox.Text, InfoTextBox.Text, cost);
            _items.Add(item);
            ItemsListBox.Items.Add($"{item.Name} / {item.Cost}:C");
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                var deleted = _items[index];
                _items.Remove(deleted);
                ItemsListBox.Items.Remove(ItemsListBox.SelectedItem);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                _items.RemoveAt(index);
                _items.Insert(index, _currentItem);
                ItemsListBox.Items.RemoveAt(index);
                ItemsListBox.Items.Insert(index, $"{_currentItem.Name} / {_currentItem.Cost}:C");
            }
        }

        private void ClearTextBoxes()
        {
            IdTextBox.Text = String.Empty;
            CostTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            InfoTextBox.Text = String.Empty;
        }

        private void DisplayItemInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
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
                catch
                {
                    CostTextBox.BackColor = System.Drawing.Color.LightPink;
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


    }
}
