namespace SOLID_Examples.ISP_Applied;

public class Book
{
    public string BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public override string ToString()
    {
        return $"[BookId: {BookId}, Title: {Title}, Author:{Author}, ISBN:{ISBN}]";
    }
}