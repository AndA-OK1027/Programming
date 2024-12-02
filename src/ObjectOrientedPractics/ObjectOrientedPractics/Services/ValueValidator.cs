namespace ObjectOrientedPractics
{
    /// <summary>
    /// Проверяет корректность данных.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки и указанного для нее максимума.
        /// </summary>
        /// <param name="str">Строка.</param>
        /// <param name="maxLength">Максимальная длина для строки.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string str, int maxLength, string propertyName)
        {
            if (str.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в указанном диапазоне.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <param name="minValue">Нижняя граница диапазона.</param>
        /// <param name="maxValue">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя войства.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void CheckNumberInRange(double number, double minValue, double maxValue, string propertyName)
        {
            if (number < minValue || number > maxValue)
            {
                throw new ArgumentException($"{propertyName} должен быть в диапазоне от {minValue} до {maxValue}.");
            }
        }

        /// <summary>
        /// Проверяет число на то, есть ли в нем буквы.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void CheckNumberOnLetter(double number, string propertyName)
        {
            foreach (char c in number.ToString())
            {
                if (char.IsLetter(c))
                {
                    throw new ArgumentException($"{propertyName} не должно содержать буквы.");
                }
            }
        }

        /// <summary>
        /// Проверяет слово на то, есть ли в нем цифры.
        /// </summary>
        /// <param name="text">Строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void CheckWordOnDigit(string text, string propertyName)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    throw new ArgumentException($"{propertyName} не должно содержать цифры.");
                }
            }
        }

        /// <summary>
        /// Проверяет на то, пустой ли список.
        /// Если да, то удаляем с экрана элементы внутри <see cref="Panel"/>.
        /// Если в списке есть элементы, отображаем их.
        /// </summary>
        static public void CheckDataForClear(List<Item> list, params Panel[] panels)
        {
            if (list.Count <= 0)
            {
                foreach (var panel in panels)
                {
                    panel.Visible = false;
                }
                return;
            }
            foreach (var panel in panels)
            {
                panel.Visible = true;
            }

        }

        /// <summary>
        /// Проверяет на то, пустой ли список.
        /// Если да, то удаляем с экрана элементы внутри <see cref="Panel"/>.
        /// Если в списке есть элементы, отображаем их.
        /// </summary>
        static public void CheckDataForClear(List<Customer> list, params Panel[] panels)
        {
            if (list.Count <= 0)
            {
                foreach (var panel in panels)
                {
                    panel.Visible = false;
                }
                return;
            }
            foreach (var panel in panels)
            {
                panel.Visible = true;
            }
        }
    }
}
