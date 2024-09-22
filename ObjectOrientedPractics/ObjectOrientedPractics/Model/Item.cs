using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Xранит информацию о товаре.
    /// </summary>
    class Item
    {
        private readonly int _id;
        private static int _itemsCount;
        private string _name;
        private string _info;
        private double _cost;

        public int Id
        {
            get { return _id; }
        }

        public static int ItemsCount
        {
            get { return _itemsCount; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Info
        {
            get { return _info; }
        }

        public double Cost
        {
            get { return _cost; }
            set { return _cost; }
        }

        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
