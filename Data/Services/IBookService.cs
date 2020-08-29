using BooksAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Data.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetGetBookDetails(int id);
        void UpdateBook(int id, Book existingBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);
    }
}
