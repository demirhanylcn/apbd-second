using solution.Models.Domain;
using solution.Models.Response;

namespace solution.Models.Request;

public class AddBookRequestDTO
{
        public int IdPublishingHouse { get; set; }
        public string name { get; set; }
        public string Country { get; set; }
        public string city { get; set; }
        public AuthorDTO AuthorDTO { get; set; }
}