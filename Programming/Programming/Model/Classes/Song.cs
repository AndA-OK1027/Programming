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
        /// 
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
        /// 
        /// </summary>
        /// <param name="songName"></param>
        /// <param name="authorName"></param>
        /// <param name="songLength"></param>
        public Song(string songName, string authorName, int songLength)
        {
            SongName = songName;
            AuthorName = authorName;
            SongLength = songLength;
        }

        /// <summary>
        /// 
        /// </summary>
        public Song() { }
    }
}
