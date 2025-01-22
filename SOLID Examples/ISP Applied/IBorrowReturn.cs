namespace SOLID_Examples.ISP_Applied;

public interface IBorrowReturn
{
    void BorrowBook(string bookId);
    void ReturnBook(string bookId);
}