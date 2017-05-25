using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPIApplication.Models;

namespace TestWebAPIApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        static readonly IEmployeeRepository empRepository = new EmployeeRepository();

        public IEnumerable<Employee> GetAllEmployees()
        {
            return empRepository.GetAll();
        }
        public Employee GetEmployee(int empId)
        {
            Employee emp = empRepository.Get(empId);
            if (emp == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return emp;
        }
    }
}
