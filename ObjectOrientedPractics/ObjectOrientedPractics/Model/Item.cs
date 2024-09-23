using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Xранит информацию о товаре.
    /// </summary>
    class Item
    {
        private static int _itemsCount;
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает количество все товаров.
        /// </summary>
        public static int ItemsCount
        {
            get { return _itemsCount; }
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
                _name = Name;
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
                _info = Info;
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
                _cost = Cost; 
            }
        }

        /// <summary>
        /// Создает объект класса Товар
        /// </summary>
        /// <param name="name">Название, до 200 символов.</param>
        /// <param name="info">Информация о товаре, до 1000 символов.</param>
        /// <param name="cost">Стоимость, до 100000.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _itemsCount++;
            _id = _itemsCount;
        }
    }
}
