using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerIntegratedApp.Model
{
    public interface IEmployee
    {
         IEmployee GetEmployee();
    }

    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }

        public IEmployee GetEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
