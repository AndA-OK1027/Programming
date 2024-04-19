using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {   
            if (value < 0)
            {
                throw new ArgumentException($"{ propertyName } must be a positive value.");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{ propertyName } must be a positive value.");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{ propertyName } out of range.");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{ propertyName } out of range.");
            }
        }
    }
}
