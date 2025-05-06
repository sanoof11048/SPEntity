using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPEntity.Model;
using SPEntity.Services.EmployeeService;

namespace SPEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmp()
        {
            var emp = await _employeeService.GetAllEmp();
            return Ok(emp);
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeleteEmp(int id)
        {
            await _employeeService.DeleteEmp(id);
            return Ok("EMployee Deleted");
        }

        [HttpPost]
        public async Task<IActionResult> AddEmp(Employee emp)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _employeeService.AddEmp(emp);
            return Ok("Employee Added Succussfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmp(Employee emp)
        {
            await _employeeService.UpdateEmp(emp);
            return Ok("Employee Updated Succussfully");
        }
    }
}
