using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerIntegratedApp.Model;

namespace SwaggerIntegratedApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> employees;
        public EmployeeController()
        {
           employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            }
        };
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return employees.Find(e => e.Id == id);
        }
        // POST: api/Employee
        [HttpPost]
        [Produces("application/json")]
        public Employee Post([FromBody] Employee employee)
        {
            // Logic to create new Employee
            employees.Add(employee);
            return employee;
        }
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee employee)
        {
            var updatedEmployee = employees.Find(e => e.Id == id);
            if(updatedEmployee != null)
            {
                updatedEmployee = employee;
                return updatedEmployee;
            }
            return null;
        }
        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            }
        };
        }
    }
}