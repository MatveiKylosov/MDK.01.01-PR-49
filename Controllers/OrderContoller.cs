using MDK._01._01_PR_49.Context;
using MDK._01._01_PR_49.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MDK._01._01_PR_49.Controllers
{
    [Route("api/OrderContoller")]
    [ApiExplorerSettings(GroupName = "v4")]
    public class OrderContoller : Controller
    {
        /// <summary>
        /// Создает новый заказ.
        /// </summary>
        /// <param name="Address">Адрес доставки</param>
        /// <param name="Date">Дата заказа</param>
        /// <param name="DishId">Идентификатор блюда</param>
        /// <param name="Count">Количество блюд</param>
        /// <returns>Информация о созданном заказе</returns>
        /// <response code="200">Заказ успешно принят</response>
        /// <response code="400">Проблема при запросе</response>
        [Route("AddOrder")]
        [HttpPost]
        [ProducesResponseType(typeof(Orders), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult AddOrder([FromForm] string Address, [FromForm] DateTime Date, [FromForm] int DishId, [FromForm] int Count)
        {
            try
            {
                var newOrder = new OrderContext();

                Orders order = new Orders()
                {
                    Address = Address,
                    Date = Date,
                    DishId = DishId,
                    Count = Count
                };

                newOrder.Orders.Add(order);
                newOrder.SaveChanges();

                return Json(order);

            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }

        /// <summary>
        /// Возвращает историю заказов
        /// </summary>
        /// <returns>История заказов</returns>
        /// <response code="200">запросы выполнен</response>
        /// <response code="400">Проблема при запросе</response>
        /// <response code="401">Неавторизированный доступ</response>
        [Route("History")]
        [HttpPost]
        [ProducesResponseType(typeof(List<Orders>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult History()
        {
            try
            {
                return Json(new OrderContext().Orders);

            }catch (Exception ex)
            {
                return StatusCode(400);
            }
        }
    }
}
