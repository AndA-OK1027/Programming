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
    /// Хранит информацию об элементе управления, осуществляющим действия с фильмами.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Инициализирует компоненты элемента управления.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie("name", "genre", rand.Next(1, 500), 6, 1925);
                _movies[i] = movie;
            }
        }

        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        /// <summary>
        /// Возвращает индекс фильма с наибольшей длиной.
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
        /// Отображает на ListBox фильм с наибольшей длиной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindLongestMovie(_movies);
        }

        /// <summary>
        /// При смене текста в поле названия меняет значение в текущем фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
        }

        /// <summary>
        /// При смене текста в поле жанра меняет значение в текущем фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        /// <summary>
        /// При смене текста в поле длины фильма меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
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
        /// При смене текста в поле года выпуска меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
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
        /// При смене текста в поле рейтинга меняет меняет значение в текущем фильме, при неправильном вводе меняет цвет поля ввода на красный.
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
        /// При смене индекса появляются значения выбранного объекта класса.
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
