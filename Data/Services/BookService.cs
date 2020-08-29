using BooksAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Data.Services
{
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            Data.Books.RemoveAll(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books;
        }

        public Book GetGetBookDetails(int id)
        {
            return Data.Books.FirstOrDefault(book => book.Id == id);
        }

        public void UpdateBook(int id, Book book)
        {
            var oldBook = Data.Books.FirstOrDefault(n => n.Id == id);
            if (oldBook != null)
            {
                oldBook.Title = book.Title;
                oldBook.Author = book.Author;
                oldBook.Description = book.Description;
                oldBook.Rate = book.Rate;
                oldBook.DateStart = book.DateStart;
                oldBook.DateRead = book.DateRead;
            }
        }
    }
}
