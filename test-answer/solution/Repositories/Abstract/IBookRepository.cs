using solution.Models.Request;
using solution.Models.Response;

namespace solution.Repositories.Abstract;

public interface IBookRepository : IBaseRepository
{
    public Task<ListOfBooksResponseDTO> GetListOfBooksAsyncNotFiltered();
    public Task<ListOfBooksResponseDTO> GetListOfBooksAsyncFiltered(ListOfBooksRequestDTO listOfBooksRequestDto);

    public  Task<bool> CheckBookExistsAsync();
    public Task AddBookAsync(AddBookRequestDTO addBookRequestDto);


}