using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TS_DAY_3_DOT_NET.Models;
using TS_DAY_3_DOT_NET.Service;

namespace TS_DAY_3_DOT_NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get() => _bookService.getAllBooks();

    }

}
