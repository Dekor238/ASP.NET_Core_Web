namespace TS.Data.Model
{
    public class Users
    {
        public int id { get; set; }             // id пользователя для авторизации в API
        public string login { get; set; }       // логин пользователя
        public string passwd { get; set; }      // пароль пользователя
    }
}