using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly OfficeContext _officeContext;

        public EmployeeController(OfficeContext dbContext) 
        {
            _officeContext = dbContext;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            var employees = _officeContext.Employees;
            if(employees == null)
            {
                return NotFound();
            }
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var employee = _officeContext.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult post(Employee employee)
        {
            if(employee == null)
            {
                return NotFound();
            }
            _officeContext.Employees.Add(employee);
            _officeContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var employee = _officeContext.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            _officeContext.Employees.Remove(employee);
            _officeContext.SaveChanges();
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id,  Employee employee)
        {
            if(employee == null)
            {
                return NotFound();
            }
            var emp = _officeContext.Employees.Find(id);
            emp.Designation = employee.Designation;
            emp.Salary = employee.Salary;
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.PhoneNumber = employee.PhoneNumber;
            _officeContext.Employees.Update(emp);
            _officeContext.SaveChanges();
            return Ok(employee);
        }
    }
}
