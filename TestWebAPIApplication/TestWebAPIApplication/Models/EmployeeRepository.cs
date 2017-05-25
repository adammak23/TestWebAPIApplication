using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPIApplication.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> emp = new List<Employee>();
        private int nextEmpId = 1;

        public EmployeeRepository()
        {
            Add(new Employee { EmpName = "Sania", EmpAddress = "New Jersey", EmpDesig = "Manager", EmpDepartment = "Sales", EmpSalary = 55000 });
            Add(new Employee { EmpName = "Tom", EmpAddress = "New Jersey", EmpDesig = "Asstt Manager", EmpDepartment = "Acccount", EmpSalary = 85000 });
            Add(new Employee { EmpName = "John", EmpAddress = "New Jersey", EmpDesig = "Manager", EmpDepartment = "Sales", EmpSalary = 75000 });
        }
        public IEnumerable<Employee> GetAll()
        {
            return emp;
        }
        public Employee Get(int id)
        {
            return emp.Find(p => p.EmpId == id);
        }
        public Employee Add(Employee objEmp)
        {
            if(objEmp==null)
            {
                throw new ArgumentNullException("objEmp");
            }

            objEmp.EmpId = nextEmpId++;
            emp.Add(objEmp);
            return objEmp;
        }
    }
}