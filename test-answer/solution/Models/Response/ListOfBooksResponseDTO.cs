using solution.Models.Domain;

namespace solution.Models.Response;

public class ListOfBooksResponseDTO
{
    public int IdBook { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    public List<PublishingHouseDTO> PublishingHouseDtos { get; set; }
    public List<AuthorDTO> AuthorDtos { get; set; }
    public List<GenreDTO> GenreDtos { get; set; }
}