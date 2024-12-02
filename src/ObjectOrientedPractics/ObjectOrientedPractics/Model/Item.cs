using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item
    {
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
                _name = value;
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
                _info = value;
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
                //ValueValidator.CheckNumberOnLetter(value, nameof(Cost));
                _cost = value;
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
    }
}
