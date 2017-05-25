using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Http.Results;
using TestWebAPIApplication.Models;
using TestWebAPIApplication.Controllers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
   public class TestEmployeeController
    {
        [TestMethod]
        public void GetAppEmployees_ShouldReturnAllEmployees()
        {
            var testEmployee = GetAllEmployees();
            var controller = new EmployeeController();
            var result = controller.GetAllEmployees() as List<Employee>;
            Assert.AreEqual(testEmployee.Count, result.Count);
        }
        private List<Employee> GetAllEmployees()
        {
            var testEmployee = new List<Employee>();
            testEmployee.Add(new Employee
            {
                EmpName = "Sania",
                EmpAddress="New Jersey",
                EmpDesig="Manager",
                EmpDepartment="Sales",
                EmpSalary=55000
            });
            testEmployee.Add(new Employee
            {
                EmpName = "Tom",
                EmpAddress = "New Jersey",
                EmpDesig = "Asstt Manager",
                EmpDepartment = "Account",
                EmpSalary = 85000
            });
            testEmployee.Add(new Employee
            {
                EmpName = "John",
                EmpAddress = "New Jersey",
                EmpDesig = "Manager",
                EmpDepartment = "Sales",
                EmpSalary = 75000
            });
            return testEmployee;
        }
    }
}
