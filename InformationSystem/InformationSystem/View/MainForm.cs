using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }

        private List<Movie> _movies = new List<Movie>();
        private Movie _currentMovie;

        private void AddButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Movie movie = new Movie("name", Genre.Drama, rand.Next(1, 300), 6, 1925);
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

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentMovie.Genre = (Genre)GenreComboBox.SelectedItem;
                    RatingTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }
         
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

        private void DisplayMovieInfo(Movie _currentmovie)
        {
            MovieNameTextBox.Text = _currentMovie.Name;
            GenreComboBox.SelectedItem = _currentMovie.Genre;
            MovieLengthTextBox.Text = _currentMovie.Length.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            
        }

        private void ClearMovieInfo()
        {
            MovieNameTextBox.Text = String.Empty;
            //GenreComboBox.Items.Clear();
            MovieLengthTextBox.Text = String.Empty;
            ReleaseYearTextBox.Text = String.Empty;
            RatingTextBox.Text = String.Empty;
            
        }

        private void MovieSort()
        {
            _movies = _movies.OrderBy(s => s.Name).ToList();

            //MoviesListBox.Items.Clear();
            //foreach (Movie movie in _movies)
            //{
            //    MoviesListBox.Items.Add(movie);
            //}
        }
    }
}
