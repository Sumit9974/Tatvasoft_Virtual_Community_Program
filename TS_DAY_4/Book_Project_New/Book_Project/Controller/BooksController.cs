using Book_Project.Model;
using Book_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Book_Project.Controller
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
            public ActionResult<List<Book>> Get() => _bookService.GetAll();

            [HttpGet("{id}")]
            public ActionResult<Book> Get(int id)
            {
                var book = _bookService.GetById(id);
                if (book == null)
                {
                    return NotFound();
                }
                return book;

            }

            [HttpPost]
            public ActionResult<List<Book>> post(Book book)
            {
                _bookService.Add(book);

                return _bookService.GetAll();
            }


        
    }
}
