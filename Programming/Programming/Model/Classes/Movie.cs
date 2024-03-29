using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// 
    /// </summary>
    class Movie
    {
        /// <summary>
        /// Длина фильма в минутах.
        /// </summary>
        private int length;
        /// <summary>
        ///Год выпуска фильма. 
        /// </summary>
        private int releaseYear;
        /// <summary>
        /// Рейтинг от 0.0 до 10.0.
        /// </summary>
        private double rating;

        /// <summary>
        /// Название фильма, любая строка.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Жанр фильма, любая строка.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает время фильма в минутах.
        /// </summary>
        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Длина фильма должна быть больше нуля");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма от 0.0 до 10.0
        /// </summary>
        public double Rating
        {
            get { return rating; }
            set
            {
                if (value > 0 || value < 10)
                {
                    rating = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение рейтинга");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма от 1900 до текущего года.
        /// </summary>
        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                if (value > 1900 || value <= DateTime.Today.Year)
                {
                    releaseYear = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение года выпуска");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="genre"></param>
        /// <param name="length"></param>
        /// <param name="rating"></param>
        /// <param name="releaseYear"></param>
        public Movie(string name, string genre, int length, double rating, int releaseYear)
        {
            Name = name;
            Genre = genre;
            Length = length;
            Rating = rating;
            ReleaseYear = releaseYear;
        }

        public Movie() { }
    }
}
