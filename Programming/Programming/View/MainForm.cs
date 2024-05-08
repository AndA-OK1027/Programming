using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

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
                Rectangle rectangle = RectangleFactory.Randomize();
            }
            
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie("name", "genre", rand.Next(1, 500), 6, 1925);
                _movies[i] = movie;
            }

        }
           
        
        private Rectangle[] rectangles = new Rectangle[5];
        private Rectangle currentRectangle;
        
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();
        private Panel _currentPanel;


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
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(rectangles);
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
        /// При смене индекса появляются значения выбранного объекта класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = RectanglesListBox.SelectedIndex;

            if (index != -1)
            {
                currentRectangle = rectangles[index];

                LengthTextBox.Text = currentRectangle.Height.ToString();

                WidthTextBox.Text = currentRectangle.Width.ToString();

                ColorTextBox.Text = currentRectangle.Color;

                CenterCoordTextBox.Text = "(" + currentRectangle.Center.X.ToString() + " ; " + currentRectangle.Center.Y.ToString() + ")";

                IdTextBox.Text = currentRectangle.Id.ToString();
            }

        }


        /// <summary>
        /// При смене текста в поле длины меняет значение в текущем прямоугольнике, при неправильном вводе меняет цвет поля ввода на красный
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentRectangle.Height = Convert.ToInt32(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
                
        }

        /// <summary>
        /// При смене текста в поле ширины меняет значение в текущем прямоугольнике, при неправильном вводе меняет цвет поля ввода на красный
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При смене текста в поле цвета меняет значение в текущем прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// При смене текста в поле названия меняет значение в текущем фильме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
        }

        /// <summary>
        /// При смене текста в поле жанра меняет значение в текущем фильме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        /// <summary>
        /// При смене текста в поле длины фильма меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный
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
        /// При смене текста в поле года выпуска меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный
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
        /// При смене текста в поле рейтинга меняет меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный
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

        
        /// <summary>
        /// При нажатии кнопки добавляет прямоугольник в список _rectangles и отображает его на канве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            CollisionRectanglesListBox.Items.Add($"{rectangle.Id}:(X={rectangle.Center.X}, Y={rectangle.Center.Y}, W={rectangle.Width}, H={rectangle.Height})");
            //CollisionRectanglesListBox.Items.Add(rectangle);
            Panel panel = new Panel();
            panel.BackColor = System.Drawing.Color.FromArgb(100, 100, 255, 127);
            int panelX = rectangle.Center.X - rectangle.Width / 2;
            int panelY = rectangle.Center.Y - rectangle.Height / 2;
            panel.Location = new Point(panelX, panelY);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            _rectanglePanels.Add(panel);
            FindCollisions();
            CanvasPanel.Controls.Add(panel);
            
        }

        /// <summary>
        /// При нажатии кнопки удаляет прямоугольник из списка и с канвы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            var index = CollisionRectanglesListBox.SelectedIndex;
            if (index != -1)
            {
                var deleted = _rectangles[index];
                CollisionRectanglesListBox.Items.Remove(CollisionRectanglesListBox.SelectedItem);
                CanvasPanel.Controls.RemoveAt(index);
                _rectangles.Remove((Rectangle)deleted);
                _rectanglePanels.RemoveAt(index);
                FindCollisions();
            }
        }

        /// <summary>
        /// При выборе объекта в ListBox  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CollisionRectanglesListBox.SelectedIndex;
            //Выполняются действия, только если выбран объект в списке.
            if (index != -1)
            {
                _currentRectangle = _rectangles[index];
                ChangeRectangleInfo(_currentRectangle);
                _currentPanel = _rectanglePanels[index];
                //Вычисляем координаты отображаемого прямоугольника, использую координаты центра, заданные объектом класса Rectangle.
                int panelX = _currentRectangle.Center.X - _currentRectangle.Width / 2;
                int panelY = _currentRectangle.Center.Y - _currentRectangle.Height / 2;
                //Задаем свойства отображаемой панели.
                _currentPanel.Location = new Point(panelX, panelY);
                _currentPanel.Width = _currentRectangle.Width;
                _currentPanel.Height = _currentRectangle.Height;
                //Поиск пересечений.
                FindCollisions();
                
            }
            else
            {
                //Если ни одного объекта не выбрано, очищаются текстовые поля.
                ClearRectangleInfo();
            }

        }

        /// <summary>
        /// При изменении текста в поле для координаты X, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Center.X = Convert.ToInt32(CollisionXTextBox.Text);
                    CollisionXTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CollisionXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        /// <summary>
        /// При изменении текста в поле для координаты Y, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Center.Y = Convert.ToInt32(CollisionYTextBox.Text);
                    CollisionYTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CollisionYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        /// <summary>
        /// При изменении текста в поле для ширины, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Width = Convert.ToInt32(CollisionWidthTextBox.Text);
                    CollisionWidthTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CollisionWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        /// <summary>
        /// При изменении текста в поле для высоты, меняет соответствующее свойство прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollisionHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CollisionRectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentRectangle.Height = Convert.ToInt32(CollisionHeightTextBox.Text);
                    CollisionHeightTextBox.BackColor = System.Drawing.Color.White;

                }
                catch
                {
                    CollisionHeightTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            
        }

        /// <summary>
        /// Находит на канве пересекающиеся прямоугольники и подсвечивает их красным.
        /// </summary>
        private void FindCollisions()
        {
            foreach(Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.LightPink;
                        _rectanglePanels[j].BackColor = System.Drawing.Color.LightPink;
                    }
                }
            }
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            CollisionIDTextBox.Text = String.Empty;
            CollisionXTextBox.Text = String.Empty;
            CollisionYTextBox.Text = String.Empty;
            CollisionWidthTextBox.Text = String.Empty;
            CollisionHeightTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Выводит данные о прямоугольнике, выбранном в списке.
        /// </summary>
        /// <param name="_currentRectangle"></param>
        private void ChangeRectangleInfo(Rectangle _currentRectangle)
        {
            CollisionIDTextBox.Text = _currentRectangle.Id.ToString();
            CollisionXTextBox.Text = _currentRectangle.Center.X.ToString();
            CollisionYTextBox.Text = _currentRectangle.Center.Y.ToString();
            CollisionWidthTextBox.Text = _currentRectangle.Width.ToString();
            CollisionHeightTextBox.Text = _currentRectangle.Height.ToString();
        }
    }
}
