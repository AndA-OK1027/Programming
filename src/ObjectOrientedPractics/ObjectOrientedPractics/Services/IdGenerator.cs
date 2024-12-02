namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит уникальный идентификатор - ID.
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private static int _id;

        /// <summary>
        /// Создает уникальный идентификатор и возвращает его.
        /// </summary>
        /// <returns>_id</returns>
        public static int GetNextId()
        {
            return _id++;
        }
    }
}
