using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Strategy.BusinessService;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.Controllers
{
    public class HomeController : Controller
    {
        private string _customerId = "SC3214";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string PaymentMode)
        {
            if (!string.IsNullOrEmpty(PaymentMode))
            {
                string bankDetail = GetBankDetail(_customerId, PaymentMode);
                if (!string.IsNullOrEmpty(bankDetail))
                {
                    Context context = new Context();
                    context.SetPaymentStrategy(new PaymentModeFactory().CreateStrategy(PaymentMode));
                    bool isPaymentSuccessful = context.ProcessPayment(bankDetail);
                    if (isPaymentSuccessful)
                    {
                        return RedirectToAction("PaymentSuccess", new RouteValueDictionary(new
                        {
                            Controller = "Home",
                            Action = "PaymentSuccess",
                            Id = PaymentMode == "CreditCard" ? "CreditCard" : "DebitCard"
                        })); ;
                    }
                }
            }
            return Index();
        }

        public IActionResult PaymentSuccess(string Id)
        {
            ViewBag.Param = Id;
            return View();
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
        private string GetBankDetail(string customerId,string paymentMode)
        {
            return "SampleBankDetail";
        }
        
    }
}
