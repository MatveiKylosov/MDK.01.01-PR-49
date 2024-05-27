using MDK._01._01_PR_49.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System;
using MDK._01._01_PR_49.Context;

namespace MDK._01._01_PR_49.Controllers
{
    [Route("api/UsersController")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : Controller
    {
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="Login">Логин пользователя</param>
        /// <param name="Password">Пароль пользователя</param>
        /// <returns>Данный метод предназначен для авторизации пользователя на сайте</returns>
        /// /// <response code = "200">Пользователь успешно авторизован</response>
        /// /// <response code = "403">Ошибка запроса, данные не указан</response>
        /// /// <response code = "200">При выполнении запроса возникли ошибки</response>
        [Route("SingIn")]
        [HttpPost]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public ActionResult SingIn([FromForm] string Login, [FromForm] string Password)
        {
            if (Login == null || Password == null)
                return StatusCode(403);
            try
            {
                User User = new UserContext().Users.Where(x => x.Login == Login && x.Password == Password).FirstOrDefault();
                if (User == null)
                {
                    return StatusCode(401);
                }
                return Json(User);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }


        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="Login">Логин пользователя</param>
        /// <param name="Password">Пароль пользователя</param>
        /// <returns>Данный метод предназначен для регистрации пользователя на сайте</returns>
        /// /// <response code = "200">Пользователь успешно зарегистрирована</response>
        /// /// <response code = "403">Ошибка запроса, данные не указан</response>
        /// /// <response code = "200">При выполнении запроса возникли ошибки</response>

        [Route("RegIn")]
        [HttpPost]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public ActionResult RegIn([FromForm] string Login, [FromForm] string Password, [FromForm] string Email)
        {
            if (Login == null || Password == null)
                return StatusCode(403);
            try
            {
                User User = new User();
                User.Login = Login;
                User.Password = Password;
                User.Email = Email;

                UserContext usersContext = new UserContext();
                usersContext.Users.Add(User);
                usersContext.SaveChanges();

                return Json(User);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
