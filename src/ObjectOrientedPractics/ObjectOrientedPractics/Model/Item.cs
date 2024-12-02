using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Событие для изменения названия товара.
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Событие для изменения цены товара.
        /// </summary>
        public event EventHandler CostChanged;

        /// <summary>
        /// Событие для изменения информации товара.
        /// </summary>
        public event EventHandler InfoChanged;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Хранит и возвращает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает название товара. Не должно быть пустым или содержать больше 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                if (_name != value)
                {
                    NameChanged?.Invoke(this, EventArgs.Empty);
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре. Не должно быть пустым или содержать больше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                if (_info != value)
                {
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                    _info = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. Не должно быть меньше 0 или больше 100000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            { 
                ValueValidator.CheckNumberInRange(value, 0, 100000, nameof(Cost));
                if (_cost != value)
                {
                    CostChanged?.Invoke(this, EventArgs.Empty);
                    _cost = value;
                }
            }
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
            Name = "Name";
            Info = "Info";
            Cost = 100.0;
            Category = Category.Groceries;
        }

        /// <summary>
        /// Создает экзмепляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название продукта.</param>
        /// <param name="info">Информация о продукте.</param>
        /// <param name="cost">Цена продукта.</param>
        /// <param name="category">Категория продукта.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Переопределяет метод <see cref="ToString()"/>.
        /// </summary>
        /// <returns>Возвращает <see cref="Name"/>.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        /// <inheritdoc/>
        public bool Equals(Item other)
        {
            if (other == null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Id == other.Id;
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != this.GetType())
                return false;
            return Equals((Item)other);
        }

        /// <inheritdoc />
        public int CompareTo(Item other)
        {
            if (other == null)
                return 1;
            if (Cost < other.Cost)
                return -1;
            if (Cost > other.Cost)
                return 1;
            return 0;
        }
    }
}
