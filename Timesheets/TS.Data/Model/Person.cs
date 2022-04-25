namespace TS.Data.Model
{
    public class Person
    {
        public int Id { get; set; }             // идентификатор
        public string FirstName { get; set; }   // имя
        public string LastName { get; set; }    // фамилия
        public string Email { get; set; }       // электронная почта
        public string Company { get; set; }     // компания
        public int Age { get; set; }            // возраст
    }
}