using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    /// <summary>
    /// Хранит информацию об элементе управления, осуществляющим действия с временами года.
    /// </summary>
    public partial class SeasonsControl : UserControl
    {
        /// <summary>
        /// Обработка события нажатия кнопки на элементе управления.
        /// </summary>
        public event EventHandler ButtonClicked;

        /// <summary>
        /// Показывает нажата ли кнопка.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        /// <summary>
        /// Инициализирует компоненты элемента управления.
        /// </summary>
        public SeasonsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает элемент управления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonsControl_Load(object sender, EventArgs e)
        {
            //Изначально задается список всех времен года.
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        /// <summary>
        /// Истинна - если в списке выбрана весна.
        /// </summary>
        public bool isSpring;
        /// <summary>
        /// Истинна - если в списке выбрана осень.
        /// </summary>
        public bool isFall;

        /// <summary>
        /// Производит различные действия, в зависимости от выбранного объекта в ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            //Выбранный элемент.
            var selected = SeasonHandleComboBox.SelectedItem;
            switch (selected)
            {
                case Season.Winter:
                    MessageBox.Show("Холодно");
                    break;
                case Season.Summer:
                    MessageBox.Show("Тепло");
                    break;
            }
            if (selected.Equals(Season.Fall)) {  isFall = true; }
            if (selected.Equals(Season.Spring)) { isSpring = true; }

            OnButtonClicked(EventArgs.Empty);
        }
    }
}
