using MDK._01._01_PR_49.Context;
using MDK._01._01_PR_49.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MDK._01._01_PR_49.Controllers
{
    [Route("api/UsersController")]
    [ApiExplorerSettings(GroupName = "v3")]
    public class DishController : Controller
    {
        /// <summary>
        /// Получение списка блюд
        /// </summary>
        /// <param name="Version">Версия блюда</param>
        /// <remarks>Данный метод получает список блюд, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="400">Проблемы при запросе</response>
        [Route("List")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Dish>), 200)]
        [ProducesResponseType(400)]
        public ActionResult List([FromForm] int Version)
        {
            try
            {
                return Json(new DishContext().Dishes.Where(x => x.Version == Version));
            }
            catch
            {
                return StatusCode(400);
            }
        }
    }
}
