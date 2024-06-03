using TS_DAY_3_DOT_NET.Models;

namespace TS_DAY_3_DOT_NET.Service
{
    public class BookService
    {
        private readonly List<Book> _books;


        public BookService()
        {
            _books = new List<Book>
            {
                new Book{Id=1, Title="Java",Description="ONLY JAVA",Author="Sumit" },
                  new Book{Id=2, Title="DBMS",Description="Only DBMS",Author="Sumit" }
            };
        }

        public List<Book> getAllBooks() => _books;

        public Book GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public void addBook(Book book) => _books.Add(book);
    }
}
