using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Служебный класс для генерации идентификаторов.
    /// </summary>
    class IDGenerator
    {
        private static int _currentID = 0;

        /// <summary>
        /// Возвращает следущее значение ид
        /// </summary>
        /// <returns></returns>
        public static int GetNextID() => ++_currentID;
    }
}
