using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о предмете в зачетной книжке.
    /// </summary>
    class Subject
    {
        /// <summary>
        /// Название предмета.
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Баллы
        /// </summary>
        private int score;

        /// <summary>
        /// Имя студента.
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Возвращает и задает баллы по предмету, только положительные числа.
        /// </summary>
        public int Score
        {
            get { return score; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Score));
                
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject">.
        /// </summary>
        /// <param name="subjectName">Название предмета.</param>
        /// <param name="score">Баллы.</param>
        /// <param name="studentName">Имя студента.</param>
        public Subject(string subjectName, int score, string studentName)
        {
            SubjectName = subjectName;
            Score = score;
            StudentName = studentName;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject">, без параметров.
        /// </summary>
        public Subject() { }
    }
}
