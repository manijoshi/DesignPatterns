using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.DataAccess
{
    public class Book
    {
        public string BookId { get; set; }
        public string Name { get; set; }
    }
    public interface IStore
    {
        void IncreaseStock(string bookId);
        void DecreaseStock(string bookId);
        Book GetBook(string bookId);
        int GetTotalStock(string bookId);
    }
    public class BookStore : IStore
    {
        Dictionary<string, (Book book, int stock)> _books;
        public BookStore()
        {
            _books = new Dictionary<string, (Book book, int stock)>();
            _books["B001"] = (new Book { BookId = "B001", Name = "The Kite Runner" },10);
            _books["B002"] = (new Book { BookId = "B002", Name = "A Thousand splendid Suns" },2);
        }
        public void DecreaseStock(string bookId)
        {
            var remainingQuantity = _books[bookId].stock - 1;
            _books[bookId] = (_books[bookId].book, remainingQuantity);
        }

        public Book GetBook(string bookId)
        {
            return _books[bookId].book;
        }

        public int GetTotalStock(string bookId)
        {
            return _books[bookId].stock;
        }

        public void IncreaseStock(string bookId)
        {
            _books[bookId] = (_books[bookId].book, _books[bookId].stock + 1);
        }
    }
}
