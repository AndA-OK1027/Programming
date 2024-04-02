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
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));

            //Массив прямоугольников заполняется случайной длиной и шириной
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Rectangle rectangle = new Rectangle(rand.Next(1, 100) + rand.NextDouble(), rand.Next(1, 100) + rand.NextDouble(), "color");
                _rectangles[i] = rectangle;
            }

            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie("name", "genre", rand.Next(1, 500), 6, 1912);
                _movies[i] = movie;
            }

        }
            
        private Rectangle[] _rectangles = new Rectangle[5];

        private Rectangle _currentRectangle;

        private Movie[] _movies = new Movie[5];

        private Movie _currentMovie;

        /// <summary>
        /// Возвращает индекс прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMax = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > rectangles[indexMax].Width)
                {
                    indexMax = i;
                }
            }
            return indexMax;
        }

        /// <summary>
        /// Возвращает индекс фильма с наибольшей длиной
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private int FindLongestMovie(Movie[] movies)
        {
            int indexMax = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Length > movies[indexMax].Length)
                {
                    indexMax = i;
                }
            }
            return indexMax;
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
            var selected = SeasonHandleComboBox.SelectedItem;
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

        /// <summary>
        /// Кнопка 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindLongestMovie(_movies);
        }

        /// <summary>
        /// При выборе прямоугольника 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = RectanglesListBox.SelectedIndex;

            if (index != -1)
            {
                _currentRectangle = _rectangles[index];

                LengthTextBox.Text = _currentRectangle.Length.ToString();

                WidthTextBox.Text = _currentRectangle.Width.ToString();

                ColorTextBox.Text = _currentRectangle.Color;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Length = Convert.ToInt32(MovieLengthTextBox.Text);
                MovieLengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                MovieLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При смене текста в поле рейтинга меняет 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При смене индекса появляются значения выбранного объекта класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var index = MoviesListBox.SelectedIndex;

            if (index != -1)
            {
                _currentMovie = _movies[index];

                MovieNameTextBox.Text = _currentMovie.Name;

                GenreTextBox.Text = _currentMovie.Genre;

                MovieLengthTextBox.Text = _currentMovie.Length.ToString();

                ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();

                RatingTextBox.Text = _currentMovie.Rating.ToString();
            }
        }
    }
}
