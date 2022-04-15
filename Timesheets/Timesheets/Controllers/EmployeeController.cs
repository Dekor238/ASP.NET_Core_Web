using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timesheets.Core;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : Controller
    {
        // API 
        // HttpPost - создаем сотрудника
        // HttpGet - получаем список всех сотрудников
        // HttpGet{id} - получаем сотрудника по ID
        // HttpPut{id} - внести изменения в данные сотрудника по ID 
        // HttpDelete{id} - удалить сотрудника по ID

        [HttpPost("create")]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            return Ok(employee);
        }

        [HttpGet("get")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            return Ok();
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<Employee>> GetById(Guid id)
        {
            return Ok();
        }
        
        [HttpPut("update/{id}")]
        public async Task<ActionResult> Create()
        {
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteId(Guid id)
        {
            return Ok();
        }

    }
}