namespace SOLID_Examples.ISP_Applied;

public class Member : IBorrowReturn, ISearchable
{
    public void BorrowBook(string bookId)
    {
        // Implementation to borrow a book.
        Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
    }
    public void ReturnBook(string bookId)
    {
        // Implementation to return a book.
        Console.WriteLine($"Member Return Book, BookId: {bookId}");
    }
    public void SearchCatalog(string searchTerm)
    {
        // Implementation to search books.
        Console.WriteLine($"Member Search Book, Search Catalog: {searchTerm}");
    }
}