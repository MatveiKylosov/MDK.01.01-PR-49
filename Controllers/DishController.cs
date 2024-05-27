using MDK._01._01_PR_49.Context;
using MDK._01._01_PR_49.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace MDK._01._01_PR_49.Controllers
{
    [Route("api/DishController")]
    [ApiExplorerSettings(GroupName = "v3")]
    public class DishController : Controller
    {
        /// <summary>
        /// Получение списка блюд
        /// </summary>
        /// <param name="VersionId">Версия блюда</param>
        /// <remarks>Данный метод получает список блюд, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="400">Проблемы при запросе</response>
        /// <response code="401">Неавторизированный доступ</response>
        [Route("List")]
        [HttpPost]
        [ProducesResponseType(typeof(List<Dish>), 200)]
        [ProducesResponseType(400)]
        public ActionResult List([FromForm] int VersionId, [FromForm] string Token)
        {
            if (new UserContext().Users.FirstOrDefault(x => x.Token == Token) == null || Token == null)
                return StatusCode(401);

            try
            {
                return Json(new DishContext().Dishes.Where(x => x.VersionId == (decimal)VersionId));

            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }
    }
}
