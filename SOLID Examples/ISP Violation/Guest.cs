namespace SOLID_Examples.ISP_Violation;

public class Guest : IUser
{
    public void BorrowBook(string bookId)
    {
        throw new NotImplementedException("Guests cannot borrow books.");
    }
    public void ReturnBook(string bookId)
    {
        throw new NotImplementedException("Guests cannot return books.");
    }
    public void SearchCatalog(string searchTerm)
    {
        // Implementation to search books.
    }
    public void AddBook(Book book)
    {
        throw new NotImplementedException("Guests cannot add books.");
    }
    public void RemoveBook(string bookId)
    {
        throw new NotImplementedException("Guests cannot remove books.");
    }
}