using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksAPI.Data.Models;
using BooksAPI.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BookController : Controller
    {
        IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        [HttpGet("All")]
        public List<Book> GetAllBooks()
        {
           return  _bookService.GetAllBooks();
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Book GetBookDetails(int id)
        {
            return _bookService.GetGetBookDetails(id);
        }

        [HttpPost("Add")]
        public void AddNewBook([FromBody]Book book)
        {
             _bookService.AddBook(book);
        }
        [HttpPost("Update/{id}")]
        public void UpdateBook([FromBody] Book book, int id)
        {
            _bookService.UpdateBook(id, book);
        }

        [HttpDelete("Delete/{id}")]
        public void DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
        }
    }
}
