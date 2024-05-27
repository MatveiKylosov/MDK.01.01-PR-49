using MDK._01._01_PR_49.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MDK._01._01_PR_49.Controllers
{
    [Route("api/VersionController")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class VersionController : Controller
    {
        /// <summary>
        /// Список версий
        /// </summary>
        /// <remarks>Данный метод предназначен для вывода список версий, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="400">Проблемы при запросе</response>
        [Route("List")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Version>), 200)]
        [ProducesResponseType(400)]
        public ActionResult List()
        {
            try
            {
                return Json(new VersionContext().Versions);
            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }
    }
}
