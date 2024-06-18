namespace solution.Models.Domain;

public class Book
{
    public int IdBook { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    public int IdPublishingHouse { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
    
    public ICollection<BookGenre> BookGenres { get; set; }
    public ICollection<BookAuthor> BookAuthors { get; set; }
}