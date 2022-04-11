using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SheetsController : Controller
    {
        // API 
        // HttpPost - создаем запись табеля работ
        // HttpGet{id} - получаем данные табеля работ по ID
        // HttpPut{id} - внести изменения в табель работ по ID 
        
        public IActionResult Index()
        {
            return View();
        }
    }
}