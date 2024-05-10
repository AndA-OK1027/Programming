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
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// При выборе перечисления из предложенных, показывает все значения этого перечисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выбираем элемент из списка
            var selected = EnumsListBox.SelectedItem;

            switch (selected)
            {
                // Меняется источник данных второго списка 
                case "Color":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Color));
                    break;
                case "EducationForm":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case "Genre":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case "Manufacturers":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacturers));
                    break;
                case "Season":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case "Weekday":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }
        /// <summary>
        /// Выводит в TextBox индекс выбранного элемента перечислений (начиная с 0)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выбранный индекс элемента ListBox
            var index = ValuesListBox.SelectedIndex;

            //Выводится в TextBox
            IntValueTextBox.Text = index.ToString();
        }

        /// <summary>
        /// Инициализирует компоненты элемента управления.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();
        }
    }
}
