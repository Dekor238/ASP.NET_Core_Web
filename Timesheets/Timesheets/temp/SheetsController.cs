using Microsoft.AspNetCore.Mvc;

namespace Timesheets.temp
{
    // [ApiController]
    // [Route("[controller]")]
    public class SheetsController : Controller
    {
        // API 
        // HttpPost - создаем запись табеля работ
        // HttpGet{id} - получаем данные табеля работ по ID
        // HttpPut{id} - внести изменения в табель работ по ID 
        
        [HttpPost]
        
        [HttpGet]
        
        [HttpPut]
        
        public IActionResult Index()
        {
            return Ok();
        }
    }
}