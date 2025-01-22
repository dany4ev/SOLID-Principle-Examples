namespace SOLID_Examples.ISP_Violation;

public interface IUser
{
    void BorrowBook(string bookId);
    void ReturnBook(string bookId);
    void SearchCatalog(string searchTerm);
    void AddBook(Book book);
    void RemoveBook(string bookId);
}