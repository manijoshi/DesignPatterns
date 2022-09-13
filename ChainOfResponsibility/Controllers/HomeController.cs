using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChainOfResponsibility.Models;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment()
        {
            var product = GetSelectedProductDetail();

            var handler = new VoucherPaymentHandler();

            handler.SetNext(new WalletPaymentHandler())
                .SetNext(new DebitCardPaymentHandler())
                .SetNext(new CreditCardPaymentHandler());

            handler.Handle(product);

            ViewBag.HandledBy = product.HandledBy;
            return View("Index");
        }

        private Product GetSelectedProductDetail()
        {
            Product product = new Product();
            if (!string.IsNullOrEmpty(Request.Form["Camera"]))
            {
                product.Name = "SLR Camera";
                product.Cost = int.Parse(Request.Form["CameraPrice"]);
            }
            if (!string.IsNullOrEmpty(Request.Form["IPhone"]))
            {
                product.Name = "IPhone";
                product.Cost = int.Parse(Request.Form["IPhonePrice"]);
            }
            if (!string.IsNullOrEmpty(Request.Form["Watch"]))
            {
                product.Name = "Watch";
                product.Cost = int.Parse(Request.Form["WatchPrice"]);
            }

            return product;
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
