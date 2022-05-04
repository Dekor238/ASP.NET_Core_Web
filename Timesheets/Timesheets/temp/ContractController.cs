using Microsoft.AspNetCore.Mvc;

namespace Timesheets.temp
{
    //[ApiController]
    //[Route("[controller]")]
    
    public class ContractController : ControllerBase
    {
        // API 
        // HttpPost - создаем договор
        // HttpGet - получаем список всех договоров
        // HttpGet{id} - получаем договор по ID
        // HttpPut{id} - внести изменения в данные договора по ID 
        // HttpDelete{id} - удалить договор по ID
        
        [HttpPost]
        
        [HttpGet]
        
        [HttpGet]
        
        [HttpPut]
        
        [HttpDelete]
        
        public IActionResult Index()
        {
            return Ok();
        }
    }
}