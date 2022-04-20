using Microsoft.AspNetCore.Mvc;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : Controller
    {
        // API 
        // HttpPost - создаем счет по работам
        
        [HttpPost]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}