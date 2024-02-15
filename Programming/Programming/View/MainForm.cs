using System;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Изначально задается источник данных элемента ComboBox, где будут показываться времена года
            SeasonsHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
        }
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
                case  "Color":
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
        /// Выводит в TextBox индекс выбранного элемента перечислений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ValuesListBox.SelectedIndex;

            IntValueTextBox.Text = index.ToString();
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

        /// <summary>
        /// Производит разные действия в зависимости от выбранного времени года из предложенных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            //выбранный элемент
            var selected = SeasonsHandleComboBox.SelectedItem;
            switch (selected)
            {
                case Season.Winter:
                    //В случае, если выбрана зима появяется сообщение о том, что холодно
                    MessageBox.Show("Холодно");
                    break;
                case Season.Spring:
                    //В случае весны цвет фона меняется на зеленый
                    Enums.BackColor = System.Drawing.Color.FromArgb(147, 222, 140);
                    break;
                case Season.Summer:
                    //То же, что и с зимой, но не холодно
                    MessageBox.Show("Нехолодно и скорее всего солнечно");
                    break;
                case Season.Fall:
                    //Осень - цвет фона - оранжевый
                    Enums.BackColor = System.Drawing.Color.FromArgb(242, 178, 39);
                    break;
            }
        }

    }
}
