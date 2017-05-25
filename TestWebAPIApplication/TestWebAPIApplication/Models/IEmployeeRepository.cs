using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPIApplication.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
    }
}