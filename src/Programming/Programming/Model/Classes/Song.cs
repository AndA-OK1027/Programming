using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о песне в плеере: название, автор, длина.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Длина в секундах.
        /// </summary>
        private int songLength;

        /// <summary>
        /// Задает название песни. Любая строка.
        /// </summary>
        public string SongName { get; set; }

        /// <summary>
        /// Задает имя автора. Любая строка.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Задает и возвращает продолжительность песни в минутах, только положительные числа.
        /// </summary>
        public int SongLength
        {
            get { return songLength; }
            set
            {
                if (value > 0)
                {
                    songLength = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое выражение");
                }
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Song">.
        /// </summary>
        /// <param name="songName">Название песни, любая строка.</param>
        /// <param name="authorName">Имя автора, любая строка.</param>
        /// <param name="songLength">Продолжительность песни в минутах, только положительные числа.</param>
        public Song(string songName, string authorName, int songLength)
        {
            SongName = songName;
            AuthorName = authorName;
            SongLength = songLength;
        }

        /// <summary>
        /// Создает объект класса <see cref="Song">, без параметров.
        /// </summary>
        public Song() { }
    }
}
