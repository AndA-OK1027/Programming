﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о фильме: название, жанр, рейтинг, год выпуска, продолжительность.
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
                Validator.AssertOnPositiveValue(value, nameof(Length));
                length = value;
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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                rating = value;
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
                Validator.AssertValueInRange(value, 1900, DateTime.Today.Year, nameof(ReleaseYear));
                releaseYear = value;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Movie">.
        /// </summary>
        /// <param name="name">Название, любая строка.</param>
        /// <param name="genre">Жанр, любая строка.</param>
        /// <param name="length">Длина, только положительные числа.</param>
        /// <param name="rating">Рейтинг, вещественные числа от 0 до 10.</param>
        /// <param name="releaseYear">Год выпуска от 1900 до текущего года.</param>
        public Movie(string name, string genre, int length, double rating, int releaseYear)
        {
            Name = name;
            Genre = genre;
            Length = length;
            Rating = rating;
            ReleaseYear = releaseYear;
        }

        /// <summary>
        /// Создает объект класса <see cref="Movie">, без параметров.
        /// </summary>
        public Movie() { }
    }
}
