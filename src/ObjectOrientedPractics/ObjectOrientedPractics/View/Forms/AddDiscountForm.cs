using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Хранит выбранную категорию товара
        /// </summary>
        public Category SelectedCategory { get; private set; }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает форму данными из категории товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Сохраняет выбор категории.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Закрывает окно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
