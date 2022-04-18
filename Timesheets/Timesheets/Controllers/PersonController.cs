using Microsoft.AspNetCore.Mvc;
using TS.Data.Model;
using TS.Services;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("api/person")]

    public class PersonController : Controller
    {
        private readonly IPersonServices _personServices;

        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }
        // GET /persons/{id} — получение человека по идентификатору
        // GET /persons/search?searchTerm={term} — поиск человека по имени
        // GET /persons/?skip={5}&take={10} — получение списка людей с пагинацией
        // POST /persons — добавление новой персоны в коллекцию
        // PUT /persons — обновление существующей персоны в коллекции
        // DELETE /persons/{id} — удаление персоны из коллекции

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_personServices.Get(id));
        }

        [HttpGet("search")]
        public IActionResult Get(string searchTerm)
        {
            return Ok(_personServices.Search(searchTerm));
        }

        [HttpGet]
        public IActionResult Get(int skip, int take)
        {
            var responce = _personServices.GetPag(skip, take);
            return Ok(responce);
        }

        [HttpPost("add")]
        public IActionResult AddPerson(Person person)
        {
            _personServices.Post();
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult ChangePerson(int id)
        {
            return Ok();
        }
        
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            _personServices.Delete(id);
            return Ok();
        }
    }
}