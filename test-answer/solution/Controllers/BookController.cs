using Microsoft.AspNetCore.Mvc;
using solution.CustomExceptions;
using solution.Models.Request;
using solution.Services.Abstract;

namespace solution.Controllers;



[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{

    public IBookService _BookService;
    public BookController(IBookService bookService)
    {
        _BookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> GetListOfBooks([FromBody] ListOfBooksRequestDTO listOfBooksRequestDto)
    {
        try
        {
            var result = await _BookService.GetListOfBooksAsync(listOfBooksRequestDto);
            return Ok(result);
        }
        catch (BookNotExistsException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddNewBook ()
}