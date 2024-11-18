using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Xранит информацию о товаре.
    /// </summary>
    public class Item
    {
        private static int _itemsCount = 0;
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает Название товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringLength(value, 200, nameof(Info));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара в виде вещественного числа.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertDoubleValue(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара, выбор из соответствующего перечисления.
        /// </summary>
        public ItemCategory Category { get; set; }

        /// <summary>
        /// Создает объект класса Товар
        /// </summary>
        /// <param name="name">Название, до 200 символов.</param>
        /// <param name="info">Информация о товаре, до 1000 символов.</param>
        /// <param name="cost">Стоимость, до 100000.</param>
        /// <param name="category">Категория товара, перечисление ItemCategory.</param>

        public Item(string name, string info, double cost, ItemCategory category)
        {
            ++_itemsCount;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _id = _itemsCount;
        }

        /// <summary>
        /// Создает объект класса Товар по умолчанию.
        /// </summary>
        public Item()
        {
            ++_itemsCount;
            _id = _itemsCount;
        }
    }
}