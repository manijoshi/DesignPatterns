using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Command.Models;
using Command.Commands;
using Command.Business;
using Command.DataAccess;

namespace Command.Controllers
{
    public class HomeController : Controller
    {
        ICommandManager _commandManager;
        private readonly IStore _store;
        private readonly ICart _cart;

        public HomeController(IStore store, ICart cart, ICommandManager commandManager)
        {
            _store = store;
            _cart = cart;
            _commandManager = commandManager;
        }

        public IActionResult Index()
        {
            DisplayCartDetail();
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart()
        {
            _commandManager.Invoke(
                new AddToShoppingCartCommand(GetBook(), _store, _cart));

            DisplayCartDetail();
            return View("Index");
        }

        [HttpPost]
        public IActionResult MoveToWishList()
        {
            _commandManager.Invoke(
               new AddToWishListCommand(GetBook(), _store, _cart));

            DisplayCartDetail();
            return View("Index");
        }

        [HttpPost]
        public IActionResult Undo()
        {
            _commandManager.Undo();

            DisplayCartDetail();
            return View("Index");
        }

        private void DisplayCartDetail()
        {
            Book book = GetBook();

            ViewBag.TotalCartItems = _cart.GetShoppingCartCount(book);
            ViewBag.TotalWishListItems = _cart.GetWishListCount(book);
        }

        private Book GetBook()
        {
            return _store.GetBook("B001");
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
