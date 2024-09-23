using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private List<Item> _items = new List<Item>();
        private Item _currentItem;

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = new Item("f", "f", 1);
            _items.Add(item);
            ItemsListBox.Items.Add($"{item.Name}");
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;
            if (index != 1)
            {
                var deleted = _items[index];
                ItemsListBox.Items.Remove(ItemsListBox.SelectedItem);
                _items.Remove(deleted);
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

            if (index != 1)
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
            if (ItemsListBox.SelectedIndex != 1)
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
            if (ItemsListBox.SelectedIndex != 1)
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
            if (ItemsListBox.SelectedIndex != 1)
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

