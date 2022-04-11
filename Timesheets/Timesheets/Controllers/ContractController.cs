using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractController : Controller
    {
        // API 
        // HttpPost - создаем договор
        // HttpGet - получаем список всех договоров
        // HttpGet{id} - получаем договор по ID
        // HttpPut{id} - внести изменения в данные договора по ID 
        // HttpDelete{id} - удалить договор по ID
        public IActionResult Index()
        {
            return View();
        }
    }
}