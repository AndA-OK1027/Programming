using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace InformationSystem
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь файлу для сохранения данных - документы текущего пользователя.
        /// </summary>
        readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "saveddata.txt");

        /// <summary>
        /// Иициализирует компоненты формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Movie> _movies = new List<Movie>();
        private Movie _currentMovie;

        /// <summary>
        /// Добавляет в список фильм со стандартными значениями.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Movie movie = new Movie("name", (Genre)rand.Next(0, 5), rand.Next(1, 300), rand.Next(1, 10), rand.Next(1900, DateTime.Now.Year));
            _movies.Add(movie);
            MoviesListBox.Items.Add($"{movie.Name}/ {movie.ReleaseYear}/ {movie.Genre}");
            MovieSort();
        }

        /// <summary>
        /// Позволяет редактировать данные о выбранном фильме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = MoviesListBox.SelectedIndex;
            if (index != -1)
            {
                _movies.RemoveAt(index);
                _movies.Insert(index, _currentMovie);
                MoviesListBox.Items.RemoveAt(index);
                MoviesListBox.Items.Insert(index, $"{_currentMovie.Name}/ {_currentMovie.ReleaseYear}/ {_currentMovie.Genre}");
            }
            MovieSort();
        }

        /// <summary>
        /// Удаляет выбранный ильм из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = MoviesListBox.SelectedIndex;
            if (index != -1)
            {
                var deleted = _movies[index];
                _movies.Remove(deleted);
                MoviesListBox.Items.Remove(MoviesListBox.SelectedItem);
            }
            MovieSort();
        }

        /// <summary>
        /// При смене текста в поле названия меняет значение в текущем фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentMovie.Name = MovieNameTextBox.Text;
                    MovieNameTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    MovieNameTextBox.BackColor = System.Drawing.Color.LightPink;
                    
                }
            }
        }

        
        /// <summary>
        /// При смене текста в поле длины фильма меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
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
            
        }

        /// <summary>
        /// При смене текста в поле года выпуска меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
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
        }

        /// <summary>
        /// При смене текста в поле рейтинга меняет меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
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
        }

        /// <summary>
        /// При смене индекса в выпадающем списке для жанра меняет меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentMovie.Genre = (Genre)GenreComboBox.SelectedItem;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// При выборе объекта в списке отображает информацию о выбранном фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = MoviesListBox.SelectedIndex;
            if (index != -1)
            {
                _currentMovie = _movies[index];
                DisplayMovieInfo(_currentMovie);
            }
            else
            {
                ClearMovieInfo();
            }
        }

        /// <summary>
        /// Отображает в текстовых полях информацию о выбранном в списке фильме.
        /// </summary>
        /// <param name="_currentmovie">Выбранный фильм.</param>
        private void DisplayMovieInfo(Movie _currentmovie)
        {
            MovieNameTextBox.Text = _currentMovie.Name;
            GenreComboBox.SelectedItem = _currentMovie.Genre;
            MovieLengthTextBox.Text = _currentMovie.Length.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearMovieInfo()
        {
            MovieNameTextBox.Text = String.Empty;
            //GenreComboBox.Items.Clear();
            MovieLengthTextBox.Text = String.Empty;
            ReleaseYearTextBox.Text = String.Empty;
            RatingTextBox.Text = String.Empty;
            
        }

        /// <summary>
        /// Сортирует фильмы в списке по алфавиту.
        /// </summary>
        private void MovieSort()
        {
            _movies = _movies.OrderBy(s => s.Name).ToList();

            MoviesListBox.Items.Clear();
            foreach (Movie movie in _movies)
            {
                MoviesListBox.Items.Add($"{movie.Name}/ {movie.ReleaseYear}/ {movie.Genre}");
            }
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Задает данные для выбора перечислений.
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            string content;

            //Проверка на существование файла для загрузки данных.
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    content = sr.ReadToEnd();
                    _movies = JsonConvert.DeserializeObject<List<Movie>>(content);
                    foreach (Movie movie in _movies)
                    {
                        MoviesListBox.Items.Add($"{movie.Name}/ {movie.ReleaseYear}/ {movie.Genre}");
                    }
                }
            }
            MovieSort();
        }

        /// <summary>
        /// При закрытии формы сохраняет данные из списка в файл в документах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(_movies, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(json);
            }
            MessageBox.Show("Data saved.");
        }
    }
}
