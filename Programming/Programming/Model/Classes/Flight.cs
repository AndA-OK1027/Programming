using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные об отправке и назначении самолета, времени полета.
    /// </summary>
    class Flight
    {
        /// <summary>
        /// Время полета в минутах
        /// </summary>
        private int flightTime;

        /// <summary>
        /// Возвращает и задает пункт вылета, любая строка.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает пункт назначения, любая строка.
        /// </summary>
        public string Destination { get; set; }


        /// <summary>
        /// Возвращает и задает время полета в минутах, только положительные числа.
        /// </summary>
        public int FlightTime
        {
            get { return flightTime; }
            set
            {
                if (value > 0)
                {
                    flightTime = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение для времени");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="departurePoint"></param>
        /// <param name="destination"></param>
        /// <param name="flightTime"></param>
        public Flight(string departurePoint, string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }

        /// <summary>
        /// 
        /// </summary>
        public Flight() { }
    }
}
