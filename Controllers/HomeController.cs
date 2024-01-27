using Library_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly LibraryContext _context;

        public HomeController(ILogger<HomeController> logger, LibraryContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Author()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAuthors()
        {
            return Json(_context.Author.ToList());
        }

        [HttpGet]
        public JsonResult GetBooks()
        {
            return Json(_context.Book.Include(b => b.Author).ToList());
        }

        [HttpPost]
        public bool AddAuthor(Author author)
        {
            try
            {
                _context.Add(author);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost]
        public bool AddBook(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
