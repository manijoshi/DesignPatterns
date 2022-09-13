using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Observer.Departments;
using Observer.Models;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsset _it;
        private readonly IFinance _finance;
        private readonly IResignation _resignation;
        private readonly ILibrary _library;

        public HomeController(IAsset it,IFinance finance,IResignation resignation,ILibrary library)
        {
            _it = it;
            _finance = finance;
            _resignation = resignation;
            _library = library;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ITDept()
        {
            _it.AllocateAsset();
            ViewBag.Dept = "IT - Allocated assests";
            return View("Index");
        }
        [HttpPost]
        public IActionResult Finance()
        {
            _finance.CalculateSalary();
            ViewBag.Dept = "Finance - Calculated salary";
            return View("Index");
        }
        [HttpPost]
        public void EmployeeSeparate(string EmployeeId)
        {
            _resignation.NotifyObserver(EmployeeId);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
