using Microsoft.AspNetCore.Mvc;
using EmployeeWebApplication.Models;
using EmployeeWebApplication.Services;

namespace EmployeeWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            var employee = _service.GetById(id);
            if (employee is null)
                return NotFound();
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            _service.Add(employee);
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Employee employee)
        {
            if (id != employee.Id)
                return BadRequest();
            var existing = _service.GetById(id);
            if (existing is null)
                return NotFound();
            _service.Update(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _service.GetById(id);
            if (existing is null)
                return NotFound();
            _service.Delete(id);
            return NoContent();
        }
    }
}