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
    class Subject
    {
        public string SubjectName { get; set; }

        private int score;

        public string StudentName { get; set; }

        public int Score
        {
            get { return score; }
            set
            {
                if (value > 0)
                {
                    score = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое число");
                }
            }
        }

        public Subject(string subjectName, int score, string studentName)
        {
            SubjectName = subjectName;
            Score = score;
            StudentName = studentName;
        }

        public Subject() { }
    }
}
