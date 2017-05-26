using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestWebAPIApplication.Models;

namespace TestWebAPIApplication.Controllers
{
    public class HomeController : Controller
    {




        public async Task<ActionResult> Index()
        {

            double x = await EmployeeRepository.calculate();
            ViewBag.Title = "Home Page";
            ViewBag.XD = "Mnożnik: " +x;
            return View();
        }

    }
}
