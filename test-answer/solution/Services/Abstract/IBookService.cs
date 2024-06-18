using solution.Models.Request;
using solution.Models.Response;

namespace solution.Services.Abstract;

public interface IBookService
{
    public Task<ListOfBooksResponseDTO> GetListOfBooksAsync(ListOfBooksRequestDTO listOfBooksRequestDto);

}