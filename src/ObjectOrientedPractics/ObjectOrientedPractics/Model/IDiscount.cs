namespace ObjectOrientedPractics.Model
{
   /// <summary>
   /// Применяется для скидок.
   /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Вычисляет процент на скидку или скидочные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
