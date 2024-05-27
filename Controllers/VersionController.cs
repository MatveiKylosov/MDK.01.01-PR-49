using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MDK._01._01_PR_49.Controllers
{
    public class VersionController
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
                IEnumerable<Version> Versions = new VersionContext().Versions;
                return Json(Versions);
            }
            catch
            {
                return StatusCode(400);
            }
        }
    }
}
