using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming
{ 
    /// <summary>
    /// Хранит информацию о цветах, используемых в графическом интерфейсе приложения.
    /// </summary>
    public class AppColors
    {
        /// <summary>
        /// Цвет, подсвечивающий правильный вариант.
        /// </summary>
        private static System.Drawing.Color rightIndicator = System.Drawing.Color.FromArgb(100, 100, 255, 127);

        /// <summary>
        /// Цвет, подсвечивающий неправильный вариант.
        /// </summary>
        private static System.Drawing.Color wrongIndicator = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Возвращает цвет, подсвечивающий неправильный вариант.
        /// </summary>
        public static System.Drawing.Color WrongIndicator
        {
            get { return wrongIndicator; }
        }

        /// <summary>
        /// Возвращает цвет, подсвечивающий правильный вариант.
        /// </summary>
        public static System.Drawing.Color RightIndicator
        {
            get { return rightIndicator; }
        }


    }
}
