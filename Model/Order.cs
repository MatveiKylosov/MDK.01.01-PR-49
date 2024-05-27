using System;

namespace MDK._01._01_PR_49.Model
{
    public class Orders
    {
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Дата заказа.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Идентификатор блюда.
        /// </summary>
        public int DishId { get; set; }

        /// <summary>
        /// Количество блюд.
        /// </summary>
        public int Count { get; set; }
    }

}
