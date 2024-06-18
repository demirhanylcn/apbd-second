namespace solution.Models.Domain;

public class BookAuthor
{
    public  int IdAuthor { get; set; }
    public Author Author { get; set; }
    
    public int IdBook { get; set; }
    public Book Book { get; set; }
}