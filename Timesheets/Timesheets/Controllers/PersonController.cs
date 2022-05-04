using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TS.Data.Model;
using TS.Services;

namespace Timesheets.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/person")]

    public class PersonController : ControllerBase
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

        [HttpGet("all")]
        public IActionResult Get()
        {
            var result = _personServices.GetAll();
            return Ok(result);
        }
        
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
            _personServices.Post(person);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult ChangePerson(int id)
        {
            _personServices.Put(id);
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