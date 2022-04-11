using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        // API 
        // HttpPost - создаем сотрудника
        // HttpGet - получаем всех сотрудников
        // HttpGet{id} - получаем сотрудника по ID
        // HttpPut{id} - внести изменения в данные сотрудника по ID 
        // HttpDelete{id} - удалить сотрудника по ID
        public IActionResult Index()
        {
            return View();
        }
    }
}