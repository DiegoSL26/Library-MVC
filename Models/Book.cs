namespace Library_MVC.Models
{
    public class Book
    {
        public int id { get; set; }         
        public string? title { get; set; }
        public int authorID { get; set; }

        public Author Author { get; set; }
    }
}
