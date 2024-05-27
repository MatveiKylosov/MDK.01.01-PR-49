namespace MDK._01._01_PR_49.Model
{
    public class User
    {
        /// <summary>
        /// Индефикатор пользователя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Почта пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
