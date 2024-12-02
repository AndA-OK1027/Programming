using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Фильтрует  и сортирует данные.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Делегат, который проверяет, подходит ли указанный элемент под определённое условие фильтрации.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Возвращает True, если элемент соответствует условию фильтрации, иначе - False.</returns>
        public delegate bool FilterCondition(Item item);

        /// <summary>
        /// Фильтрует список товаров по заданному условию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="condition">Условие фильтрации.</param>
        /// <returns>Новый список, содержащий только товары, удовлетворяющие условию.</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> condition)
        {
            List<Item> itemsFiltered = new List<Item>();

            foreach (var item in items)
            {
                if (condition(item))
                {
                    itemsFiltered.Add(item);
                }
            }

            return itemsFiltered;
        }
        
        /// <summary>
        /// Сортирует список товаров с помощью заданной функции сравнения.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="comparer">Метод сравнения двух товаров.</param>
        /// <returns>Новый отсортированный список товаров.</returns>
        public static List<Item> Sort(List<Item> items, Func<Item, Item, int> comparer)
        {
            List<Item> sortedItems = new List<Item>(items);
            sortedItems.Sort(new Comparison<Item>(comparer));
            return sortedItems;
        }

        /// <summary>
        /// Проверяет, превышает ли стоимость товара 5000.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <returns>True, если стоимость больше 5000, иначе False.</returns>
        public static bool CostMore5000(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Проверяет, принадлежит ли товар заданной категории.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <returns>True, если товар принадлежит категории Cybersport, иначе False.</returns>
        public static bool IsCategory(Item item)
        {
            return item.Category == Category.Groceries;
        }

        /// <summary>
        /// Сравнивает два товара по имени с учетом регистра.
        /// </summary>
        /// <param name="x">Первый товар.</param>
        /// <param name="y">Второй товар.</param>
        /// <returns>Результат сравнения имен.</returns>
        public static int CompareByName(Item x, Item y)
        {
            return string.Compare(x.Name, y.Name);
        }

        /// <summary>
        /// Сравнивает два товара по стоимости по возрастанию.
        /// </summary>
        /// <param name="x">Первый товар.</param>
        /// <param name="y">Второй товар.</param>
        /// <returns>Результат сравнения стоимости.</returns>
        public static int CompareByCostAscending(Item x, Item y)
        {
            return x.CompareTo(y);
        }

        /// <summary>
        /// Сравнивает два товара по стоимости по убыванию.
        /// </summary>
        /// <param name="x">Первый товар.</param>
        /// <param name="y">Второй товар.</param>
        /// <returns>Результат сравнения стоимости.</returns>
        public static int CompareByCostDescending(Item x, Item y)
        {
            return y.CompareTo(x);
        }
    }
}
