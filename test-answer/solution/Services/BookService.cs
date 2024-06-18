using solution.CustomExceptions;
using solution.Models.Request;
using solution.Models.Response;
using solution.Repositories.Abstract;
using solution.Services.Abstract;

namespace solution.Services;

public class BookService : IBookService
{
    public IBookRepository _BookRepository;
    public BookService(IBookRepository bookRepository)
    {
        _BookRepository = bookRepository;
    }


    public async Task<ListOfBooksResponseDTO> GetListOfBooksAsync(ListOfBooksRequestDTO? listOfBooksRequestDto)
    {
        var checkBook = await _BookRepository.CheckBookExistsAsync();
        if (!checkBook) throw new BookNotExistsException();
       
        if (listOfBooksRequestDto == null)
        {
            var result = await _BookRepository.GetListOfBooksAsyncNotFiltered();
            return result;
        }
        else
        {
            var result = await _BookRepository.GetListOfBooksAsyncFiltered(listOfBooksRequestDto);
            return result;
        }
    }


    public async void AddBookAsync(AddBookRequestDTO addBookRequestDto)
    {
        await  _BookRepository.AddBookAsync(addBookRequestDto);
        await _BookRepository.SaveChangesAsync();
        
    }
}