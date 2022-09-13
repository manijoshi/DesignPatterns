using AuthenticationComponent;
using AuthorizationComponent;
using Contracts;
using LoginModule.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ValidationComponent;

namespace LoginModule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoginFacade _loginFacade;

        public HomeController(ILoginFacade loginFacade)
        {
            _loginFacade = loginFacade;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string userName,string password)
        {
            if (_loginFacade.CanLogin(userName, password))
            {
                return RedirectToAction("Home");
            }
            return Index();
            
        }
        public IActionResult Home()
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
