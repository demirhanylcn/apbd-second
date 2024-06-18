namespace solution.CustomExceptions;

public class BookNotExistsException : Exception
{
    public BookNotExistsException() : base("There is no existing book.")
    {
        
    }
}