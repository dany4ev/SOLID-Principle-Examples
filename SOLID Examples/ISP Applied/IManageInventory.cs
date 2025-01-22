namespace SOLID_Examples.ISP_Applied;

public interface IManageInventory
{
    void AddBook(Book book);
    void RemoveBook(string bookId);
}