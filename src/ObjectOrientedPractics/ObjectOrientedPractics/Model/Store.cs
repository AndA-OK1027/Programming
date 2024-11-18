using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    internal class Store
    {
        /// <summary>
        /// Список товаров, доступных в магазине.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает или задает список товаров в магазине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Возвращает или задает список покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value ?? new List<Customer>(); }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Store"/> класса.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
