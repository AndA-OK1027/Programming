using ObjectOrientedPractics.Model.Enums;
namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента управления.
        /// </summary>
        public ItemsTab()
        {
            _items = new List<Item>();
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            UpdateListBox();
        }

        private List<Item> _items;
        Item _currentItem = new Item();

        /// <summary>
        /// Возвращает и задает список товаров
        /// </summary>
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
        /// Добавляет объект в список.
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
            Item item = new Item(NameTextBox.Text, InfoTextBox.Text, cost, (Category)CategoryComboBox.SelectedItem);
            Items.Add(item);
            UpdateListBox();
            //ItemsListBox.Items.Add(item.Name);
        }

        /// <summary>
        /// Удаляет объект из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                Items.RemoveAt(ItemsListBox.SelectedIndex);
                UpdateListBox();
                ClearTextBoxes();
            }
        }

        /// <summary>
        /// Очищает текстовые поля
        /// </summary>
        private void ClearTextBoxes()
        {
            IdTextBox.Text = String.Empty;
            CostTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            InfoTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Выводит актуальный список в элемент ListBox
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear(); // Очищаем предыдущие элементы

            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item.Name); // Добавляем название каждого товара
            }
        }

        /// <summary>
        /// Отображает информацию в текстовых полях.
        /// </summary>
        /// <param name="item"></param>
        private void DisplayItemInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
            CategoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Отображает информацию о выбранном в списке объекте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Сохраняет в объекте пользователя значение поля цены и обрабатывает исключение подсвечивая поле красным
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Сохраняет в объекте пользователя значение поля названия и обрабатывает исключение подсвечивая поле красным
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Сохраняет в объекте пользователя значение поля информации и обрабатывает исключение подсвечивая поле красным
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                try
                {
                    Items[ItemsListBox.SelectedIndex] = _currentItem;
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = _currentItem.Name;
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        /// <summary>
        /// Сохраняет в объекте пользователя значение перечисления категории и обраюатывает исключение подсвечивая поле красным
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1)
            {
                try
                {
                    _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// При выходе из текстового поля сохраняет измененные данные о пользователе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }

        /// <summary>
        /// При выходе из текстового поля сохраняет измененные данные о пользователе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }

        /// <summary>
        /// При выходе из текстового поля сохраняет измененные данные о пользователе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }

        /// <summary>
        /// При выходе из текстового поля сохраняет измененные данные о пользователе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoTextBox_Leave(object sender, EventArgs e)
        {
            EditItem();
        }
    }
}
