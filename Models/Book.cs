namespace Library_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }         
        public string? Title { get; set; }
        public int AuthorID { get; set; }
        public string? AuthorName { get; set; }
    }
}
