using Library_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
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
            Dbconnection dbconnection = new Dbconnection();
            string query = "SELECT * FROM Author";
            SqlCommand cmd = new SqlCommand(query, dbconnection.Open_Connection());
            List<Author> authorList = [];
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    authorList.Add(new Author { Id = Convert.ToInt32(reader["id"]), Name = reader["authorName"].ToString() });
                }
            }
            dbconnection.Close_Connection();
            return Json(authorList);
        }

        [HttpGet]
        public JsonResult GetBooks()
        {
            Dbconnection dbconnection = new Dbconnection();
            string query = "SELECT B.title as 'title', A.authorName as 'authorName' FROM Book B JOIN Author A ON B.authorID = A.id";
            SqlCommand cmd = new SqlCommand(query, dbconnection.Open_Connection());
            List<Book> bookList = [];
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bookList.Add(new Book { Title = reader["title"].ToString(), AuthorName = reader["authorName"].ToString() });
                }
            }
            dbconnection.Close_Connection();
            return Json(bookList);
        }

        [HttpPost]
        public bool AddAuthor(Author author)
        {
            Dbconnection dbconnection = new Dbconnection();
            try
            {
                string query = "INSERT INTO Author VALUES (@name)";
                SqlCommand cmd = new SqlCommand(@query, dbconnection.Open_Connection());
                cmd.Parameters.AddWithValue("@name", author.Name);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                dbconnection.Close_Connection();
            }
        }

        [HttpPost]
        public bool AddBook(Book book)
        {
            Dbconnection dbconnection = new Dbconnection();
            try
            {
                string query = "INSERT INTO Book (Title, AuthorID) VALUES (@title, @authorid)";
                SqlCommand cmd = new SqlCommand(@query, dbconnection.Open_Connection());
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@authorid", book.AuthorID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                dbconnection.Close_Connection();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
