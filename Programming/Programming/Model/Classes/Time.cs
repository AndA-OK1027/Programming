using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о времени в часах, минутах и секундах.
    /// </summary>
    class Time
    {
        /// <summary>
        /// Час от 0 до 23.
        /// </summary>
        private int hour;
        /// <summary>
        /// Минута от 0 до 60.
        /// </summary>
        private int minute;
        /// <summary>
        /// Секунда от 0 до 60.
        /// </summary>
        private int second;
        

        /// <summary>
        /// Возвращает и задает час.
        /// </summary>
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value > 0 || value < 24)
                {
                    hour = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое выражение для времени");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает минуты.
        /// </summary>
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value > 0 || value < 60)
                {
                    minute = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое выражение для времени");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает секунды.
        /// </summary>
        public int Second
        {
            get { return second; }
            set
            {
                if (value > 0 || value < 60)
                {
                    second = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое выражение для времени");
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time">.
        /// </summary>
        /// <param name="hour">Час.</param>
        /// <param name="minute">Минуты.</param>
        /// <param name="second">Секунды.</param>
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"> без параметров.
        /// </summary>
        public Time() { }
    }
}
