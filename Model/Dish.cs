namespace MDK._01._01_PR_49.Model
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// Идентификатор блюда
        /// </summary>
        public int DishId { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Название блюда
        /// </summary>
        public string NameDish { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// Версия
        /// </summary>
        public int Version { get; set; }
    }
}
