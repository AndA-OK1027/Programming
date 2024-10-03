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
    /// Хранит информацию об элементе управления, осуществляющим действия с днями недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента кправления.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При нажатии на кнопку с надписью Parse отображает является ли введенное днем недели и если является, 
        /// показывает индекс (начиная с 1)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday parsedWeekday;
            //Введенный текст, который нужно обработать
            var weekdayText = ParsingTextBox.Text;
            //Если введенный текст распознается как значение weekday, переменная принимает значение истина, и 
            //меняет значение переменной parsedWeekday, чтобы показать, что такой день недели действительно есть в перечислении
            bool isParsed = Enum.TryParse(weekdayText, out parsedWeekday);

            //Ярлык, который был скрыт делается видимым, и на нем будет выведено сообщение
            WeekdayOutputLabel.Visible = true;
            if (isParsed)
            {
                WeekdayOutputLabel.Text = string.Format("Это день недели ({0} = {1}).", parsedWeekday.ToString(), (int)parsedWeekday);
            }
            else
            {
                WeekdayOutputLabel.Text = "Нет такого дня недели.";
            }
        }
    }
}
