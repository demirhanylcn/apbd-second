using Microsoft.EntityFrameworkCore;
using solution.Context;
using solution.Models.Domain;
using solution.Models.Request;
using solution.Models.Response;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public class BookRepository : BaseRepository, IBookRepository
{
    public BookRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        
    }


    public async Task<ListOfBooksResponseDTO> GetListOfBooksAsyncNotFiltered()
    {
        var booksQuery = _appDbContext.Books
            .Include(b => b.BookAuthors)
            .ThenInclude(ba => ba.Author)
            .Include(b => b.BookGenres)
            .ThenInclude(bg => bg.Genre)
            .Include(b => b.PublishingHouse)
            .OrderBy(b => b.PublishingHouse.Name)
            .ThenByDescending(e => e.ReleaseDate);

        var books = await booksQuery.ToListAsync();
       
       


        var response = new ListOfBooksResponseDTO
        {
            IdBook = books.Select(b => b.IdBook).FirstOrDefault(),
            Name = books.Select(b => b.Name).FirstOrDefault(),
            ReleaseDate = books.Select(b => b.ReleaseDate).FirstOrDefault(),
            AuthorDtos = books.SelectMany(b => b.BookAuthors)
                .Select(ba => new AuthorDTO
                {
                    IdAuthor = ba.Author.IdAuthor,
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName
                }).ToList(),
            GenreDtos = books.SelectMany(b => b.BookGenres)
                .Select(bg => new GenreDTO
                {
                    IdGenre = bg.Genre.IdGenre,
                    Name = bg.Genre.Name
                }).ToList(),
            PublishingHouseDtos = books.Select(b => new PublishingHouseDTO
            {
                IdPublishingHouse = b.PublishingHouse.IdPublishingHouse,
                Name = b.PublishingHouse.Name
            }).ToList()
        };


        return response;
    }

    public async Task<ListOfBooksResponseDTO> GetListOfBooksAsyncFiltered(ListOfBooksRequestDTO listOfBooksRequestDto)
    {
        var booksQuery = _appDbContext.Books
            .Include(b => b.BookAuthors)
            .ThenInclude(ba => ba.Author)
            .Include(b => b.BookGenres)
            .ThenInclude(bg => bg.Genre)
            .Include(b => b.PublishingHouse)
            .Where(e => e.ReleaseDate == listOfBooksRequestDto.ReleaseDate)
            .OrderBy(b => b.PublishingHouse.Name)
            .ThenByDescending(e => e.ReleaseDate);

        var books = await booksQuery.ToListAsync();
       
       


        var response = new ListOfBooksResponseDTO
        {
            IdBook = books.Select(b => b.IdBook).FirstOrDefault(),
            Name = books.Select(b => b.Name).FirstOrDefault(),
            ReleaseDate = books.Select(b => b.ReleaseDate).FirstOrDefault(),
            AuthorDtos = books.SelectMany(b => b.BookAuthors)
                .Select(ba => new AuthorDTO
                {
                    IdAuthor = ba.Author.IdAuthor,
                    FirstName = ba.Author.FirstName,
                    LastName = ba.Author.LastName
                }).ToList(),
            GenreDtos = books.SelectMany(b => b.BookGenres)
                .Select(bg => new GenreDTO
                {
                    IdGenre = bg.Genre.IdGenre,
                    Name = bg.Genre.Name
                }).ToList(),
            PublishingHouseDtos = books.Select(b => new PublishingHouseDTO
            {
                IdPublishingHouse = b.PublishingHouse.IdPublishingHouse,
                Name = b.PublishingHouse.Name
            }).ToList()
        };


        return response; 
    }

    public async Task<bool> CheckBookExistsAsync()
    {
        var result = await _appDbContext.Books.AnyAsync();
        return result;
    }
    
        
    }
